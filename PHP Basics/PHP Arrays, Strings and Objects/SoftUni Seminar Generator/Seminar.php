<?php
class Seminar
{
    public $name;
    public $lecturer;
    public $date;
    public $details;

    public function __construct($name, $lecturer, $date, $details)
    {
        $this->name = $name;
        $this->lecturer = $lecturer;
        $this->date = DateTime::createFromFormat("d-m-Y H:i", $date);
        $this->details = $details;
    }

    public static function orderBy($property, $order)
    {
        if (static::validateOrderByParameters($property, $order)) {
            return function ($first, $second) use ($property, $order) {
                return ($order == "ascending" ^ $first->$property < $second->$property) ? 1 : -1;
            };
        }
    }

    public static function validateOrderByParameters($property, $order)
    {
        $allowedProperties = array("name", "lecturer", "date", "details");
        $allowedOrders = array("ascending", "descending");
        if (!in_array($property, $allowedProperties) || !in_array($order, $allowedOrders)) {
            return false;
        }

        return true;
    }
}