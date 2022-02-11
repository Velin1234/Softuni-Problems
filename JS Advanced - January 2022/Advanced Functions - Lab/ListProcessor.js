function ListProcessor(arrCommands) {
    let input = [];

    const utilityObj = {
        add,
        remove,
        print
    }

    function add(string) {
        input.push(string);
    }

    function remove(string) {
        input = input.filter(e => e != string);
    }

    function print() {
        console.log(input.join(','));
    }

    arrCommands.forEach(commandString => {
        commandString = commandString.split(' ');
        let cmd = commandString[0];
        let string = commandString[1];

        switch (cmd) {
            case "add":
                utilityObj.add(string);
                break;
            case "remove":
                utilityObj.remove(string);
                break;
            case "print":
                utilityObj.print();
                break;
        }
    });
}

ListProcessor(['add hello', 'add again', 'remove hello', 'add again', 'print'])