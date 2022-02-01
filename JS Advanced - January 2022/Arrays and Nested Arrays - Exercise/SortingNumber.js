function SortingNumbers(arr) {
    arr.sort((a, b) => a - b);
    let finalArray = [];

    while(arr.length> 0){
        finalArray.push(arr.shift());

        if (arr.length) {
            finalArray.push(arr.pop());
        }
    }
    return finalArray;
}
SortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);