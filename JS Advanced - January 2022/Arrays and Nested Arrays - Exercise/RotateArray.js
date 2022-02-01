function Rotate(arr, times) {
    for (let index = 0; index < times; index++) {
        arr.unshift(arr.pop());
    }
    return arr.join(' ');
}
console.log(Rotate(['1', '2', '3', '4'], 2));
console.log(Rotate(['Banana', 'Orange', 'Coconut', 'Apple'], 15));