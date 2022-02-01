function AddRemoveElements(arrCmd) {
    let arrayIndex = 1;
    let arr = [];
    for (let index = 0; index < arrCmd.length; index++) {
        if (arrCmd[index] === "add") {
            arr.push(arrayIndex);
        } else if (arrCmd[index] === "remove") {
            arr.pop();
        }
        arrayIndex++;
    }
    if (arr.length === 0) {
        return "Empty";
    }
    return arr.join('\n');
}
console.log(AddRemoveElements(['add', 'add', 'add', 'add']));
console.log(AddRemoveElements(['add', 'add', 'remove', 'add', 'add']));
console.log(AddRemoveElements(['remove', 'remove', 'remove']));
