function SortBy2(arr) {
    arr.sort((a, b) => a.length - b.length || a.localeCompare(b));
    for(let word of arr) {
        console.log(word);
    }
}

// console.log(SortBy2(['alpha', 'beta', 'gamma']));
// console.log(SortBy2(['Isacc', 'Theodor', 'Jack', 'Harrison', 'George']));
console.log(SortBy2(['test', 'Default', 'Deny', 'omen']));