function findYoungestPerson(persons) {
    persons.sort(function (first, second) {
        return first.age - second.age;
    });

    console.log('The youngest person is %s %s', persons[0].firstname, persons[0].lastname);
}

findYoungestPerson([
    { firstname: 'George', lastname: 'Kolev', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Baba', lastname: 'Ginka', age: 40 }
]);