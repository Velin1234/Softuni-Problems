function solve() {
    const firstNameBox = document.getElementById('fname');
    const lastNameBox = document.getElementById('lname');
    const emailBox = document.getElementById('email');
    const birthBox = document.getElementById('birth');
    const positionBox = document.getElementById('position');
    const salaryBox = document.getElementById('salary');

    const hireWorkerBtn = document.getElementById('add-worker');

    const table = document.getElementById('tbody');

    const budgetSum = document.getElementById('sum');

    hireWorkerBtn.addEventListener('click', (e) => {
        e.preventDefault();

        if (firstNameBox.value === '' || lastNameBox.value === '' || emailBox.value === ''
            || birthBox.value === '' || positionBox.value === '' || salaryBox.value === '') {
            return;
        }
        let rowItem = document.createElement('tr');

        let firstNameData = document.createElement('td');
        firstNameData.textContent = firstNameBox.value;
        rowItem.appendChild(firstNameData);

        let lastNameData = document.createElement('td');
        lastNameData.textContent = lastNameBox.value;
        rowItem.appendChild(lastNameData);

        let emailData = document.createElement('td');
        emailData.textContent = emailBox.value;
        rowItem.appendChild(emailData);

        let birthData = document.createElement('td');
        birthData.textContent = birthBox.value;
        rowItem.appendChild(birthData);

        let positionData = document.createElement('td');
        positionData.textContent = positionBox.value;
        rowItem.appendChild(positionData);

        let salaryData = document.createElement('td');
        salaryData.textContent = salaryBox.value;
        rowItem.appendChild(salaryData);

        let actionButtonsData = document.createElement('td');

        let fireButton = document.createElement('button');
        fireButton.textContent = 'Fired';
        fireButton.classList.add('fired');
        actionButtonsData.appendChild(fireButton);

        fireButton.addEventListener('click',()=>{
            budgetSum.textContent = (Number(budgetSum.textContent) - Number(salaryData.textContent)).toFixed(2);
            rowItem.remove();
        });

        let editButton = document.createElement('button');
        editButton.textContent = 'Edit';
        editButton.classList.add('edit');
        actionButtonsData.appendChild(editButton);

        editButton.addEventListener('click', () => {
            firstNameBox.value = firstNameData.textContent;
            lastNameBox.value = firstNameData.textContent;
            emailBox.value = firstNameData.textContent;
            birthBox.value = firstNameData.textContent;
            positionBox.value = firstNameData.textContent;
            salaryBox.value = firstNameData.textContent;
            budgetSum.textContent = Math.abs((Number(budgetSum.textContent) - Number(salaryBox.value)).toFixed(2));
            rowItem.remove();
        });

        rowItem.appendChild(actionButtonsData);

        table.appendChild(rowItem);

        budgetSum.textContent = (Number(budgetSum.textContent) + Number(salaryBox.value)).toFixed(2);

        firstNameBox.value = '';
        lastNameBox.value = '';
        emailBox.value = '';
        birthBox.value = '';
        positionBox.value = '';
        salaryBox.value = '';
    });
}
solve()