async function attachEvents() {
    const urlLocations = `http://localhost:3030/jsonstore/forecaster/locations`;
    const resLocations = await fetch(urlLocations);
    const dataLocations = await resLocations.json();
    const input = document.getElementById('location');

    const forecast = document.getElementById('forecast');
    const getWeatherButton = document.getElementById('submit');

    getWeatherButton.addEventListener('click', () => {
        let city = dataLocations.find(cityCode => cityCode.name === input.value);
        forecast.style.display = '';

        getTodayForecast(city);
        getUpcomingForecast(city);

    });

    async function getTodayForecast(city) {
        const urlTodayForecast = `http://localhost:3030/jsonstore/forecaster/today/${city.code}`;
        const resTodayForecast = await fetch(urlTodayForecast);
        const dataTodayForecast = await resTodayForecast.json();

        const currentWeather = document.getElementById('current');
        currentWeather.replaceChildren();
        let forecasts = document.createElement('div');
        forecasts.classList.add('forecasts');

        let symbol = document.createElement('span');
        symbol.classList.add('condition');
        symbol.classList.add('symbol');
        symbol.textContent = getConditionSymbol(dataTodayForecast.forecast.condition);
        forecasts.appendChild(symbol);

        let condition = document.createElement('span');
        condition.classList.add('condition');

        let cityName = document.createElement('span');
        cityName.classList.add('forecast-data');
        cityName.textContent = `${dataTodayForecast.name}`;
        condition.appendChild(cityName);

        let cityTemperature = document.createElement('span');
        cityTemperature.classList.add('forecast-data');
        cityTemperature.textContent = `${dataTodayForecast.forecast.low}°/${dataTodayForecast.forecast.high}°`;
        condition.appendChild(cityTemperature);

        let cityCondition = document.createElement('span');
        cityCondition.classList.add('forecast-data');
        cityCondition.textContent = `${dataTodayForecast.forecast.condition}`;
        condition.appendChild(cityCondition);

        forecasts.appendChild(condition);
        currentWeather.appendChild(forecasts);

    }

    async function getUpcomingForecast(city) {
        const urlUpcomingForecast = `http://localhost:3030/jsonstore/forecaster/upcoming/${city.code}`;
        const resUpcomingForecast = await fetch(urlUpcomingForecast);
        const dataUpcomingForecast = await resUpcomingForecast.json();

        const futureWeather = document.getElementById('upcoming');
        futureWeather.replaceChildren();

        dataUpcomingForecast.forecast.forEach(forecast => {
            let upcomingWeather = document.createElement('span');
            upcomingWeather.classList.add('upcoming');

            let symbol = document.createElement('span');
            symbol.classList.add('symbol');
            symbol.textContent = getConditionSymbol(forecast.condition);
            upcomingWeather.appendChild(symbol);

            let cityTemperature = document.createElement('span');
            cityTemperature.classList.add('forecast-data');
            cityTemperature.textContent = `${forecast.low}°/${forecast.high}°`;
            upcomingWeather.appendChild(cityTemperature);

            let cityCondition = document.createElement('span');
            cityCondition.classList.add('forecast-data');
            cityCondition.textContent = `${forecast.condition}`;
            upcomingWeather.appendChild(cityCondition);

            futureWeather.appendChild(upcomingWeather);

        });

    }

    function getConditionSymbol(condition) {
        switch (condition) {
            case "Sunny": {
                return `☀`;
            }
            case "Partly sunny": {
                return `⛅`;
            }
            case "Overcast": {
                return `☁`;
            }
            case "Rain": {
                return `☂`;
            }
        }
    }
}



attachEvents();