function focused() {
    let fields = document.getElementsByTagName("input");
    for (let field = 0; field < fields.length; field++) {
        fields[field].addEventListener('focus', () => {
            fields[field].parentElement.classList.add('focused');
        });
        fields[field].addEventListener('blur', () => {
            fields[field].parentElement.classList.remove('focused');
        });
    }
}