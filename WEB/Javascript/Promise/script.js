// // FirstExample

// let newScript = document.createElement('script');
// newScript.src = 'first.js';
// document.body.appendChild(newScript);

// first();

// setTimeout(() => {
//     first();
// }, 1000); 



// let newScript = document.createElement('script');
// newScript.src = 'first.js';
// document.body.appendChild(newScript);


function getScriptAsync(src) {
    return new Promise((resolve, reject) => {
        let newScript = document.createElement('script');
        newScript.src = src;

        newScript.onload = resolve;
        newScript.onerror = reject;

        document.body.appendChild(newScript);
    });
}


getScriptAsync('first.js')
    .then(() => {
        first();
    })
    .catch(() => {
        console.log(new Error('something get wrong'));
    })


// getScriptAsync('first.js')
//     .then(() => {
//         first();
//     })
//     .catch(() => {
//         console.log(new Error('something get wrong'));
//     })

// getScriptAsync('second.js')
//     .then(() => {
//         second();
//     })
//     .catch(() => {
//         console.log(new Error('something get wrong'));
//     })

// getScriptAsync('third.js')
//     .then(() => {
//         third();
//     })
//     .catch(() => {
//         console.log(new Error('something get wrong'));
//     })




// getScriptAsync('first.js')
//     .then(() => {
//         first();
//     })
//     .then(() => {
//         getScriptAsync('second.js').then(() => {
//             second();
//         })
//     })
//     .catch(() => {
//         console.log(new Error('something get wrong'));
//     })



