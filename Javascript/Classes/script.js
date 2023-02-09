// let h1 = document.createElement('h1');

// h1.innerHTML = 'Hello';

// alert(document.body.appendChild(h1));

// let paragraph = document.createElement('p');

// paragraph.innerHTML = 'Kerim<span><b>Hello</b></span>Orxan';

// document.getElementById('container').appendChild(paragraph);

// console.log(window);

// let a = function foo() {
//     console.log('(☞ﾟヮﾟ)☞');
//     return 'Orxan';
// };

// console.log(a());

// let b = a;

// b = function name(params) {
// console.log('☜(ﾟヮﾟ☜)');
// };

// let person =
// {
//     _name: 'Orxan',
//     setName: function(value)
//     {
//         this._name = value;
//     },
//     getName: function () {
//         return this._name;
//     }
// };

// console.log(person._name);
// person._name = 'Elvin';
// console.log(person._name);

// class person {
//   #name = "Elvin"; // readonly property
//   age = 10;

//   getName() {
//     return this.#name;
//   }
//   setName(name) {
//     this.#name = name;
//   }
// }

// let a = new person();

// person.prototype.toString = function () {
//     return a.getName();
// }

// function foo() {
//     return 'Foo';
// }

// foo.prototype.foo = function() {
//     return 'Overrided foo';
// }

// console.log(foo.prototype.foo());

// console.log(a.getName());
// a.setName('Orxan');
// console.log(a.getName());

// console.log(a.getUTCFullYear());
// console.log(a.getUTCDate());
// console.log(a.getUTCMonth() + 1);
// alert(a.getSeconds());

// function mytimer() {

//   let a = new Date();

//   let date_res = a.toLocaleDateString("az-AZ", {
//     year: "2-digit",
//     month: "2-digit",
//     day: "2-digit",
//     second: "2-digit",
//   });

//   document.getElementById("timer").innerHTML = date_res;
// }

// setInterval(mytimer, 1000);


class transport {
    make;
    model;

    constructor() {
        this.make = 'Mercedes';
        this.model = 'CLS 350 AMG';
    }
    year = new Date().toLocaleDateString();
}

class test {

}

class car extends transport {
    volume;
    constructor(params)
    {
        super();
        this.volume = 350;
    }
}

// let a = new car();

// console.log(a.make);
// console.log(a.model);
// console.log(a.year);
// console.log(a.volume);


// function foo() {
//     for (const key in arguments) {
//             console.log(key);
//         }
//     }

// foo(1, 2, 3, 4, 5);