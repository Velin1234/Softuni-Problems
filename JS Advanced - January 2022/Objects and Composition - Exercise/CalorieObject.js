function CalorieObject(arrOfObjects) {
    let jsonMessage = '{\n';
    for (let i = 0; i < arrOfObjects.length; i += 2) {
        let propKey = arrOfObjects[i];
        let propValue = arrOfObjects[i + 1];
        jsonMessage += `"${propKey}": ${propValue}`;
        if ((arrOfObjects[i + 2])) {
            jsonMessage += ',\n';
        } else {
            jsonMessage += '\n';
        }
    }
    jsonMessage += '}';
    console.log(JSON.parse(jsonMessage));
}
CalorieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);