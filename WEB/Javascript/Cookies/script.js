// data = '{"theme":"light", "name":"ELvin"}';

// console.log(data);
// console.log(JSON.parse(data));
// console.log(JSON.parse(data).theme);
// console.log(JSON.parse(data).name);

console.dir(document);
let theme = document.querySelectorAll('.light');
let theme_selector = document.querySelector('.btn-dark');


window.addEventListener('load', () => {
    if (document.cookie == 'light') {
        light();
    } else {
        dark();
    }
});


function light() {
    theme_selector.classList.remove('btn-dark');
    theme_selector.classList.add('btn-light');
    theme_selector.innerText = 'Light';
    theme.forEach(element => {
        element.classList.remove('light');
        element.classList.add('dark');
    });
    document.cookie = 'light';
}

function dark() {
    theme_selector.classList.remove('btn-light');
    theme_selector.classList.add('btn-dark');
    theme_selector.innerText = 'Dark';
    theme.forEach(element => {
        element.classList.remove('dark');
        element.classList.add('light');
    });
    document.cookie = 'dark';
}



theme_selector.addEventListener('click', () => {
    if (document.cookie == 'light') {
        dark();
    } else {
        light();
    }
});



// let theme_selector = document.querySelector('.btn-dark');
// let isLight = true;

// theme_selector.addEventListener('click', () => {
//     if (isLight) {
//         theme_selector.classList.remove('btn-dark');
//         theme_selector.classList.add('btn-light');
//         theme_selector.innerText = 'Light';
//         document.body.style.setProperty('background-color', 'black');

//         isLight = false;
//     } else {
//         theme_selector.classList.remove('btn-light');
//         theme_selector.classList.add('btn-dark');
//         theme_selector.innerText = 'Dark';
//         document.body.style.setProperty('background-color', 'white');

//         isLight = true;
//     }
// });