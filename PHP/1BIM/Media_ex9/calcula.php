<!--
Data: 27/03/2026
Autor: Otávio Tarallo Squarizi e Pietro Barros dos Santos
Objetivo:

## Exercício 9 - Média Aritmética com Função
Crie uma função:

function media($v)

Que receba uma lista de números reais e retorne a média aritmética.
-->

<?php

function media($n1, $n2, $n3, $n4, $n5) {
  $soma = $n1 + $n2 + $n3 + $n4 + $n5;
  $resultado = $soma / 5;
  return $resultado;
}

$n1 = (float) $_POST["n1"];
$n2 = (float) $_POST["n2"];
$n3 = (float) $_POST["n3"];
$n4 = (float) $_POST["n4"];
$n5 = (float) $_POST["n5"];

$resultado = media($n1, $n2, $n3, $n4, $n5);

?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="UTF-8">
  <title>Resultado - Exercício 9</title>
</head>
<body>

  <h1>Resultado - Média Aritmética</h1>

  <p>Número 1: <?php echo $n1; ?></p>
  <p>Número 2: <?php echo $n2; ?></p>
  <p>Número 3: <?php echo $n3; ?></p>
  <p>Número 4: <?php echo $n4; ?></p>
  <p>Número 5: <?php echo $n5; ?></p>

  <p><strong>Média: <?php echo $resultado; ?></strong></p>

  <br>

</body>
</html>
