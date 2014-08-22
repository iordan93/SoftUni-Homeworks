<?php
require "Seminar.php";
session_start();
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");
?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>SoftUni Seminar Generator</title>
    <link href="styles.css" rel="stylesheet"/>
    <script src="scripts.js"></script>
</head>
<body>
<form method="post">
    <textarea name="text" rows="10" cols="80"></textarea><br/>
    <label for="field">Sort by:</label>
    <select name="field" id="field">
        <option value="name">Name</option>
        <option value="date">Date</option>
    </select>
    <label for="order">Order:</label>
    <select name="order" id="order">
        <option value="ascending">Ascending</option>
        <option value="descending">Descending</option>
    </select>
    <input type="submit" value="Submit"/>
</form>
<br/>
<?php
if ($_POST) {
    if (isset($_POST["text"])) {
        if (!empty($_POST["text"])) {
            $seminarsInfo = array();

            // I assume that the input will always be valid and in the format provided
            // (for example, no dash in the seminar title)
            preg_match_all('/(.*?)\-(.*?)\-(\d{2}-\d{2}-\d{4}\s+\d{2}:\d{2})\s+(.*)/', $_POST["text"], $seminarsInfo, PREG_SET_ORDER);
            $seminars = array();
            foreach ($seminarsInfo as $seminarInfo) {
                $seminars[] = new Seminar($seminarInfo[1], $seminarInfo[2], $seminarInfo[3], $seminarInfo[4]);
            }

            $field = $_POST["field"];
            $order = $_POST["order"];
            if (Seminar::validateOrderByParameters($field, $order)) {
                uasort($seminars, Seminar::orderBy($field, $order));
            }

            echo displaySeminarsTable($seminars);
        } else {
            echo "<div class=\"error\">Invalid field or order.</div>";
            exit;
        }
    } else {
        echo "<div class=\"error\">No text provided.</div>";
        exit;
    }
}

function displaySeminarsTable($seminars)
{
    $result = "<table border=\"1\" class=\"seminars-table\">";
    $result .= "<thead>
                    <tr>
                        <th>Seminar name</th>
                        <th>Date</th>
                        <th>Participate</th>
                    </tr>
                </thead>
                <tbody>";

    foreach ($seminars as $seminar) {
        $details = "<span class=\"title\">Lecturer:</span> {$seminar->lecturer}<br/>
        <span class=\"title\">Details:</span> {$seminar->details}";
        $result .= "<tr>
                <td><a href=\"#\" class=\"master-tooltip\" data-tooltip=\"" . htmlentities($details) .
            "\">{$seminar->name}</a></td>
                <td>{$seminar->date->format("d-m-Y H:i")}</td>
                <td><a class=\"signup-button\" href=\"#\">SIGN UP</a></td>
              </tr>";
    }

    $result .= "</tbody></table>";
    return $result;
}

?>
</body>
</html>