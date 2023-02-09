let openButton = document.querySelector('#open-btn');
let closeButton = document.querySelector('#close-btn');

let targetName = openButton.dataset.target;
let target = document.querySelector(targetName);



openButton.addEventListener('click', () => {
    target.style.setProperty('display', 'block');
    target.style.setProperty('opacity', '1');
    closeButton.style.setProperty('display', 'block');
    closeButton.style.setProperty('opacity', '1');
});


closeButton.addEventListener('click', () => {
    target.style.setProperty('display', 'none');
    closeButton.style.setProperty('display', 'none');

});