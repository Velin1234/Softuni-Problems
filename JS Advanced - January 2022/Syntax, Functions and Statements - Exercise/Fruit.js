    function Fruit(fruitName,weight,money){
        var weightNum = Number(weight)/1000;
        var moneyNum = Number(money);
        var neededMoney = moneyNum * weightNum
        console.log(`I need $${neededMoney.toFixed(2)} to buy ${weightNum.toFixed(2)} kilograms ${fruitName}.`)
    }
    Fruit('orange',2500,1.80);
    Fruit('apple', 1563, 2.35);
