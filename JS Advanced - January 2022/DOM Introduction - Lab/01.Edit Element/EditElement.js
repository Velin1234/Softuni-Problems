function editElement(HtmlReference,stringMatch,replacer) {
    while(HtmlReference.textContent.includes(stringMatch)){
        HtmlReference.textContent = HtmlReference.textContent.replace(stringMatch,replacer);
    }
}