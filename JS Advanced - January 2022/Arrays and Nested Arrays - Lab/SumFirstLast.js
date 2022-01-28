function SumFirstLast(arr){
let sum =0;
let arrEnd = arr.length;
sum+=Number(arr[0])+Number(arr[arrEnd-1]);
return sum;
}
console.log(SumFirstLast(['20','30','40']));