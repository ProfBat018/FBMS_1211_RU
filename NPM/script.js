let body = document.querySelector('body');
let btn = document.querySelectorAll('.btn');

let img_arr = ['1.jpg', '2.jpg', '3.jpg'];
let counter = 0;

evt = window.event;


body.addEventListener('contextmenu', () => {
    event.preventDefault();
    let mycontext = document.querySelector('.mycontext');
    
    console.dir(window.event);
    mycontext.style.setProperty('top', `${event.y}px`);
    mycontext.style.setProperty('left', `${event.x}px`);
    mycontext.style.setProperty('display', 'block');
});


btn.forEach(x => x.addEventListener('click', () => {
    if (counter < 2) {
        counter++;
    } else {
        counter = 0;
    }
    console.dir(x.parentElement.previousElementSibling.src = img_arr[counter]);
}));




