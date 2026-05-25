<!--
Data: 27/03/2026
Autor: Otávio Tarallo Squarizi e Pietro Barros dos Santos
Objetivo:

Exercício 10 - Ano Bissexto
Leia um ano e informe se ele é bissexto.
Um ano é bissexto se:
- É múltiplo de 400
ou
- É múltiplo de 4 e não é múltiplo de 100
-->

<?php

$ano = $_POST["ano"];

if ($ano % 400 == 0) {
  $resultado = "bissexto";
} else if ($ano % 4 == 0 && $ano % 100 != 0) {
  $resultado = "bissexto";
} else {
  $resultado = "não bissexto";
}

?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="UTF-8">
  <title>Resultado - Exercício 10</title>
</head>
<body>

  <h1>Resultado - Ano Bissexto</h1>

  <p>Ano digitado: <?php echo $ano; ?></p>
  <p><strong>O ano <?php echo $ano; ?> é <?php echo $resultado; ?>.</strong></p>

  <br>

</body>
</html>
