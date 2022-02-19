window.addEventListener('load', solution);

function solution() {
  const block = document.getElementById('block');

  const submitBtn = document.getElementById('submitBTN');
  const editBtn = document.getElementById('editBTN');
  const continueBtn = document.getElementById('continueBTN');

  const fullNameBox = document.getElementById('fname');
  const emailBox = document.getElementById('email');
  const phoneNumberBox = document.getElementById('phone');
  const addressBox = document.getElementById('address');
  const postalCodeBox = document.getElementById('code');

  const infoBox = document.getElementById('infoPreview');

  submitBtn.addEventListener('click', () => {
    const fullName = fullNameBox.value;
    const email = emailBox.value;
    const phoneNumber = phoneNumberBox.value;
    const address = addressBox.value;
    const postalCode = postalCodeBox.value;

    if (fullName === '' || email === '') {
      return;
    }

    fullNameBox.value = '';
    emailBox.value = '';
    phoneNumberBox.value = '';
    addressBox.value = '';
    postalCodeBox.value = '';

    let fullNameInfo = document.createElement('li');
    fullNameInfo.textContent = `Full Name: ${fullName}`;
    infoBox.appendChild(fullNameInfo);

    let emailInfo = document.createElement('li');
    emailInfo.textContent = `Email: ${email}`;
    infoBox.appendChild(emailInfo);

    let phoneNumberInfo = document.createElement('li');
    phoneNumberInfo.textContent = `Phone Number: ${phoneNumber}`;
    infoBox.appendChild(phoneNumberInfo);

    let addressInfo = document.createElement('li');
    addressInfo.textContent = `Address: ${address}`;
    infoBox.appendChild(addressInfo);

    let postalCodeInfo = document.createElement('li');
    postalCodeInfo.textContent = `Post Code: ${postalCode}`;
    infoBox.appendChild(postalCodeInfo);

    submitBtn.disabled = true;
    editBtn.disabled = false;
    continueBtn.disabled = false;

    editBtn.addEventListener('click', () => {
      let listItems = infoBox.getElementsByTagName('li');

      let tempFullName = '';
      let tempEmail = '';
      let tempPhoneNumber = '';
      let tempAddress = '';
      let tempPostalCode = '';

      for (let index = 0; index < listItems.length; index++) {
        listItems[index].textContent = listItems[index].textContent.split(': ')[1];
        tempFullName = listItems[0].textContent;
        tempEmail = listItems[1].textContent;
        tempPhoneNumber = listItems[2].textContent;
        tempAddress = listItems[3].textContent;
        tempPostalCode = listItems[4].textContent;
      }

      while (listItems.length != 0) {
        listItems[listItems.length - 1].remove();
      }

      fullNameBox.value = tempFullName;
      emailBox.value = tempEmail;
      phoneNumberBox.value = tempPhoneNumber;
      addressBox.value = tempAddress;
      postalCodeBox.value = tempPostalCode;

      submitBtn.disabled = false;
      editBtn.disabled = true;
      continueBtn.disabled = true;
    });

    continueBtn.addEventListener('click',()=>{
      block.innerHTML = '';
      let header = document.createElement('h3');
      header.textContent = `Thank you for your reservation!`;
      block.appendChild(header);
    });
  });
}
