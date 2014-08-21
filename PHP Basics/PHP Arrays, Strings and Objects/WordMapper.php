<?php
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");
?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Word Mapper</title>
    <style type="text/css">
        .error {
            color: #ff0000;
            font-weight: bold;
        }

        .words-table {
            background-color: #d3d3d3;
        }

        .words-table td {
            border: 1px solid black;
            background-color: #d3d3d3;
            padding: 4px;
            margin: 1px;
        }
    </style>
</head>
<body>
<form method="post">
    <textarea rows="3" cols="55" name="words"></textarea><br/>
    <input type="submit" value="Count words"/>
</form>
<br/>
<?php
if (isset($_POST["words"])) {
    if (!empty($_POST["words"])) {
        echo "<table class=\"words-table\">";
        $split = preg_split('/\W+/', $_POST["words"], 0, PREG_SPLIT_NO_EMPTY);
        $counts = array_count_values($split);
        foreach ($counts as $word => $count) {
            echo "<tr><td>$word</td><td>$count</td></tr>";
        }

        echo "</table>";
    } else {
        echo "<div class=\"error\">No words to count.</div>";
    }
}
?>
</body>
</html>
