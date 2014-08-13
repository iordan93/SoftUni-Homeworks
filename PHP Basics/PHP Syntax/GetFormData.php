<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8"/>
    <title>Form Data</title>
</head>
<body>
<form action="#" method="POST">
    <input type="text" name="name" id="name" placeholder="Name"/><br/>
    <input type="text" name="age" id="age" placeholder="Age"/><br/>
    <input type="radio" name="sex" value="male">Male<br/>
    <input type="radio" name="sex" value="female">Female<br/>
    <input type="submit" value="Изпращане"/><br />
    <?php
    // Basic validation - ensure all fields have been filled
    // Nothing more is required in this problem :)
    if ($_POST && isset($_POST["name"]) && isset($_POST["age"]) && isset($_POST["sex"])) {
        echo "My name is " . $_POST["name"] . ". I am " . $_POST["age"] . " years old. I am " . $_POST["sex"] . ".";
    }
    ?>
</form>
</body>
</html>