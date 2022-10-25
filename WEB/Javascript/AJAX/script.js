// // Lesson 1
/*


const xhr = new XMLHttpRequest(); // ajax
xhr.withCredentials = true;

xhr.addEventListener("readystatechange", function () {
        if (this.readyState === this.DONE) {
        let data = JSON.parse(this.responseText)
        window.open(data.result.download_url);
        }
});

xhr.open("GET", "https://youtube-music1.p.rapidapi.com/get_download_url?id=_Yhyp-_hX2s&ext=mp3");
xhr.setRequestHeader("X-RapidAPI-Key", "afce3bc89fmsh1ca02613744b32ap11d006jsnda1143ee3262");
xhr.setRequestHeader("X-RapidAPI-Host", "youtube-music1.p.rapidapi.com");

xhr.send();
*/


// // Lesson 2
// 5191fee1957155f779bfd029a4a97e18

// https://api.openweathermap.org/data/2.5/weather?q=baku&appid=5191fee1957155f779bfd029a4a97e18



let searchBox = document.forms.search[0];
let searchBtn = document.forms.search[1];
let forecastImg = document.querySelector('#forecas-img');



searchBox.value = 'baku';

// // Lesson 2 part 1 
/*
main();

async function main() {
        searchBtn.addEventListener('click', async function () {
                let res = await getWeatherAsync(searchBox.value);
                console.dir(res);

                console.log(JSON.parse(res));
        });
}


async function getWeatherAsync(cityName) {
        return new Promise((resolve, reject) => {
                let xhr = new XMLHttpRequest(); // AJAX
                xhr.open('GET', `https://api.openweathermap.org/data/2.5/weather?q=${cityName}&appid=5191fee1957155f779bfd029a4a97e18`);

                xhr.onload = function () {
                        resolve(xhr.responseText); // callback
                }

                xhr.onerror = function () {
                        reject(new Error('Something get wrong'));
                }
                xhr.send();
        });
}

*/

// // Lesson 2 part 2 

// fetch

main();

async function main() {
        searchBtn.addEventListener('click', async function () {
                // let weatherRes = await fetch(`https://api.openweathermap.org/data/2.5/weather?q=${searchBox.value}&appid=5191fee1957155f779bfd029a4a97e18`); // ajax
                // let forecast = await weatherRes.json();

                // let iconRes = await fetch(`https://openweathermap.org/img/wn/${forecast.weather[0].icon}@2x.png`);

                // let img = await iconRes.blob();


                // // Example 1
                // forecastImg.src =  URL.createObjectURL(img);


                // // Example 2

                // var reader = new FileReader();
                // reader.readAsDataURL(img);
                // reader.onloadend = function () {
                //         var base64data = reader.result;
                //         console.log(base64data);
                // }


                // // Example 3

                // let iconRes = await fetch(`https://i.kym-cdn.com/entries/icons/original/000/034/421/cover1.jpg`);

                // let img = await  iconRes.blob();

                // var reader = new FileReader();
                // reader.readAsDataURL(img);
                // reader.onloadend = function () {
                //         var base64data = reader.result;
                //         console.log(base64data);
                // }

                // // Example 4 


                const options = {
                        method: 'GET',
                        headers: {
                                'X-RapidAPI-Key': 'afce3bc89fmsh1ca02613744b32ap11d006jsnda1143ee3262',
                                'X-RapidAPI-Host': 'youtube-music1.p.rapidapi.com'
                        }
                };

                let res = await fetch('https://youtube-music1.p.rapidapi.com/get_download_url?id=XbGs_qK2PQA&ext=mp3', options)

                let downloadUrl = await res.json();

                downloadUrl = downloadUrl.result.download_url;
                
                window.open(downloadUrl, '_self');
                });
}