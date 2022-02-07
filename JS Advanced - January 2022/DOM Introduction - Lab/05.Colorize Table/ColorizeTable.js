function colorize() {
    let rows = document.getElementsByTagName('tr');
    for (let row = 1; row < rows.length; row++) {
        if (row % 2 != 0) {
            rows[row].style.background ='teal';            
        }
    }
}