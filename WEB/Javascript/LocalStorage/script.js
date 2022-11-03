// let person = {
//     name: "Elvin",
//     surname: "Azimov"
// };

// localStorage.setItem('localStorageData', JSON.stringify(person));

// sessionStorage.setItem('sessionStorageData', 'Elvinos018');


let a = indexedDB.open('tamerlans', 2);

a.onsuccess = function(){

    console.log(a.result.version);
};
