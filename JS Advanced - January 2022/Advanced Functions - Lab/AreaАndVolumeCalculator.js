function solve(area, vol, input) {
    return JSON.parse(input).map(o => ({

        area: area.call(o),
        volume: vol.call(o)

    }));
}


function vol() {
    return Math.abs(this.x * this.y * this.z);
};

function area() {
    return Math.abs(this.x * this.y);
};