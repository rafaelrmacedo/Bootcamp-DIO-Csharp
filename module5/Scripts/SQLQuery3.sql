SELECT SUM(Preco) AS PrecoTotal FROM Produtos WHERE Tamanho = 'M'

SELECT SUM(Preco) AS PrecoTotalTamanhoM FROM Produtos WHERE Tamanho = 'G'

SELECT MAX(Preco) AS MaisCaro FROM Produtos

SELECT MIN(Preco) AS MaisBarato FROM Produtos

SELECT AVG(Preco) AS MediaPrecoTamanhoM FROM Produtos WHERE Tamanho = 'M'

SELECT AVG(Preco) AS MediaPreco FROM Produtos

-- Concatenação de colunas

SELECT 'Nome: ' + Nome + ', Cor: ' + Cor AS ProdutoCor FROM Produtos 