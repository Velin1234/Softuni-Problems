function createAssemblyLine() {
    const object = {
        hasClima(carObject) {
            carObject['temp'] = 21;
            carObject['tempSettings'] = 21;
            carObject['adjustTemp'] = function adjustTemp() {
                if (carObject['temp'] < carObject['tempSettings']) {
                    carObject['temp']++;
                } else {
                    carObject['temp']--;
                }
            }
        },
        hasAudio(carObject) {
            carObject['currentTrack'] = {
                name: null,
                artist: null,
            };
            carObject['nowPlaying'] = function nowPlaying() {
                console.log(`${carObject['currentTrack'].name} by ${carObject['currentTrack'].artist}`);
            }
        },
        hasParktronic(carObject) {
            carObject['checkDistance'] = function checkDistance(distance) {
                distance = Number(distance);
                if (distance < 0.1) {
                    printMessage ="Beep! Beep! Beep!";
                } else if (distance < 0.25) {
                    printMessage = 'Beep! Beep!';
                } else if (distance < 0.5) {
                    printMessage = 'Beep!';
                }
                console.log(printMessage);
            }
        }
    }
    return object;
}


const assemblyLine = createAssemblyLine();

const myCar = {
    make: 'Toyota',
    model: 'Avensis'
};

assemblyLine.hasClima(myCar);
console.log(myCar.temp);
myCar.tempSettings = 18;
myCar.adjustTemp();
console.log(myCar.temp);

assemblyLine.hasAudio(myCar);
myCar.currentTrack = {
    name: 'Never Gonna Give You Up',
    artist: 'Rick Astley'
};
myCar.nowPlaying();

assemblyLine.hasParktronic(myCar);
myCar.checkDistance(0.4);
myCar.checkDistance(0.2);

console.log(myCar);