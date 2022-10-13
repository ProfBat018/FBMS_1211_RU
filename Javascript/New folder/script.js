// let parent = document.getElementById('parent');
// let child = document.getElementById('child');

// parent.onclick = () => {console.log(parent.id);}; 
// child.onclick = () => {console.log(child.id);}; 


// parent.addEventListener('click', () => {console.log(parent.id);}, true);
// child.addEventListener('click', () => {console.log(child.id);}, true);


// let number = 0;


// let box = document.querySelector('#box');
// let p = document.createElement('p')


// box.addEventListener('click', () => {
//     p.innerText = number++; 
//     box.appendChild(p); 
// });


// console.log(window.document.getElementById('box').dataset.kerim);


let box = document.querySelector('#box');
let target = document.querySelector('#box').dataset.target;

console.log(target);

let element = document.querySelector(target);

box.addEventListener('click', () => {
    element.style.setProperty('background-color', 'green');
});



