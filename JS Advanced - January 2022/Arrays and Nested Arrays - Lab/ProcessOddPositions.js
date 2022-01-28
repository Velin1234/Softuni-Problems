function ProcessOddPositions(arr) {
    let newArray = [];
    for (let index = 1; index < arr.length; index++) {
        if (index%2!==0) {
            newArray.push(arr[index]*2);
        }
    }
    newArray = newArray.reverse();
    return newArray.join(' ');
}

console.log(ProcessOddPositions([10, 15, 20, 25]));
console.log(ProcessOddPositions([3, 0, 10, 4, 7, 3]));