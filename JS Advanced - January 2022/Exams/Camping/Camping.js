class SummerCamp {
    constructor(organiser, location) {
        this.organiser = organiser;
        this.location = location;
        this.priceForTheCamp = {
            "child": 150,
            "student": 300,
            "collegian": 500
        }
        this.listOfParticipants = [];
    }

    registerParticipant(name, condition, money) {
        if (!this.priceForTheCamp[condition]) {
            throw new Error ("Unsuccessful registration at the camp.");
        }

        if (money < this.priceForTheCamp[condition]) {
            return `The money is not enough to pay the stay at the camp.`;
        }

        let participant = {
            "name": name,
            "condition": condition,
            "power": 100,
            "wins": 0
        }

        if (this.listOfParticipants.some(p => p.name === name)) {
            return `The ${name} is already registered at the camp.`;
        }

        this.listOfParticipants.push(participant);

        return `The ${name} was successfully registered.`;

    }

    unregisterParticipant(name) {
        if (!this.listOfParticipants.some(p => p.name === name)) {
            throw new Error(`The ${name} is not registered in the camp.`);
        }

        this.listOfParticipants.splice(this.listOfParticipants.findIndex(p => p.name === name), 1);
        return `The ${name} removed successfully.`;
    }

    timeToPlay(typeOfGame, ...participants) {
        if (typeOfGame === "WaterBalloonFights") {
            let participant1 = this.listOfParticipants.find(p => p.name === participants[0]);
            let participant2 = this.listOfParticipants.find(p => p.name === participants[1]);

            if (participant1 === undefined || participant2 === undefined) {
                throw new Error(`Invalid entered name/s.`);
            }

            if (participant1.condition != participant2.condition) {
                throw new Error(`Choose players with equal condition.`);
            }

            if (participant1.power > participant2.power) {
                participant1.wins++;
                return `The ${participant1.name} is winner in the game ${typeOfGame}.`;
            } else if (participant1.power < participant2.power) {
                participant2.wins++;
                return `The ${participant2.name} is winner in the game ${typeOfGame}.`;
            } else {
                return `There is no winner.`;
            }

        } else if (typeOfGame === "Battleship") {
            let participant1 = this.listOfParticipants.find(p => p.name === participants[0]);
            if (participant1 === undefined) {
                return `Invalid entered name/s.`;
            }
            participant1.power += 20;
            return `The ${participant1.name} successfully completed the game ${typeOfGame}.`
        }
    }

    toString() {
        let resultString = []
        resultString.push(`${this.organiser} will take ${this.listOfParticipants.length} participants on camping to ${this.location}`);
        this.listOfParticipants.sort((a, b) => b.wins - a.wins);
        this.listOfParticipants.forEach(p => {
            resultString.push(`${p.name} - ${p.condition} - ${p.power} - ${p.wins}`)
        })

        return resultString.join('\n');
    }
}

const summerCamp = new SummerCamp("Jane Austen", "Pancharevo Sofia 1137, Bulgaria");
// console.log(summerCamp.registerParticipant("Petar Petarson", "student", 200));
// console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
// console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
// console.log(summerCamp.registerParticipant("Leila Wolfe", "child", 200));

// console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
// console.log(summerCamp.unregisterParticipant("Petar"));
// console.log(summerCamp.unregisterParticipant("Petar Petarson"));

// console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
// console.log(summerCamp.timeToPlay("Battleship", "Petar Petarson"));
// console.log(summerCamp.registerParticipant("Sara Dickinson", "child", 200));
// console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Sara Dickinson"));
// console.log(summerCamp.registerParticipant("Dimitur Kostov", "student", 300));
// console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Dimitur Kostov"));

console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
console.log(summerCamp.timeToPlay("Battleship", "Petar Petarson"));
console.log(summerCamp.registerParticipant("Sara Dickinson", "child", 200));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Sara Dickinson"));
console.log(summerCamp.registerParticipant("Dimitur Kostov", "student", 300));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Dimitur Kostov"));

console.log(summerCamp.toString());
