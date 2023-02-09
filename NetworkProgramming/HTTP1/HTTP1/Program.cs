// http - hyper text transfer protocol 
// https - secure hyper text transfer protocol 

// - header (main part) 
// - continuation 
// - body 

// WebClient - Base form of any request to web server.

using System.Net;
using System.Text;

// WebClient client = new();

// var data = client.DownloadData(@"https://habr.com/ru/post/560572/");
// var data = client.DownloadString(@"https://habr.com/ru/post/560572/");

// Console.WriteLine(Encoding.ASCII.GetString(data));
// Console.WriteLine(data);



// HttpWebRequest 
// HttpWebResponse
// HttpRequestMessage
// HttpResponseMessage

// HttpWebRequest request = WebRequest.Create(@"https://habr.com/ru/post/560572/") as HttpWebRequest;
// HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://habr.com/ru/post/560572/");
// HttpWebResponse response = request.GetResponse() as HttpWebResponse;

// using var stream = response.GetResponseStream();

// using var reader = new StreamReader(stream);

// var data = reader.ReadToEnd();

// Console.WriteLine(data);


// Get
// Put
// Post


// Get 

// HttpClient client = new();
// var result = await client.GetStringAsync(@"https://api.openweathermap.org/data/2.5/weather?q=baku&appid=5191fee1957155f779bfd029a4a97e18&units=metric");
//
// Console.WriteLine(result);
//
// HttpContent content = new StringContent(result);


// Post

// HttpClient client2 = new HttpClient();
//
// HttpResponseMessage response = await client2.PostAsync(new Uri("https://httpbin.org/post"), new StringContent("Hello"));
//
// Console.WriteLine(response);

// Get

// HttpClient client3 = new();
// var request = await client3.GetAsync(new Uri(@"https://httpbin.org/anything"));
//
// var response = await request.Content.ReadAsStreamAsync();
// Console.WriteLine(response);
//
// using var data = new StreamReader(response);
//
// Console.WriteLine(await data.ReadToEndAsync());

// HttpClient client3 = new();
// var request = await client3.GetStringAsync(new Uri(@"https://httpbin.org/anything"));
//
// Console.WriteLine(request);


