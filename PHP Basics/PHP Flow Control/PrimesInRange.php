<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Find Primes in Range</title>
</head>
<body>
<form method="post">
    <label for="start">Start:</label>
    <input type="text" name="start" id="start"/>
    <label for="end">End:</label>
    <input type="text" name="end" id="end"/>
    <input type="submit"/>
</form>
<?php
if ($_POST) {
    $start = intval($_POST["start"]);
    $end = intval($_POST["end"]);
    if (isset($start) && isset($end)) {
        if ($start < $end) {
            $result = array();
            for ($number = $start; $number <= $end; $number++) {
                $result[] = isPrime($number) ? "<strong>$number</strong>" : $number;
            }

            echo implode(", ", $result);
        } else {
            echo "The start number must be less than the end number.";
        }
    } else {
        echo "The start and end number are required.";
    }
}

function isPrime($number)
{
    // This function is optimized really well:
    if ($number <= 1) {
        // First, all numbers below 1 cannot be primes,
        return false;
    } elseif ($number == 2) {
        return true;
    } else if ($number % 2 == 0) {
        // Second, the number 2 is prime, and all other even numbers are not primes - this shortcut saves about half of the function's work
        return false;
    } else {
        // Third, since we ruled out 2, we can start the checks from 3 and omit all even numbers
        // What's more, we only need to check the numbers up to the square root of the number we're looking for
        // (actually to the next highest number), which optimizes the algorithm even more
        for ($i = 3; $i <= ceil(sqrt($number)); $i += 2) {
            if ($number % $i == 0) {
                return false;
            }
        }

        return true;
    }
}
?>
</body>
</html>