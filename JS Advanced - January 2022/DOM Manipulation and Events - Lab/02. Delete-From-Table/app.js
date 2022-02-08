function deleteByEmail() {
    let rows = document.getElementsByTagName('tr');
    let searchedEmail = document.getElementsByName('email')[0].value;
    let result = document.getElementById('result');
    for (let row = 1; row < rows.length; row++) {
        let email = rows[row].getElementsByTagName('td')[1];
        if(email.textContent === searchedEmail){
            rows[row].remove();
            result.textContent = 'Deleted.';
            return;
        }
    }
    result.textContent = 'Not found.';
}