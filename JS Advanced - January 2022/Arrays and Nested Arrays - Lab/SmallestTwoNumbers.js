function SmallestTwoNums(arr) {
    arr = arr.sort(function(a, b) {
        return a - b;
      });
    while(arr.length > 2 ){
        arr.pop();
    }
    console.log(arr.join(' '));
}
SmallestTwoNums([30, 15, 50, 5]);
SmallestTwoNums([3, 0, 10, 4, 7, 3]);