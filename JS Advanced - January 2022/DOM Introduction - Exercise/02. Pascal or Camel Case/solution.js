function solve() {
  let text = document.getElementById('text');
  let namingConvention = document.getElementById('naming-convention');
  let resultBox = document.getElementById('result');
  let result = ''

  if (namingConvention.value != "Pascal Case" && namingConvention.value != "Camel Case") {
    resultBox.textContent = 'Error!';
  }

  if (namingConvention.value === "Pascal Case") {
    let newText = text.value.toLowerCase();
    let newWord = false;
    for (let index = 0; index < newText.length; index++) {
      if(index == 0 || newWord){
        result += newText[index].toUpperCase();
        newWord = false;
        continue;
      }
      if(newText[index] === ' '){
        newWord = true;
        continue;
      }
      result += newText[index]
    }
    resultBox.textContent = result;
  }

  if (namingConvention.value === "Camel Case") {
    let newText = text.value.toLowerCase();
    let newWord = false;
    for (let index = 0; index < newText.length; index++) {
      if(newWord){
        result += newText[index].toUpperCase();
        newWord = false;
        continue;
      }
      if(newText[index] === ' '){
        newWord = true;
        continue;
      }
      result += newText[index]
    }
    resultBox.textContent = result;
  }
}