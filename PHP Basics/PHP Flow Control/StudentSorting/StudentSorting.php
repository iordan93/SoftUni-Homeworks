<?php require "functions.php"; ?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Student Sorting</title>
    <script src="scripts.js"></script>
    <link href="styles.css" rel="stylesheet"/>
</head>
<body>
<form method="post">
    <table id="exams-table">
        <thead>
        <tr>
            <th>First name:</th>
            <th>Last name:</th>
            <th>Email:</th>
            <th>Exam score:</th>
        </tr>
        </thead>
        <tbody></tbody>
    </table>
    <button id="add-item">+</button>
    <label for="sortField">Sort by:</label>
    <select name="sortField" id="sortField">
        <option value="firstName">First name</option>
        <option value="lastName">Last name</option>
        <option value="email">Email</option>
        <option value="examScore">Exam score</option>
    </select>
    <label for="order">Order:</label>
    <select name="order" id="order">
        <option value="ascending">Ascending</option>
        <option value="descending">Descending</option>
    </select>
    <input type="submit" value="SUBMIT"/>
</form>
<?php
if ($_POST) :
    if (!isset($_POST["firstNames"]) || !isset($_POST["lastNames"]) || !isset($_POST["emails"]) || !isset($_POST["examScores"])) {
        echo "<div class=\"error\">Not all fields have been filled in.</div>";
        exit;
    }

    $firstNames = array_filter($_POST["firstNames"], function ($element) {
        return !isNullOrWhiteSpace($element);
    });
    $lastNames = array_filter($_POST["lastNames"], function ($element) {
        return !isNullOrWhiteSpace($element);
    });
    $emails = array_filter($_POST["emails"], function ($element) {
        return !isNullOrWhiteSpace($element);
    });
    $examScores = array_filter($_POST["examScores"], function ($element) {
        return !isNullOrWhiteSpace($element);
    });

    // Basic validation - ensure all non-empty fields have the same number of indexes
    if (count($firstNames) != count($lastNames) || count($lastNames) != count($emails) || count($emails) != count($examScores)) {
        echo "<div class=\"error\">There are some fields missing.</div>";
        exit;
    }

    // Another validation - ensure that the field to sort and the order are valid
    $allowedFields = array("firstName", "lastName", "email", "examScore");
    $allowedOrders = array("ascending", "descending");
    if (!in_array($_POST["sortField"], $allowedFields) || !in_array($_POST["order"], $allowedOrders)) {
        echo "<div class=\"error\">The field to sort or the sorting order is invalid.</div>";
        exit;
    }

    $students = array();
    for ($i = 0; $i < count($firstNames); $i++) {
        $students[] = array("firstName" => $firstNames[$i], "lastName" => $lastNames[$i], "email" => $emails[$i], "examScore" => $examScores[$i]);
    }

    $order = $_POST["order"] == "ascending" ? SORT_ASC : SORT_DESC;
    usort($students, makeComparer([$_POST["sortField"], $order, null]));
    ?>
    <table id="result-table" border="1">
        <thead>
        <tr>
            <th>First name</th>
            <th>Last name</th>
            <th>Email</th>
            <th>Exam score</th>
        </tr>
        </thead>
        <tbody>
        <?php foreach($students as $student): ?>
            <tr>
                <td><?= $student["firstName"] ?></td>
                <td><?= $student["lastName"] ?></td>
                <td><?= $student["email"] ?></td>
                <td><?= $student["examScore"] ?></td>
            </tr>
        <?php endforeach; ?>
        <tr>
            <td colspan="3"><strong>Average score:</strong></td>
            <td><strong><?= round(array_sum($examScores) / count($examScores), 0) ?></strong></td>
        </tr>
        </tbody>
    </table>
<?php endif; ?>
</body>
</html>