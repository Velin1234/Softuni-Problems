async function getInfo() {
    const stopID = document.getElementById('stopId').value;
    const stopNameBox = document.getElementById('stopName');

    const timeTableElement = document.getElementById('buses');
    const url = `http://localhost:3030/jsonstore/bus/businfo/${stopID}`;

    try {
        stopNameBox.textContent = 'Loading...';
        timeTableElement.replaceChildren();
        const res = await fetch(url);

        if (res.status !== 200) {
            throw new Error('Stops ID not found!');
        }
        const data = await res.json();

        stopNameBox.textContent = data.name

        Object.entries(data.buses).forEach(bus => {
            const listItem = document.createElement('li');
            listItem.textContent = `Bus ${bus[0]} arrives in ${bus[1]} minutes`
            timeTableElement.appendChild(listItem);
        });
    } catch (error) {
        stopNameBox.textContent = error;
    }

}
