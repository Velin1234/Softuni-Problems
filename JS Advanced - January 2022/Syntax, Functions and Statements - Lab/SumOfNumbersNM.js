    function SumOfNumbersNM(n,m) {
        var num1 = Number(n);
        var num2 = Number(m);
        var result = 0;
        for (let index = num1; index <= num2; index++) {
            result+=index;
        }
        console.log(result);
    }
    SumOfNumbersNM(1,5);