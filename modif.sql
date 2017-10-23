
IF NOT EXISTS (SELECT 1 FROM SYSOBJECTS WHERE ID = OBJECT_ID('Games') AND TYPE = 'U')
BEGIN
	CREATE TABLE Games
	(
		Id Int Not Null,
		Title Varchar(50) Not Null,
		Type Varchar(20),
		RowVersion rowversion,
		PRIMARY KEY (Id)
	)

	--GRANT REFERENCES,SELECT,UPDATE,INSERT ,DELETE ON Games TO xxx	
END
GO