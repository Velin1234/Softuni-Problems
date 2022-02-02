function storeCatalogue(array) {
    let orderedList = [];
    for(let product of array) {
        let productInfo = product.split(' : ');
        let productName = productInfo[0];
        let productPrice = Number(productInfo[1]);

        orderedList.push({product: productName, price: productPrice});
    } 
    orderedList = orderedList.sort((a, b) => (a.product).localeCompare(b.product));
    let lastUpperCase = null;

    for(let product of orderedList) {
        let upperCase = product.product[0];
        if(lastUpperCase !== upperCase) {
            lastUpperCase = upperCase;
            console.log(upperCase);
        }
        console.log(` ${product.product}: ${product.price}`);
    }
}