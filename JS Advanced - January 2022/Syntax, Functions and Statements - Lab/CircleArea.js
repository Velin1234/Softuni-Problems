    function CircleArea(number) {
        if(typeof(number)!= "number")
        {
            console.log(`We can not calculate the circle area, because we receive a ${typeof(number)}.`);
        }
        else
        {
            var circleArea = Math.PI*(Math.pow(number,2));
            console.log(circleArea.toFixed(2));
        }
    }
    CircleArea(5);
    CircleArea("name");