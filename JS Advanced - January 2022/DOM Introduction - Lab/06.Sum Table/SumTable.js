function sumTable() {
    let sum = 0;
    let sumBox = document.getElementById('sum');
    let products = document.getElementsByTagName('tr');
    for (let product = 1; product < products.length - 1; product++) {
        let price = products[product].getElementsByTagName('td')[1];
        sum += Number(price.textContent);
    }
    sumBox.textContent = sum;
}