function addItem() {
    let menu = document.getElementById('menu');
    let text = document.getElementById('newItemText');
    let inputValue = document.getElementById('newItemValue');
        
    let newOption = document.createElement('option');
    newOption.value = inputValue.value;
    newOption.textContent = text.value;

    text.value = '';
    inputValue.value = '';
    menu.appendChild(newOption);

}