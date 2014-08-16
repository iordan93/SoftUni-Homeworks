<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Most Frequent Tag</title>
</head>
<body>
<form method="post">
    <label for="tags">Enter tags:</label><br/>
    <input type="text" name="tags" id="tags"/>
    <input type="submit" name="submit"><br/><br/>
<?php
if ($_POST && isset($_POST["submit"])) {
    $tags = explode(", ", $_POST["tags"]);

    // There are shorter ways to do this, but I prefer doing it manually
    $tagCounts = array();
    foreach ($tags as $tag) {
        if (!isset($tagCounts[$tag])) {
            $tagCounts[$tag] = 1;
        } else {
            $tagCounts[$tag]++;
        }
    }

    arsort($tagCounts);
    echo "<div id=\"result\">";
    foreach ($tagCounts as $key => $value) {
        // A little more beautiful representation -> "1 time" (not "1 times")
        echo $key . " : " . $value . " time" . ($value == 1 ? "" : "s") . "<br />";
    }

    // array_keys() returns all keys from the array, and the first one is the one with
    // the highest count in our case
    // Source: http://stackoverflow.com/questions/1028668/get-first-key-in-a-possibly-associative-array
    echo "Most frequent tag is: " . array_keys($tagCounts)[0];
    echo "</div>";
}
?>
</form>
</body>
</html>
