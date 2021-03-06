function Info(...args){
    let dictionary = {};
    
    args.forEach(elem => {

        printElementAndItsDataType(elem);
        const key = typeof(elem);

        if (!dictionary[key]) {
        
            dictionary[key] = 0;

        }

        dictionary[key]++;
    });

    const sorted = Object.fromEntries(Object.entries(dictionary).sort(([, a], [, b]) => b - a));

    printTypesAndTheirCount(sorted);

    function printElementAndItsDataType(element) {

        console.log(`${typeof(element)}: ${typeof(element) !== 'object' ? element : JSON.stringify(element)}`);

    }

    function printTypesAndTheirCount(dictionary) {

        for (const element in dictionary) {
            
            console.log(`${element} = ${dictionary[element]}`);

        }

    }
}

Info('cat', 42, function () { console.log('Hello world!'); })