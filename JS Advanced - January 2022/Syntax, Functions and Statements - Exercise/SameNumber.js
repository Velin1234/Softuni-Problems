    function SameNumbers(num){
        var same = true;
        var sumOfDigits = 0;
        var myFunc = num => Number(num);
        var intArr = Array.from(String(num),myFunc)
        var previousElement = intArr[0];
        intArr.forEach(element => {
            if(element !== previousElement){
                same = false;
                previousElement = element;
            }
            sumOfDigits+=element;
        });
        console.log(same);
        console.log(sumOfDigits);
    }
    SameNumbers(2222222);
    SameNumbers(1234);
