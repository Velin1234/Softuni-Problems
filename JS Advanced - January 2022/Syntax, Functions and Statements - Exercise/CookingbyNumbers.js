function cook(number,o1,o2,o3,o4,o5){
    let operations = [o1,o2,o3,o4,o5];
    operations.forEach(operation => {
        if(operation == 'chop'){
            number = number /2;
        }
        else if(operation == 'dice'){
            number = Math.sqrt(number);
        }
        else if(operation == 'spice'){
            number = number+1;
        }
        else if (operation == 'bake'){
            number = number*3;
        }
        else if (operation == 'fillet'){
            number = number - number*0.2;
        }
        console.log(number);
    });
}

// cook('32', 'chop', 'chop', 'chop', 'chop', 'chop');
cook('9', 'dice', 'spice', 'chop', 'bake', 'fillet');