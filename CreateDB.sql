
CREATE TABLE dbo.Livros (
	ID int IDENTITY(1,1) NOT NULL,
	ISBN nvarchar(20),
	Titulo nvarchar(200),
	Autor nvarchar(200),
	DataPublicacao Datetime,
	Versao nvarchar(10),
	Genero nvarchar(100),
	PalavraChave nvarchar(100),
	Sinopse nvarchar(4000)
)

CREATE TABLE dbo.Revistas (
	ID int IDENTITY(1,1) NOT NULL,
	Nome nvarchar(200),
	Numero int,
	DataPublicacao Datetime,
	Genero nvarchar(100),
	PalavraChave nvarchar(100),
	Sinopse nvarchar(4000)
)
