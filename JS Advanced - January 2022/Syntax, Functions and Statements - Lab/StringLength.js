    function StringLenght(string1,string2,string3) {
        var sumLength = string1.length + string2.length + string3.length;
        var averageLength = Math.floor(sumLength/3);
        console.log(sumLength);
        console.log(averageLength);
    }
    StringLenght('chocolate','ice cream','cake');