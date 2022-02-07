function extractText() {
    let itemList = document.getElementsByTagName('li');
    let textBox = document.getElementById('result');
    for (let index = 0; index < itemList.length; index++) {
        textBox.value += itemList[index].textContent+'\n';
    }  
}