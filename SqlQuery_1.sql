/*CREATE TABLE imagetest(
	[imageid] int primary key not null,
	[Filename] nvarchar(100),
	[image] image
	)*/

/*ALTER TABLE imagetest
ALTER COLUMN imageid identity;*/

select image from imagetest where imageid = 1
