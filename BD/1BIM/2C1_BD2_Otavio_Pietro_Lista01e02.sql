/*criação do banco de daods "locadora"*/

create database locadora;

use locadora;

/*criação das tabelas*/

create table tbclientes (
    codcli int primary key,
    nome varchar(50),
    endereco varchar(50),
    cidade varchar(50),
    sexo char(1),
    datanasc date,
    cnh varchar(25),
	datahabilitacao date
);

create table tbcarros (
    codcarro int primary key,
    marca varchar(30),
    modelo varchar(30),
    placa varchar(8),
    valordiaria decimal(10,2),
    fornecedor varchar(50)
);

create table tbaluguel (
    codaluguel int primary key,
    codcli int,
    codcarro int,
    dataret date,
    datadev date,
    valorpago decimal(10,2),
);

/*---------------------------------------------------1--------------------------------------------------*/

/*acrescentar o campo estado na tabela*/

alter table tbclientes
add estado char(2);

/*acrescentar o campo "categoria"*/

alter table tbcarros
add categoria varchar(30);

/*acrescentar o campo cor na tabela de carros*/

alter table tbcarros
add cor varchar(20);

/*remova o campo "datahabilitacao" da tabela de clientes*/

alter table tbclientes
drop column datahabilitacao;

/*remova o campo "fornecedor" da tabela de carros*/

alter table tbcarros
drop column fornecedor;

/*Renomeie o campo DataRet da tabela tbAluguel para DataRetirada*/

EXEC sp_rename 'tbaluguel.dataret', 'dataretirada', 'COLUMN';

/*Renomeie o campo DataDev da tabela tbAluguel para DataDevolucao*/

EXEC sp_rename 'tbaluguel.datadev', 'datadevolucao', 'COLUMN';

/*Renomeie o campo Nome da tabela tbClientes para NomeCliente*/

EXEC sp_rename 'tbclientes.nome', 'nomecliente', 'COLUMN';

/*---------------------------------------------------2--------------------------------------------------*/

/*inserir os seguintes clientes*/

insert into tbclientes (codcli, nomecliente, endereco, cidade, sexo, datanasc, cnh) values
(1,'José de Oliveira','Av. Jatobá','Jundiaí','M','1965-05-11','0009'),
(2,'Maria da Silva','Av. Presidente','Itatiba','F','1979-10-08', '0008'),
(3,'Antonio Carlos','R. Florença','Jundiaí','M','1980-09-20','0007'),
(4,'Luisa de Souza','Av. Jequitibá','Jundiaí','F','1975-10-10', '0005');

/*inserir os seguintes carros*/

insert into tbcarros (codcarro, marca, modelo, placa, valordiaria, categoria) values
(1,'Ford','Ka','AAA-0001', 180.00, 'Econômico'),
(2,'GM','Onix','AAA-0002', 180.00, 'Econômico'),
(3,'Honda','HRV','AAA-0003', 270.00, 'SUV'),
(4,'Jeep','Compass','AAA-0004', 310.00, 'SUV Média'),
(5,'VW','Jetta','AAA-0005', 270.00, 'Sedan'),
(6,'Fiat','Mobi','AAA-0006', 130.00, 'Compacto');

/*inserir os seguintes aluguéis*/

insert into tbaluguel (codaluguel, codcli, codcarro, dataretirada, datadevolucao, valorpago) values
(1,1,1, '02-08-2019', '07-08-2019', 900),
(2,2,3, '12-08-2019', '15-08-2019', 500),
(3,3,2, '02-08-2019', '07-08-2019', 900),
(4,4,5, '12-08-2019', '15-08-2019', 700);

/*atualizar o campo estado para SP de todos os clientes*/

update tbclientes
set estado = 'SP';

/*atualizar o campo Valor Diária para 350 de tbcarros*/

update tbcarros
set valordiaria = 350;

/*atualizar para 'Vinhedo' a cidade do cliente de código 2*/

update tbclientes
set cidade = 'Vinhedo'
where codcli = 2;

/*apagar o carro mobi (caso for para apagar toda a coluna)*/

delete from tbcarros
where codcarro = 6;

/*apagar o carro mobi (caso for para apagar apenas o carro)*/

insert into tbcarros (codcarro, marca, modelo, placa, valordiaria, categoria) values
(6,'Fiat','Mobi','AAA-0006', 130.00, 'Compacto');

update tbcarros
set modelo = null
where codcarro = 6;

/*apagar os aluguéis do cliente de código 3*/

update tbaluguel
set valorpago = 0
where codaluguel = 3;

/*apagar os aluguéis do carro de código 2*/

update tbcarros
set valordiaria = 0
where codcarro = 2;

/*atualizar o campo valor diária em 7%*/

update tbcarros
set valordiaria = valordiaria*1.07;

select * from tbcarros;






