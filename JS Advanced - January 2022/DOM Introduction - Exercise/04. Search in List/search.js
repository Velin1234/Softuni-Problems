function search() {
   let towns = document.getElementsByTagName('li');
   let searchBox = document.getElementById('searchText');
   let resultBox = document.getElementById('result');

   let found = 0;
   
   for (let index = 0; index < towns.length; index++) {
      if(towns[index].textContent.includes(searchBox.value)){
         towns[index].style.textDecoration = "underline";
         towns[index].style.fontWeight = "bold";
         found++;
      }
   }
   resultBox.textContent = `${found} matches found`;
}
