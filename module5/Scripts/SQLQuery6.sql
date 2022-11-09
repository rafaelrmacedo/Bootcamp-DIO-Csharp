ALTER TABLE Produtos
ADD CONSTRAINT CHK_ColunaGenero CHECK (Genero = 'U' OR Genero = 'M' OR Genero = 'F')

INSERT INTO Produtos (Nome, Preco, Tamanho, Genero, DataCadastro)
VALUES ('Montain Bike Socks 2, M', 10, 'G', 'U', GETDATE())

ALTER TABLE Produtos
ADD DEFAULT GETDATE() FOR DataCadastro

INSERT INTO Produtos (Nome, Preco, Tamanho, Genero)
VALUES ('Montain Bike Socks 3, M', 10, 'G', 'U')

SELECT * FROM Produtos

-- Procedures

CREATE PROCEDURE InserirProduto
@Nome varchar(255),
@Cor varchar(50), 
@Preco decimal,
@Tamanho varchar(5),
@Genero char(1)

AS 

INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero)
VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero)

EXEC InserirProduto 'Full Finger Gloves', 'Vermelho', 15, 'G', 'U'