function variablesTypes(value) {
    console.log("My name: %s //type is %s \nMy age: %s //type is %s \nI am male: %s //type is %s \nMy favourite foods are: %s //type is %s",
    value[0], typeof (value[0]),
    value[1], typeof (value[1]),
    value[2], typeof (value[2]),
    value[3].toString(), typeof (value[3]));
}

variablesTypes(["Pesho", 22, true, ["fries", "banana", "cake"]]);

