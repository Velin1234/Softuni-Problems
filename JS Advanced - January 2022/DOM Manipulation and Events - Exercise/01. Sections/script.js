function create(words) {
   let container = document.getElementById('content');
   for (let word = 0; word < words.length; word++) {
      let containerElement = document.createElement('div');
      
      let containerText = document.createElement('p');
      containerText.textContent = words[word];
      containerText.style.display = 'none';
      containerElement.appendChild(containerText);
      containerElement.addEventListener('click', () => {
         containerText.style.display = 'block';
      })
      container.appendChild(containerElement);
   }
}