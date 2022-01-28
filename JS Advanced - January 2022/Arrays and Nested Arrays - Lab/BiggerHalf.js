function BiggerHalf(arr) {
    arr = arr.sort(function(a, b) {
        return a - b;
      });
    let halflength = Math.ceil(arr.length / 2); 
    let firstHalf = arr.slice(0,halflength);
    let firstHalfSum = firstHalf.reduce((partialSum, a) => partialSum + a, 0);
    let secondHalf = arr.slice(-halflength);
    let secondHalfSum = secondHalf.reduce((partialSum, a) => partialSum + a, 0);

    if(firstHalfSum > secondHalfSum){
        return firstHalf;
    }else{
        return secondHalf;
    }
}
// console.log(BiggerHalf([4, 7, 2, 5]));
console.log(BiggerHalf([3, 19, 14, 7, 2, 19, 6]));
