window.addEventListener('load', solve);

function solve() {
    const addButtonElement = document.getElementById("add");
    const modelBox = document.getElementById("model");
    const yearBox = document.getElementById("year");
    const descriptionBox = document.getElementById("description");
    const priceBox = document.getElementById("price");
    const furnitureList = document.getElementById("furniture-list");
    const totalProfitBox = document.getElementsByClassName("total-price")[0];

    addButtonElement.addEventListener('click', (e) => {
        e.preventDefault();
        let model = modelBox.value;
        let description = descriptionBox.value;
        let year = Number(yearBox.value);
        let price = Number(priceBox.value);

        if (!model || !description) {
            return;
        }

        if (year <= 0 || price <= 0) {
            return;
        }

        let rowElement = document.createElement('tr');
        rowElement.classList.add('info');
        let modelCellElement = document.createElement('td');
        let priceCellElement = document.createElement('td');
        let actionsCellElement = document.createElement('td');

        let moreInfoButton = document.createElement('button');
        let buyItButton = document.createElement('button');

        let contentsRowElement = document.createElement('tr');
        let yearContentElement = document.createElement('td');
        let descriptionContentElement = document.createElement('td');

        yearContentElement.textContent = `Year: ${year}`;
        descriptionContentElement.setAttribute('colspan', 3);
        descriptionContentElement.textContent = `Description: ${description}`;

        moreInfoButton.textContent = 'More Info';
        buyItButton.textContent = 'Buy it';
        moreInfoButton.classList.add('moreBtn');
        buyItButton.classList.add('buyBtn');
        contentsRowElement.classList.add('hide');
        contentsRowElement.style.display = 'none';
        contentsRowElement.appendChild(yearContentElement);
        contentsRowElement.appendChild(descriptionContentElement);

        moreInfoButton.addEventListener('click', (e) => {
            if (e.currentTarget.textContent == "More Info") {
                contentsRowElement.style.display = 'contents';
                e.currentTarget.textContent = "Less Info";
            } else {
                contentsRowElement.style.display = 'none';
                e.currentTarget.textContent = "More Info";
            }
        });

        buyItButton.addEventListener('click', (e) => {
            rowElement.remove();
            contentsRowElement.remove();
            totalProfitBox.textContent = (Number(totalProfitBox.textContent) + price).toFixed(2);
        });

        actionsCellElement.appendChild(moreInfoButton);
        actionsCellElement.appendChild(buyItButton);

        modelCellElement.textContent = model;
        priceCellElement.textContent = price.toFixed(2);

        rowElement.appendChild(modelCellElement);
        rowElement.appendChild(priceCellElement);
        rowElement.appendChild(actionsCellElement);

        furnitureList.appendChild(rowElement);
        furnitureList.appendChild(contentsRowElement);

        modelBox.value = "";
        yearBox.value = "";
        descriptionBox.value = "";
        priceBox.value = "";
    });
}
