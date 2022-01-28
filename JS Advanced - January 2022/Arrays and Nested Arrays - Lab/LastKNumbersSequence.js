function LastKNumberSequence(n,k){
    let arr = [1];
    for (let index = 1; index < n; index++) {
        let lastNumsSum = arr.slice(-k).reduce((partialSum, a) => partialSum + a, 0);
        arr.push(lastNumsSum);        
    }
    return arr;
}
console.log(LastKNumberSequence(6,3));
console.log(LastKNumberSequence(8,2));