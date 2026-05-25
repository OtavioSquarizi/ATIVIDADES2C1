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

<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="UTF-8">
  <title>Exercício 10 - Ano Bissexto</title>
</head>
<body>

  <h1>Verificar Ano Bissexto</h1>

  <form action="calcula.php" method="post">

    <label>Digite um ano:</label>
    <input type="number" name="ano" required>
    <br><br>

    <input type="submit" value="Verificar">

  </form>

</body>
</html>
