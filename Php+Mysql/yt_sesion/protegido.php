<?php
session_start();

if( isset($_SESSION['admin']) ){
    echo 'Bienvenido! '.$_SESSION['admin'];
    echo '<br><a href="cerrar.php">Cerrar Sesión</a>';
}else{
    header('Location:index.php');
}

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <h1>Hola soy un html</h1>
</body>
</html>