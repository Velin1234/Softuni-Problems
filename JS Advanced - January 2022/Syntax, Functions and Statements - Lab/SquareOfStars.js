    function SquareOfStars(size) {
        var result = "";
        for (let sizeRow = 0; sizeRow < size; sizeRow++) {
            for (let sizeCol = 0; sizeCol < size; sizeCol++) {
                result+='*'+' ';
            }
            result += "\n";
        }
        console.log(result);
    }
    SquareOfStars(5);