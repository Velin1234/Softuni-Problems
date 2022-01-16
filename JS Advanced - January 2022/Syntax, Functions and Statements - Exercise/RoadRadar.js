function roadRadar(speed,area){
    let speeding = false;
    const cityLimit = 50;
    const interstateLimit = 90;
    const motorwayLimit = 130;
    const residentialLimit = 20;

    let difference;
    switch(area){
        case 'city':
            if(speed > cityLimit){
                speeding = true;
                difference = cityLimit - speed;
            }
            else{
                console.log(`Driving ${speed} km/h in a ${cityLimit} zone`)
            }
            break;
            
        case 'residential':
            if(speed > residentialLimit){
                speeding = true;
                difference = residentialLimit - speed;
            }
            else{
                console.log(`Driving ${speed} km/h in a ${residentialLimit} zone`)
            }
            break;

        case 'interstate':
                if(speed > interstateLimit){
                    speeding = true;
                    difference = interstateLimit - speed;
                }
                else{
                    console.log(`Driving ${speed} km/h in a ${interstateLimit} zone`)
                }
                break;

        case 'motorway':
                if(speed > motorwayLimit){
                    speeding = true;
                    difference = motorwayLimit -speed;
                }
                else{
                    console.log(`Driving ${speed} km/h in a ${motorwayLimit} zone`)
                }
                break;
    }
    let status;
    if(speeding){
        difference = Math.abs(difference);
        if(difference <= 20){
            status = 'speeding';
        }
        else if( difference <=40 && difference > 20){
            status = 'excessive speeding';
        }
        else{
            status = 'reckless driving';
        }

        switch(area){
            case 'city':
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${cityLimit} - ${status}`)
                break;

            case 'residential':
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${residentialLimit} - ${status}`)
                break;
            
            case 'interstate':
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${interstateLimit} - ${status}`)
                break;
            
            case 'motorway':
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${motorwayLimit} - ${status}`)
                break;
        }
    }
}

roadRadar(40,'city');
roadRadar(21, 'residential');
roadRadar(120, 'interstate');
roadRadar(200, 'motorway');