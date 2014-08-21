<?php
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");

function uniord($c)
{
    $h = ord($c{0});
    if ($h <= 0x7F) {
        return $h;
    } else if ($h < 0xC2) {
        return false;
    } else if ($h <= 0xDF) {
        return ($h & 0x1F) << 6 | (ord($c{1}) & 0x3F);
    } else if ($h <= 0xEF) {
        return ($h & 0x0F) << 12 | (ord($c{1}) & 0x3F) << 6
        | (ord($c{2}) & 0x3F);
    } else if ($h <= 0xF4) {
        return ($h & 0x0F) << 18 | (ord($c{1}) & 0x3F) << 12
        | (ord($c{2}) & 0x3F) << 6
        | (ord($c{3}) & 0x3F);
    } else {
        return false;
    }
}
?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Text Colorer</title>
    <style type="text/css">
        .error {
            color: #ff0000;
            font-weight: bold;
        }

        .red {
            color: #ff0000;
        }

        .blue {
            color: #0000ff;
        }
    </style>
</head>
<body>
<form method="post">
    <textarea name="text"></textarea><br/>
    <input type="submit" value="Color text"/>
</form>
<br/>
<?php
if (isset($_POST["text"])) {
    if (!empty($_POST["text"])) {
        for ($i = 0; $i < mb_strlen($_POST["text"]); $i++) {
            $character = mb_substr($_POST["text"], $i, 1);
            $order = uniord($character);
            echo "<span class=\"" . ($order % 2 == 0 ? "red" : "blue") . "\">$character</span> ";
        }
    } else {
        echo "<div class=\"error\">No text provided.</div>";
    }
}
?>
</body>
</html>
