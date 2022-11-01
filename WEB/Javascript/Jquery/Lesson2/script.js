window.FontAwesomeConfig = { autoReplaceSvg: false };

const url = "https://api.openweathermap.org/data/2.5/weather?q=";
const apiKey = "5191fee1957155f779bfd029a4a97e18";

// Example 1

/*
$("#search-btn").on("click", async function () {
  let cityName = $(this).prev().val();

  let res = $.get(`${url}${cityName}&appid=${apiKey}`)
  .done(() =>
  {
    console.log('yes');
    console.log(res.responseJSON);
  })
  .fail(() => {
    console.log('No');
  });

  let new_elem = $(".city-elem").first().clone(true, true);

  new_elem.find("h1").text($(this).prev().val());

  new_elem.appendTo(".city-list");
});


*/

// Example 2
/*
$("#search-btn").on("click", async function () {
  let cityName = $(this).prev().val();

  let res = await $.get(`${url}${cityName}&appid=${apiKey}`).promise();

  console.log(res);

  let new_elem = $(".city-elem").first().clone(true, true);

  new_elem.find("h1").text($(this).prev().val());

  new_elem.appendTo(".city-list");
});
*/

// Example 3
/*

$("#search-btn").on("click", async function () {
  let cityName = $(this).prev().val();

  await $.get(`${url}${cityName}&appid=${apiKey}`, function(data){
    console.log();
  });
 

  let new_elem = $(".city-elem").first().clone(true, true);

  new_elem.find("h1").text($(this).prev().val());

  new_elem.appendTo(".city-list");
});
*/


$(".city-elem").on("click", function () {
  $(this).find(".city-desc").slideToggle();

  $(this).find("i").toggleClass("fa-plus").toggleClass("fa-minus");
});

