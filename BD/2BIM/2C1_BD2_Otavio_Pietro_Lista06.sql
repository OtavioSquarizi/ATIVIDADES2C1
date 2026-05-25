/* Utilize o banco de dados Empresa:*/

/* 1. Exiba o maior e o menor salário dos funcionários do Reino Unido.*/

	select 
	max(Salario) as Maior_Salario,
	min(Salario) as Menor_Salario
	from Funcionarios
	where pais = 'Reino Unido';

/* 2. Mostre a soma dos salários dos funcionários dos EUA.*/

	select sum(Salario) as Soma_Salarios
	from Funcionarios;

/* 3. Exiba a média dos Fretes dos Pedidos de 1996.*/

	select avg(Frete) as Media_Fretes
	from Pedidos
	where year(DataEntrega) = 1996;

/* 4. Apresente a quantidade de clientes do México. */

	select count(*) as Soma_Clientes
	from Clientes
	where pais = 'México';

/* 5. Exiba a menor data de nascimento dos funcionários. */
	
	select min(DataNasc) as Menor_Data
	from FUncionarios;

/* 6. Exiba a maior data de nascimento dos funcionários. */

	select max(DataNasc) as Maior_Data
	from FUncionarios;

/* 7. Mostre a quantidade de clientes da Espanha */
 
 	select count(*) as Soma_Clientes
	from Clientes
	where pais = 'Espanha';

/* 8. Exiba o nome, o sobrenome, o cargo e o salário dos 3 funcionários que possuem o maior salário*/

	select top 1 nome, sobrenome, cargo, salario from Funcionarios
	order by salario desc 

/* 9. Exiba o nome e o sobrenome do funcionário mais velho. */

	select top 1 nome, sobrenome from Funcionarios
	order by DataNasc desc

/* 10. Mostre todos os dados dos 6 últimos pedidos do ano de 1996. */

	select top 6 * from pedidos
    where DataPed between '1996-01-01' and '1996-12-31'
    order by DataPed desc 
