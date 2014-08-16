<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Print Tags</title>
</head>
<body>
<form method="post">
    <label for="tags">Enter tags:</label><br/>
    <input type="text" name="tags" id="tags"/>
    <input type="submit" name="submit"><br/><br/>
    <?php
    if ($_POST && isset($_POST["submit"])) {
        $tags = explode(", ", $_POST["tags"]);
        echo "<div id=\"result\">";
        foreach ($tags as $key => $value) {
            echo $key . " : " . $value . "<br />";
        }

        echo "</div>";
    }
    ?>
</form>
</body>
</html>
