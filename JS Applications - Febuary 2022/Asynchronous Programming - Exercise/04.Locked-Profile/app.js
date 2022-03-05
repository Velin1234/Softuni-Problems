async function lockedProfile() {
    const urlProfiles = `http://localhost:3030/jsonstore/advanced/profiles`;
    const resProfiles = await fetch(urlProfiles);
    const dataProfiles = await resProfiles.json();

    const main = document.getElementById('main');

    Object.entries(dataProfiles).forEach(element => {
        let profileElement = document.createElement('div');
        profileElement.classList.add("profile");

        let image = document.createElement('img');
        image.src = "./iconProfile2.png";
        image.classList.add('userIcon');
        profileElement.appendChild(image);

        let labelLock = document.createElement('label');
        labelLock.textContent = 'Lock';
        profileElement.appendChild(labelLock);

        let lockRadioButton = document.createElement('input');
        lockRadioButton.type = 'radio';
        lockRadioButton.name = `${element[1]._id}Locked`;
        lockRadioButton.value = 'lock';
        lockRadioButton.checked = true;
        lockRadioButton.addEventListener('click', () => {
            if (lockRadioButton.checked) {
                showMoreBtn.disabled = true;
            }
        });
        profileElement.appendChild(lockRadioButton);

        let labelUnlock = document.createElement('label');
        labelUnlock.textContent = 'Unlock';
        profileElement.appendChild(labelUnlock);

        let unlockRadioButton = document.createElement('input');
        unlockRadioButton.type = 'radio';
        unlockRadioButton.name = `${element[1]._id}Locked`;
        unlockRadioButton.value = 'unlock';
        unlockRadioButton.addEventListener('click', () => {
            if (unlockRadioButton.checked) {
                showMoreBtn.disabled = false;
            }
        });
        profileElement.appendChild(unlockRadioButton);

        let hrElement = document.createElement('hr');
        profileElement.appendChild(hrElement);

        let labelUsername = document.createElement('label');
        labelUsername.textContent = 'Username';
        profileElement.appendChild(labelUsername);

        let inputUsername = document.createElement('input');
        inputUsername.type = 'text';
        inputUsername.name = `${element[1]._id}Username`;
        inputUsername.value = element[1].username;
        inputUsername.disabled = true;
        inputUsername.readOnly = true;
        profileElement.appendChild(inputUsername);

        let hiddenFields = document.createElement('div');
        hiddenFields.id = `${element[1]._id}HiddenFields`;
        hiddenFields.hidden = true;
        hiddenFields.appendChild(hrElement);

        let emailLabel = document.createElement('label');
        emailLabel.textContent = 'Email:';
        hiddenFields.appendChild(emailLabel);

        let emailInput = document.createElement('input');
        emailInput.type = 'email';
        emailInput.name = `${element[1]._id}Email`;
        emailInput.value = `${element[1].email}`;
        emailInput.disabled = true;
        emailInput.readOnly = true;
        hiddenFields.appendChild(emailInput);

        let ageLabel = document.createElement('label');
        ageLabel.textContent = 'Age:';
        hiddenFields.appendChild(ageLabel);

        let ageInput = document.createElement('input');
        ageInput.type = 'age';
        ageInput.name = `${element[1]._id}Age`;
        ageInput.value = `${element[1].age}`;
        ageInput.disabled = true;
        ageInput.readOnly = true;
        hiddenFields.appendChild(ageInput);

        profileElement.appendChild(hiddenFields);

        let showMoreBtn = document.createElement('button');
        showMoreBtn.textContent = 'Show more';
        showMoreBtn.disabled = true;
        showMoreBtn.addEventListener('click', () => {
            if (showMoreBtn.textContent === "Hide it") {
                hiddenFields.hidden = true;
                showMoreBtn.textContent = 'Show more';
            } else {
                hiddenFields.hidden = false;
                showMoreBtn.textContent = "Hide it";
            }

        })
        profileElement.appendChild(showMoreBtn);


        main.appendChild(profileElement);
    });
}