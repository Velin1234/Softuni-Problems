function solve() {
    let label = document.querySelector('#info span');
    let departBtn = document.getElementById('depart');
    let arriveBtn = document.getElementById('arrive');

    let currentStop = {
        next: 'depot'
    };
    let url = `http://localhost:3030/jsonstore/bus/schedule/${currentStop.next}`;


    async function depart() {
        const res = await fetch(url);
        const data = await res.json();

        label.textContent = `Next stop ${data.name}`

        departBtn.disabled = true;
        arriveBtn.disabled = false;
    }

    async function arrive() {
        const res = await fetch(url);
        const data = await res.json();

        label.textContent = `Arriving at ${data.name}`;

        currentStop.next = data.next;
        url = `http://localhost:3030/jsonstore/bus/schedule/${currentStop.next}`;
        departBtn.disabled = false;
        arriveBtn.disabled = true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();