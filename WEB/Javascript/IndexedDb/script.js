window.FontAwesomeConfig = { autoReplaceSvg: false };

const url = "https://api.openweathermap.org/data/2.5/weather?q=";
const apiKey = "5191fee1957155f779bfd029a4a97e18";

function capitalize(val) {
  let res = val.charAt(0).toUpperCase() + val.slice(1);
  return res;
}

$(window).on("load", function () {
  let conn = indexedDB.open("forecast", 1);

  $(conn).on("success", function () {
    let res = conn.result;

    $(res).on("versionchange", function () {
      console.log("This version is old");

      res.close();
    });

    $(conn).on("upgradeneeded", function () {
      const store = res.createObjectStore("forecast", { keyPath: "cityInfo" }); // create table
  
      store.createIndex("temp", "temp", { unique: false }); // field
      store.createIndex("name", "name", { unique: false }); // field
      store.createIndex("country", "country", { unique: false }); // field
  
      store.put("cityInfo", {
        temp: "20",
        name: "baku",
        country: "az",
      });
    });

    
    console.log(conn);
  
  });
});

$("#search-btn").on("click", async function () {
  let cityName = $(this).prev().val();
  let res = await $.get(
    `${url}${cityName}&appid=${apiKey}&units=metric`
  ).promise();
  console.log(res);
  let new_elem = $(".city-elem").first().clone(true, true);

  new_elem.find("h1").text(capitalize($(this).prev().val()));
  new_elem.find("#temp").text(`Temperature: ${res.main.temp}℃`);
  new_elem.find("#country").text(`Country: ${res.sys.country}`);

  new_elem.appendTo(".city-list");
});

$(".city-elem").on("click", function () {
  $(this).find(".city-desc").slideToggle();

  $(this).find("i").toggleClass("fa-plus").toggleClass("fa-minus");
});
