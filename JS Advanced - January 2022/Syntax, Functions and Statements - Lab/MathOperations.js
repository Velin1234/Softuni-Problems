    function MathOperations(num1,num2,operator) {
        var result;
        switch(operator){
            case '+':
            result= num1 + num2;
            break;
            
            case '-':
            result=num1-num2;
            break;
            
            case '*':
            result =num1* num2;
            break;
            
            case '/':
            result =num1/ num2;
            break;
            
            case '%':
            result = num1% num2;
            break;

            case '**':
            result = num1 ** num2;
            break;
        }
        console.log(result);
    }
    MathOperations(5,2,'**')