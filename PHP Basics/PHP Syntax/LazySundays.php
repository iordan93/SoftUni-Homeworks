<?php
// Source: http://stackoverflow.com/questions/4293174/grab-all-wednesdays-in-a-given-month-in-php
function getSundays($y, $m)
{
    return new DatePeriod(
        new DateTime("first sunday of $y-$m"),
        DateInterval::createFromDateString('next sunday'),
        new DateTime("last day of $y-$m")
    );
}

foreach (getSundays(date("Y"), date("M")) as $sunday) {
    echo $sunday->format("d F Y") . "<br />";
}