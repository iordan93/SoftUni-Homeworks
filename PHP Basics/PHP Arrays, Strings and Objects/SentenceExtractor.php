<?php
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");
?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Sentence Extractor</title>
    <style type="text/css">
        .error {
            color: #ff0000;
            font-weight: bold;
        }
    </style>
</head>
<body>
<form method="post">
    <label for="text">Text: </label>
    <textarea name="text" id="text" rows="4" cols="50"></textarea><br/>
    <label for="word">Word: </label>
    <input type="text" name="word" id="word"/><br/>
    <input type="submit" value="Extract sentences"/>
</form>
<br/>
<?php
if (isset($_POST["text"]) && isset($_POST["word"])) {
    if (!empty($_POST["text"]) && !empty($_POST["word"])) {
        $sentences = preg_split('/\s*(?<=[.?!])\s+/', $_POST["text"], 0, PREG_SPLIT_NO_EMPTY);
        foreach ($sentences as $sentence) {
            $sentence = trim($sentence);
            if (preg_match('/(\s+)' . $_POST["word"] . '\1(.*)[.?!]/', $sentence)) {
                echo $sentence . "<br />";
            }
        }
    } else {
        echo "<div class=\"error\">Not all fields have been filled in.</div>";
    }
}
?>
</body>
</html>