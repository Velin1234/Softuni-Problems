function BiggestElement(arr) {
    let biggestElement = arr[0][0];
    for (let row of arr) {
        if (Math.max(...row)>biggestElement) {
            biggestElement = Math.max(...row);
        }
    }
    return biggestElement;
}

console.log(BiggestElement([[20, 50, 10],
    [8, 33, 145]]))
console.log(BiggestElement([[3, 5, 7, 12],
    [-1, 4, 33, 2],
    [8, 3, 0, 4]]))
