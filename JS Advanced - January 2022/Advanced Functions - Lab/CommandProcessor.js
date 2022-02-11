function solution() {
    let result = '';
    return {

        append,
        removeStart,
        removeEnd,
        print

    }

    function append(string) {
        result += string;
    }

    function removeStart(index) {
        result = result.slice(index);
    }
    function removeEnd(index) {
        result = result.slice(0, -index);
    }
    function print() {
        console.log(result);
    }
}

let firstZeroTest = solution();
firstZeroTest.append('hello');
firstZeroTest.append('again');
firstZeroTest.removeStart(3);
firstZeroTest.removeEnd(4);
firstZeroTest.print();

let secondZeroTest = solution();
secondZeroTest.append('123');
secondZeroTest.append('45');
secondZeroTest.removeStart(2);
secondZeroTest.removeEnd(1);
secondZeroTest.print();
