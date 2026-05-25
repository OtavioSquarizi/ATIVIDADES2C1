-- Exercícios utilizando funções de data. Utilize o banco de dados Empresa que já está criado nos computadores
 Alunos: Otávio Tarallo Squarizi e Pietro Barros dos Santos. 
/* 01) Mostre os funcionarios que nasceram no dia 19*/

 select nome, DataNasc from funcionarios
 where day (DataNasc) = 19

/* 02) Mostre o nome dos funcionários nascidos 
em Julho*/

select nome, DataNasc from funcionarios
where month (DataNasc) = 7

/* 03) Mostre todos os pedidos entregues em 1998*/

select NumPed, DataEntrega from pedidos
where year (DataEntrega) = 1998

/* 04) Exiba o nome e a idade de todos os funcionários */

select nome,DATEDIFF(YEAR, DataNasc, GETDATE()) as idade from Funcionarios

/* 05) Exiba o número do pedido, a data do pedido, a data de entrega e 
a diferença de dias entre o pedido e a entrega*/

select NumPed, DataPed, DataEntrega, DATEDIFF(day, DataPed, DataEntrega) as 'Diferença de Dias' from Pedidos;

/* 06) Exiba os pedidos com 10 dias a mais para a data de entrega */

select DATEADD(day, 10, DataEntrega) as '10 dias a mais' from Pedidos;

/* 07) Exiba todos os nomes dos funcionários e o nome do mês que eles nasceram*/

select nome, DATENAME (MONTH, DataNasc) as 'Nome do mês' from Funcionarios;

/* 08) Exiba quantos dias já se passou do seu nascimento */

select DATEDIFF(day, '2009-01-01', getdate()) as 'Dias vivdos';
