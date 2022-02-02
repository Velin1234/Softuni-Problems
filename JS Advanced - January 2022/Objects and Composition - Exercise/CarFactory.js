function CarFactory(car) {
    if (car.power < 90) {
        car['engine'] = {
            power: 90,
            volume: 1800
        }
    } else if (car.power > 90 && car.power <= 120){
        car['engine'] = {
            power: 120,
            volume: 2400
        }
    } else if(car.power >= 200){
        car['engine'] = {
            power: 200,
            volume: 3500
        }
    }
    delete car.power;

    if (car.carriage) {
        let carType = car.carriage;
        delete car.carriage;
        car['carriage'] ={
            type:carType,
            color:car.color,
        }
    }
    delete car.color;

    if (car.wheelsize % 2 === 0) {
        car.wheelsize--;
        car['wheels'] = [car.wheelsize,car.wheelsize,car.wheelsize,car.wheelsize];
    }else{
        car['wheels'] = [car.wheelsize,car.wheelsize,car.wheelsize,car.wheelsize];
    }

    delete car.wheelsize;
    return car;
}

let car = {
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}

let Ferrari = {
    model: 'Ferrari',
    power: 200,
    color: 'red',
    carriage: 'coupe',
    wheelsize: 21
};
CarFactory(car);
CarFactory(Ferrari);

console.log(Ferrari);