HttpClient client = new();


var json = await client.GetStringAsync(new Uri("https://localhost:7007/api/Products"));


Console.WriteLine(json);
