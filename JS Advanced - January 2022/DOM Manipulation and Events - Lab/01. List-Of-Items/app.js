function addItem() {
    let text = document.getElementById('newItemText').value;
    let itemList = document.getElementById('items');
    let listItem = document.createElement('li');
    listItem.textContent = text;
    itemList.appendChild(listItem);
}