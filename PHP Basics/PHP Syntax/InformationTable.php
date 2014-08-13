<?php
$names = array("Gosho", "Pesho");
$phoneNumbers = array("0882-321-423", "0884-888-888");
$ages = array(24, 67);
$addresses = array("Hadji Dimitar", "Suhata Reka");

function displayTable($name, $phoneNumber, $age, $address)
{
    echo "<table><tbody>";
    displayRow("Name", $name);
    displayRow("Phone number", $phoneNumber);
    displayRow("Age", $age);
    displayRow("Address", $address);
    echo "</tbody></table>";
}

function displayRow($key, $value)
{
    echo "<tr><td>" . $key . "</td><td>" . $value . "</td></tr>";
}

?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Information Table</title>
    <style type="text/css">
        table {
            border-collapse: collapse;
        }

        table tr td {
            border: 1px solid black;
            padding: 5px;
        }

        td:first-child {
            background-color: orange;
            font-weight: bold;
            width: 110px;
        }

        td:last-child {
            text-align: right;
            width: 100px;
        }
    </style>
</head>
<body>
<?php displayTable($names[0], $phoneNumbers[0], $ages[0], $addresses[0]) ?> <br/>
<?php displayTable($names[1], $phoneNumbers[1], $ages[1], $addresses[1]) ?>
</body>
</html>
