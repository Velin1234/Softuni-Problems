    function AggregateElements(array) {
        let sum = 0;
        let sumConcat = "";
        let sumInverse = 0;
        
        for (let i = 0; i < array.length; i++) {
            sum += array[i];
            sumConcat+=array[i];
            sumInverse+=1/array[i];
            }
            
            console.log(sum); 
            console.log(sumInverse);
            console.log(sumConcat);    
    }
    AggregateElements();