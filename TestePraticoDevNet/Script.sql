SELECT * FROM __MigrationHistory

SELECT * FROM Fornecedor;

SELECT * FROM Produto;

INSERT INTO Fornecedor (ID, Nome, Cnpj,Endereco, Ativo)  VALUES (NEWID(), 'Empresa 01', '18708847000190', 'Rua Um, Jardim Planalto - Botucatu/SP', 1);

INSERT INTO Produto  (ID, Nome, Quantidade, Fornecedores_ID) VALUES (NEWID(), 'Produto 01', 10, 'F2C5E73D-88E2-4475-9B61-24FB64EEFEAC');

--Senha: admin
INSERT INTO Usuario (ID, Nome, Login, Senha, Ativo) VALUES (NEWID(), 'Administrador do Sistema', 'admin', 'D033E22AE348AEB5660FC2140AEC35850C4DA997', 1);