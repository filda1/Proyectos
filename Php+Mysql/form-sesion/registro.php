<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <h3>Registro usuarios</h3>
    <form action="agregar_usuario.php" method="POST">
        <input type="text" name="nombre_usuario" placeholder="Ingresa usuario">
        <input type="text" name="contrasena" placeholder="Ingresa contraseña">
        <input type="text" name="contrasena2" placeholder="Nuevamente pass">
        <button type="submit">Guardar</button>
    </form>

    <h3>Login</h3>
    <form action="login.php" method="POST">
        <input type="text" name="nombre_usuario" placeholder="Ingresa usuario">
        <input type="text" name="contrasena" placeholder="Ingresa contraseña">
        <button type="submit">Guardar</button>
    </form>
    
</body>
</html>