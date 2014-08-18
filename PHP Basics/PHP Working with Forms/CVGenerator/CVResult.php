<?php
session_start();
require "constants.php";
if (!$_SESSION) {
    die;
}
?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>CV Generator - Result</title>
    <script src="scripts.js"></script>
    <link href="styles.css" rel="stylesheet"/>
</head>
<body>
<h1>CV</h1>
<table border="1">
    <thead>
    <tr>
        <th colspan="2">Personal Information</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>First Name</td>
        <td><?php echo $_SESSION["firstName"] ?></td>
    </tr>
    <tr>
        <td>Last Name</td>
        <td><?php echo $_SESSION["lastName"] ?></td>
    </tr>
    <tr>
        <td>Email</td>
        <td><?php echo $_SESSION["email"] ?></td>
    </tr>
    <tr>
        <td>Phone Number</td>
        <td><?php echo $_SESSION["phoneNumber"] ?></td>
    </tr>
    <tr>
        <td>Gender</td>
        <td><?php echo ucfirst($_SESSION["sex"]) ?></td>
    </tr>
    <tr>
        <td>Birth Date</td>
        <td>
            <?php
            $date = date_create_from_format("d/m/Y", $_SESSION["birthDate"]);
            echo date_format($date, "Y-m-d");
            ?>
        </td>
    </tr>
    <tr>
        <td>Nationality</td>
        <td><?php echo $nationalities[$_SESSION["nationality"]] ?></td>
    </tr>
    </tbody>
</table>
<br/>
<table border="1">
    <thead>
    <tr>
        <th colspan="2">Last Work Position</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>Company Name</td>
        <td><?php echo $_SESSION["companyName"] ?></td>
    </tr>
    <tr>
        <td>From</td>
        <td>
            <?php
            $date = date_create_from_format("d/m/Y", $_SESSION["from"]);
            echo date_format($date, "Y-m-d");
            ?>
        </td>
    </tr>
    <tr>
        <td>To</td>
        <td>
            <?php
            $date = date_create_from_format("d/m/Y", $_SESSION["to"]);
            echo date_format($date, "Y-m-d");
            ?>
        </td>
    </tr>
    </tbody>
</table>
<br/>
<table border="1">
    <thead>
    <tr>
        <th colspan="2">Computer Skills</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>Programming Languages</td>
        <td>
            <table border="1">
                <thead>
                <tr>
                    <th>Language</th>
                    <th>Skill Level</th>
                </tr>
                </thead>
                <tbody>
                    <?php
                    foreach($_SESSION["programmingLanguages"] as $id => $language){
                        echo "<tr><td>$language</td><td>{$_SESSION["programmingLanguageLevels"][$id]}</td></tr>";
                    }
                    ?>
                </tbody>
            </table>
        </td>
    </tr>
    </tbody>
</table>
<br/>
<table border="1">
    <thead>
    <tr>
        <th colspan="2">Other Skills</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>Languages</td>
        <td>
            <table border="1">
                <thead>
                <tr>
                    <th>Language</th>
                    <th>Comprehension</th>
                    <th>Reading</th>
                    <th>Writing</th>
                </tr>
                </thead>
                <tbody>
                <?php
                foreach($_SESSION["languages"] as $id => $language){
                    echo "<tr><td>$language</td><td>{$_SESSION["comprehension"][$id]}</td><td>{$_SESSION["reading"][$id]}</td><td>{$_SESSION["writing"][$id]}</td></tr>";
                }
                ?>
                </tbody>
            </table>
        </td>
    </tr>
    <tr>
        <td>Driver's license</td>
        <td><?php echo implode(", ", $_SESSION["licenses"]) ?></td>
    </tr>
    </tbody>
</table>
</body>
</html>