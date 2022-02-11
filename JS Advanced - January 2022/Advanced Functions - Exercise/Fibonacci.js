function getFinotaor(){
    let startZero = 1;
    let startOne = 1;
    let fibonacciNumber = 0;
    return function (){
        [fibonacciNumber, startZero, startOne] = [startZero, startOne, startZero + startOne]
        return fibonacciNumber;
    }
}