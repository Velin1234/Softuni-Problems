function addItem() {
    let itemBox = document.getElementById('items');
    
    let textInput = document.getElementById("newItemText");
    let item = document.createElement("li");
    item.textContent = textInput.value;
    let deleteLink = document.createElement("a");
    deleteLink.href = '#';
    deleteLink.textContent = '[Delete]';
    deleteLink.addEventListener('click', () => {
        let parent = deleteLink.parentNode;
        document.getElementById('items').removeChild(parent);
    });
    item.appendChild(deleteLink);
    
    itemBox.appendChild(item);
    
}