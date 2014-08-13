<?php
function sumNumbers($firstNumber, $secondNumber)
{
    return "\$firstNumber + \$secondNumber = " . $firstNumber . " + " . $secondNumber . " = " . ($firstNumber + $secondNumber) . "<br />";
}

echo sumNumbers(2, 5);
echo sumNumbers(1.567808, 0.356);
echo sumNumbers(1234.5678, 333);