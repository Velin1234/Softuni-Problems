    function GCD(num1,num2){
        let minNum = Math.min(num1, num2);
        commonDivisor = 1;
        for (let index = 1; index <=minNum; index++) 
        {
            if(num1%index ===0 && num2 %index === 0){
                commonDivisor = index;
            }
        }
        console.log(commonDivisor);
    }
    GCD(15,5);
    GCD(2154,458);
