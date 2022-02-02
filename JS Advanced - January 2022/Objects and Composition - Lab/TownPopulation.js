function TownPopulation(townArr) {
    towns = [];
    townArr.forEach(townInfo => {
        townInfo = townInfo.split(' <-> ')
        let town = {
            townName: townInfo[0],
            townPopulation: Number(townInfo[1]),
        }
        if (towns.some(recordedTown => recordedTown.townName === town.townName)) {
            towns.forEach(recordedTown =>{
                if (recordedTown.townName === town.townName) {
                    recordedTown.townPopulation += town.townPopulation;
                }
            })
        } else {
            towns.push(town);
        }
    });

    towns.forEach(town => {
        console.log(`${town.townName} : ${town.townPopulation}`);
    });
}

// TownPopulation([
//     'Sofia <-> 1200000',
//     'Montana <-> 20000',
//     'New York <-> 10000000',
//     'Washington <-> 2345000',
//     'Las Vegas <-> 1000000']);

TownPopulation([
    'Istanbul <-> 100000',
    'Honk Kong <-> 2100004',
    'Jerusalem <-> 2352344',
    'Mexico City <-> 23401925',
    'Istanbul <-> 1000']);