<?php
$variables = ["hello", 15, 1.234, array(1, 2, 3), (object)[2, 34]];
foreach($variables as $k => $v) {
    if(is_numeric($v)){
        var_dump($v);
    }
    else{
        echo gettype($v) . "<br />";
    };
}