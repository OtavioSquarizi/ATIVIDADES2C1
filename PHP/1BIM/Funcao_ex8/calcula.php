<!--
Data: 27/03/2026
Autor: Otávio Tarallo Squarizi e Pietro Barros dos Santos
Objetivo:

## Exercício 8 - Soma de 0 até N com Função
Crie uma função `soma(n)` que receba um número inteiro e retorne a soma de 0 até esse número.
-->

<?php

function soma($n) {
  $total = 0;
  for ($i = 0; $i <= $n; $i++) {
    $total = $total + $i;
  }
  return $total;
}

$n = $_POST["n"];
$resultado = soma($n);

?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="UTF-8">
  <title>Resultado - Exercício 8</title>
</head>
<body>

  <h1>Resultado - Soma de 0 até N</h1>

  <p>Número informado: <?php echo $n; ?></p>
  <p><strong>Soma de 0 até <?php echo $n; ?>: <?php echo $resultado; ?></strong></p>

  <br>

</body>
</html>
