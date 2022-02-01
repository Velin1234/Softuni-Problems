function PrintEveryNth(arr, n) {
    let newArr = [];
    for (let index = 0; index < arr.length; index++) {
        if (index % n === 0) {
            newArr.push(arr[index]);
        }
    }
    return newArr;
}
console.log(PrintEveryNth(['5', '20', '31', '4', '20'], 2));
console.log(PrintEveryNth(['dsa', 'asd', 'test', 'tset'], 2));
console.log(PrintEveryNth(['1', '2','3', '4', '5'], 6));