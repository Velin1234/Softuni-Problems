function encodeAndDecodeMessages() {
    let encodeButton = document.getElementsByTagName('button')[0];
    let messageBox = document.getElementsByTagName("textarea")[1];  
    let decodeButton = document.getElementsByTagName('button')[1];
    
    encodeButton.addEventListener("click",()=>{
        let message = document.getElementsByTagName("textarea")[0];
        let string = ''
        for (let index = 0; index < message.value.length; index++) {
            let newChar = message.value.charCodeAt(index)+1;
            string += String.fromCharCode(newChar);
        }
        message.value = '';
        messageBox.value = string;
    });
    
    decodeButton.addEventListener('click',()=>{
        let string = ''
        for (let index = 0; index < messageBox.value.length; index++) {
            let newChar = messageBox.value.charCodeAt(index)-1;
            string += String.fromCharCode(newChar);
        }
        messageBox.value = string;
    });
    
}