SELECT * FROM Produtos

ALTER TABLE Produtos 
ADD DataCadastro DATETIME2

UPDATE Produtos SET DataCadastro = GETDATE() 
-- GETDATE pega a data atual e a coloca em todas as linhas dessa coluna

-- Formatando a data
SELECT Nome, Cor, Preco, FORMAT(DataCadastro, 'dd/MM/yyyy HH:mm') FROM Produtos

SELECT Tamanho, 
COUNT(*) AS Quantidade 
FROM Produtos 
WHERE Tamanho != '' -- Também podemos utilizar o operador <> indicando diferente, ou seja, <> === !=
GROUP BY Tamanho
ORDER BY Quantidade