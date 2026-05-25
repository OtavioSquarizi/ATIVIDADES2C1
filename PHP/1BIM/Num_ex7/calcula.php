<!--
Data: 27/03/2026
Autor: Otávio Tarallo Squarizi e Pietro Barros dos Santos
Objetivo:

## Exercício 7 - Separar Positivos e Negativos
Leia 8 números inteiros e separe em dois vetores:  
- Um vetor com números positivos  
- Um vetor com números negativos s
-->

<?php

$n1 = $_POST["n1"];
$n2 = $_POST["n2"];
$n3 = $_POST["n3"];
$n4 = $_POST["n4"];
$n5 = $_POST["n5"];
$n6 = $_POST["n6"];
$n7 = $_POST["n7"];
$n8 = $_POST["n8"];

?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="UTF-8">
  <title>Resultado - Exercício 7</title>
</head>
<body>

  <h1>Resultado - Positivos e Negativos</h1>

  <h2>Números Positivos:</h2>

  <?php
    if ($n1 > 0) { echo "<p>" . $n1 . "</p>"; }

    if ($n2 > 0) { echo "<p>" . $n2 . "</p>"; }

    if ($n3 > 0) { echo "<p>" . $n3 . "</p>"; }

    if ($n4 > 0) { echo "<p>" . $n4 . "</p>"; }

    if ($n5 > 0) { echo "<p>" . $n5 . "</p>"; }

    if ($n6 > 0) { echo "<p>" . $n6 . "</p>"; }

    if ($n7 > 0) { echo "<p>" . $n7 . "</p>"; }

    if ($n8 > 0) { echo "<p>" . $n8 . "</p>"; }
  ?>

  <h2>Números Negativos:</h2>
  <?php
    if ($n1 < 0) { echo "<p>" . $n1 . "</p>"; }
    if ($n2 < 0) { echo "<p>" . $n2 . "</p>"; }
    if ($n3 < 0) { echo "<p>" . $n3 . "</p>"; }
    if ($n4 < 0) { echo "<p>" . $n4 . "</p>"; }
    if ($n5 < 0) { echo "<p>" . $n5 . "</p>"; }
    if ($n6 < 0) { echo "<p>" . $n6 . "</p>"; }
    if ($n7 < 0) { echo "<p>" . $n7 . "</p>"; }
    if ($n8 < 0) { echo "<p>" . $n8 . "</p>"; }
  ?>

  <br>

</body>
</html>
