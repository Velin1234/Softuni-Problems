function ExtractSubSet(arr) {
    let newArr = [arr[0]];

    arr.reduce((a, b) => {
        if (b >= newArr[newArr.length - 1]) {
            newArr.push(b);
        }
    });

    return newArr;
}
console.log(ExtractSubSet([1, 3, 8, 4, 10, 12, 3, 2, 24]));