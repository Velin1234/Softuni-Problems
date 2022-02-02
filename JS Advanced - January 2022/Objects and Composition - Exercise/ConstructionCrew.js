function modifyWorker(worker) {
    if (worker.dizziness) {
        hydratation = (worker.weight * 0.1) * worker.experience;
        worker.levelOfHydrated += hydratation;
        worker.dizziness = false;
    }
    return worker;
}

let worker = {
    weight: 95,
    experience: 3,
    levelOfHydrated: 0,
    dizziness: false
};

modifyWorker(worker);
console.log(worker);
