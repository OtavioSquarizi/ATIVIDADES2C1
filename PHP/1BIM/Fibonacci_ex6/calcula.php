<!--
Data: 06/03/2026
Autor: Otávio Tarallo Squarizi e Pietro Barros dos Santos 
Objetivo:

## Exercício 6 - Série de Fibonacci
Leia um número n e mostre os n primeiros termos da sequência de Fibonacci.

Exemplo:  
n = 12  
Resultado:  
0 1 1 2 3 5 8 13 21 34 55 89  
-->

<?php

$n = $_GET["n"];

$a = 0;
$b = 1;

?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
<meta charset="UTF-8">
<title>Resultado Fibonacci</title>
</head>

<body>

<h1>Resultado da Sequência</h1>

<p>

<?php

echo $a . " ";
echo $b . " ";

for($i = 2; $i < $n; $i++){

    $c = $a + $b;

    echo $c . " ";

    $a = $b;
    $b = $c;

}

?>

</p>

<a href="index.php">Voltar</a>

</body>
</html>
