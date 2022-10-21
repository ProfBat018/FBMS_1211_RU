// let a = new Promise(function(resolve, reject){
//     try {
//         resolve();
//     }   
//     catch {
//         reject();
//     }
// });

// function resolve() {
//     console.log(resolved);
// }

// function reject(error) {
//     console.error(error);
// }

// Promise.reject(new Error('rejected')).then(resolve, reject);

// AJAX - asyncronous javascript and XML(Json)(Binary)... 

// let request = new XMLHttpRequest();

// request.open('GET', 'https://api.github.com/users/ProfBat018', true); // isAsync

// request.send()

// console.log(request.responseText);


// function getUserData() {
//     return new Promise(() => {
//         let request = new XMLHttpRequest();
//         request.open('GET', 'https://api.github.com/users/ProfBat018'); // isAsync
//         request.send();
//     });

// }

// async function main() {
//     console.log('begin call');
//     let res = await getUserData();
//     console.log(res);
//     console.log('END');
// }

// main();





