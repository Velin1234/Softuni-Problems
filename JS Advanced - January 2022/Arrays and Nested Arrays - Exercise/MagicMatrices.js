function MagicMatrices(arr) {
    let maxRowSum = 0;
    let rowArr = arr[0];
    for (let col = 0; col < rowArr.length; col++) {
        maxRowSum += rowArr[col];
    }

    for (let row = 1; row < arr.length; row++) {
        let currRowArr = arr[row];
        let currRowSum = 0;
        for (let col = 0; col < currRowArr.length; col++) {
            currRowSum += currRowArr[col];
        }
        if (maxRowSum != currRowSum) {
            return false;
        }
    }
    
    let maxColSum = 0;
    for (let col = 0; col < arr.length; col++) {
        maxColSum += arr[0][col];
    }

    for (let col = 1; col < arr.length; col++) {
        let currentColSum = 0;
        for (let row = 0; row < arr.length; row++) {
            currentColSum+=arr[row][col];
        }
        if (currentColSum != maxColSum) {
            return false;
        }
    }
    return true;
}

console.log(MagicMatrices([
    [4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]));

console.log(MagicMatrices([
    [11, 32, 45],
    [21, 0, 1],
    [21, 1, 1]]));

console.log(MagicMatrices([
    [1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]));