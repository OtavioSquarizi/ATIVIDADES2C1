<!--
Data: 27/03/2026
Autor: Otávio Tarallo Squarizi e Pietro Barros dos Santos
Objetivo:

## Exercício 9 - Média Aritmética com Função
Crie uma função:

function media($v)

Que receba uma lista de números reais e retorne a média aritmética.
-->
<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="UTF-8">
  <title>Exercício 9 - Média Aritmética</title>
</head>
<body>

  <h1>Média Aritmética</h1>
  <p>Digite 5 números reais:</p>

  <form action="calcula.php" method="post">

    <label>Número 1:</label>
    <input type="number" name="n1" step="any" required>
    <br><br>

    <label>Número 2:</label>
    <input type="number" name="n2" step="any" required>
    <br><br>

    <label>Número 3:</label>
    <input type="number" name="n3" step="any" required>
    <br><br>

    <label>Número 4:</label>
    <input type="number" name="n4" step="any" required>
    <br><br>

    <label>Número 5:</label>
    <input type="number" name="n5" step="any" required>
    <br><br>

    <input type="submit" value="Calcular Média">

  </form>

</body>
</html>
