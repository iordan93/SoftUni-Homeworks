function soothsayer(years, job, city, car) {
    var soothsayerResult = getSoothsayerResult(years, job, city, car);
    return "You will work " + soothsayerResult[0] + " years on " + soothsayerResult[1] + ".\r\n" +
        "You will live in " + soothsayerResult[2] + " and drive " + soothsayerResult[3];
}

function getSoothsayerResult(years, job, city, car) {
    return [years[Math.floor(Math.random() * years.length)],
        job[Math.floor(Math.random() * job.length)],
        city[Math.floor(Math.random() * city.length)],
        car[Math.floor(Math.random() * car.length)],
    ]
}

console.log(soothsayer(
    [3, 5, 2, 7, 9],
    ["Java", "Python", "C#", "JavaScript", "Ruby"],
    ["Silicon Valley", "London", "Las Vegas", "Paris", "Sofia"],
    ["BMW", "Audi", "Lada", "Skoda", "Opel"]));