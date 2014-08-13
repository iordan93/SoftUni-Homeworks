<?php
date_default_timezone_set("Europe/Sofia");
$year = intval(date("Y"));
$newYear = mktime(0, 0, 0, 12, 31, intval(date("Y")) + 1);
$daysInYear = intval(date("z", mktime(0, 0, 0, 12, 31, $year))) + 1;
$left = array();
$left["days"] = $daysInYear - date("z") - 1;
$left["hours"] = (($left["days"] + 1) * 24) - date("G");
$left["minutes"] = (($left["hours"] + 1) * 60) - date("i") - 1;
$left["seconds"] = (($left["minutes"] + 1) * 60) - date("s");
echo "Hours until new year : " . $left["hours"]."<br />";
echo "Minutes until new year : " . $left["minutes"]."<br />";
echo "Seconds until new year : " . $left["seconds"]."<br />";
echo "Days:Hours:Minutes:Seconds " . $left["days"] . ":" . $left["hours"] % 24 . ":" . $left["minutes"] % 60 . ":" . $left["seconds"] % 60;