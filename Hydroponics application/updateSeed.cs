﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydroponics_application
{

    public class updateSeed
    {
        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int getTimesPlantedFromDatabase(string seedName)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            int timesPlanted = 0;
            SqlCommand getTimesPlanted = new SqlCommand("SELECT seed_times_planted FROM SEEDS WHERE seed_name=@seedName", con);
            getTimesPlanted.Parameters.Add(new SqlParameter("seedName", seedName));
            timesPlanted = Convert.ToInt32(getTimesPlanted.ExecuteScalar());
            return timesPlanted;
        }
        public int getTimesSproutedFromDatabase(string seedName)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            int timesSprouted = 0;
            SqlCommand getTimesSprouted = new SqlCommand("SELECT seed_times_sprouted FROM SEEDS WHERE seed_name=@seedName", con);
            getTimesSprouted.Parameters.Add(new SqlParameter("seedName", seedName));
            timesSprouted = Convert.ToInt32(getTimesSprouted.ExecuteScalar());
            return timesSprouted;
        }
        public float getGerminationRate(int timesPlanted, int timesSprouted)
        {
            float germinationRate = 0;
            germinationRate = (float)timesSprouted / (float)timesPlanted * 100;
            return germinationRate;
        }
        public int getSeedId(string seedName)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand getSeedID = new SqlCommand("SELECT seed_id FROM SEEDS WHERE seed_name = @seedName", con);
            getSeedID.Parameters.Add(new SqlParameter("seedName", seedName));
            int seedId = (int)getSeedID.ExecuteScalar();
            con.Close();

            return seedId;
        }
        public void sendDataToDatabase(string seedName, int timesPlanted = 0, int timesSprouted = 0, float germinationRate = 0)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE SEEDS SET seed_times_planted = @timesPlanted, seed_times_sprouted=@timesSprouted, seed_germination_rate = @germinationRate WHERE seed_name = @seedName", con);
                command.Parameters.Add(new SqlParameter("seedName", seedName));
                command.Parameters.Add(new SqlParameter("timesPlanted", timesPlanted));
                command.Parameters.Add(new SqlParameter("timesSprouted", timesSprouted));
                command.Parameters.Add(new SqlParameter("germinationRate", Math.Round(germinationRate, 2)));
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int getTimesPlantedFromPlantDatabase(string seedName, int? last)
        {
            int timesPlanted = 0;
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT SUM(seeds_planted) FROM PLANT WHERE seed_name = @seedName AND plant_id > @last", con);
                    timesPlanted = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return timesPlanted;
        }
        public int getTimesSproutedFromPlantDatabase(string seedName, int? last)
        {
            int timesSprouted = 0;
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT SUM(seeds_sprouted) FROM PLANT WHERE seed_name = @seedName AND plant_id > @last", con);
                    timesSprouted = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return timesSprouted;
        }

        public void updateGerminationRate(string seedName)
        {
            int? last = getLastGerminationRateUpdate();
            int timesPlanted = getTimesPlantedFromDatabase(seedName) + getTimesPlantedFromPlantDatabase(seedName,last);
            int timesSprouted = getTimesSproutedFromDatabase(seedName) + getTimesSproutedFromPlantDatabase(seedName,last);
            double germinationRate = getGerminationRate(timesPlanted, timesSprouted);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE SEEDS SET seed_times_planted = @timesPlanted, " +
                    "seed_times_sprouted = timesSprouted, seed_germination_rate = germinationRate WHERE seed_name = seedName", con);
                int a = command.ExecuteNonQuery();
                if(a>1)
                {
                    MessageBox.Show("Updated Succesfully");
                    updateLastGerminationRate(last + 1);
                }

                
                
            }
        }
        public int? getLastGerminationRateUpdate()
        {
            int? last;
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT LAST FROM LAST_GERMINATION_UPDATE", con);
                last = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return last;
        }
        public void updateLastGerminationRate(int? last)
        {
            using(SqlConnection con = new SqlConnection(connectionString)) {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LAST_GERMINATION_UPDATE SET LAST = @LAST", con);
                cmd.Parameters.Add(new SqlParameter("LAST",last));
                cmd.ExecuteNonQuery();
            }
        }
    }
}
