// let btn = document.querySelector('button');
// let check = true;

// btn.addEventListener('click', function() {
//     if (check) {
//         this.classList.remove('btn-light');
//         this.classList.add('btn-dark');
//         check = false;
//     }   else {
//         this.classList.remove('btn-dark');
//         this.classList.add('btn-light');
//         check = true;
//     }
// });

// $("button").click(function () {
//   $("button").toggleClass(function () {
//     if ($(this).is(".btn-light")) {
//       return "btn-dark";
//     } else {
//       return "btn-light";
//     }
//   });
// });


// $("button").on('click', function () {
//   $("button").toggleClass(function () {
//     if ($(this).is(".btn-light")) {
//       return "btn-dark";
//     } else {
//       return "btn-light";
//     }
//   });
// });

$("button").on('click', function () {
   $('.my-text').fadeToggle();
  });

// $('.my-text').css('color', 'blue');

// $('.my-text').css({
//     'color' : 'blue',
//     'background-color' : 'red'
//  });
