function GetNumber(arr){
   let result = [];
   for (let index = 0; index < arr.length; index++) {
       if(arr[index]<0){
           result.unshift(arr[index]);
       }else {
        result.push(arr[index]);
       } 
   }
   console.log(result.join('\n'));
}
GetNumber([7, -2, 8, 9]);
GetNumber([3, -2, 0, -1]);