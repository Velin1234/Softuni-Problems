function GetEvenPos(array){
    let evenArr = [];
    for (let index = 0; index < array.length; index++) {
        let element = array[index];
        if(index %2 === 0){
            evenArr.push(element);
        }
    }
    let evenNums = evenArr.join(' ');
    console.log(evenNums);
}
GetEvenPos(['20', '30', '40', '50', '60'])
