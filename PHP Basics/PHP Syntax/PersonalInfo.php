<?php
$firstNames = array("Mister", "Pesho");
$lastNames = array("DakMan", "Peshev");
$ages = [21, 55];
$fullNames = [];
for ($i = 0; $i < count($firstNames); $i++) {
    $fullNames[$i] = $firstNames[$i] . " " . $lastNames[$i];

    echo "My name is $fullNames[$i] and I am $ages[$i] years old.<br />";
}
