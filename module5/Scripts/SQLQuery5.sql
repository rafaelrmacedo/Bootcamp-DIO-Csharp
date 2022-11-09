SELECT Nome + ' ' + Sobrenome AS NomeCompleto FROM Clientes
SELECT * FROM Endereco 

SELECT 
	Clientes.Nome,
	Clientes.Sobrenome,
	Clientes.Email,
	Endereco.Rua,
	Endereco.Bairro,
	Endereco.Cidade
FROM Clientes 
INNER JOIN Endereco ON Clientes.Id = Endereco.IdCliente
