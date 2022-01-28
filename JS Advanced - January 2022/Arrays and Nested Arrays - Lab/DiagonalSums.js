function DiagonalSums(matrix) {
    let arr = [];
    let mainDiagonalSum = 0;
    let secondaryDiagonalSum = 0;
    let main = 0;

    for (let row = 0; row < matrix.length; row++) {
        let rowArr = matrix[row];
        secondaryDiagonalSum+= rowArr[rowArr.length-1-main];
        mainDiagonalSum += rowArr[main];
        main++;
    }
    arr.push(mainDiagonalSum);
    arr.push(secondaryDiagonalSum);

    return arr.join(' ');
}
    console.log(DiagonalSums([[20, 40],
        [10, 60]]));

        console.log(DiagonalSums([[3, 5, 17],
            [-1, 7, 14],
            [1, -8, 89]]));