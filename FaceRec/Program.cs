//curl--location--request POST "https://%SPEECH_REGION%.stt.speech.microsoft.com/speech/recognition/conversation/cognitiveservices/v1?language=en-US&format=detailed" ^
//--header "Ocp-Apim-Subscription-Key: %SPEECH_KEY%" ^
//--header "Content-Type: audio/wav" ^
//--data-binary "@YourAudioFile.wav"

using System.Text;

var url = @"https://eastus.stt.speech.microsoft.com/speech/recognition/conversation/cognitiveservices/v1?language=en-US&format=detailed";
var subscriptionKey = "e8002308a52c4b06b80a65e446ba1237";

using var client = new HttpClient();

client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

using FileStream fs = new("Recording.wav", FileMode.Open);
var content = new StreamContent(fs);

using var response = await client.PostAsync(url, content);

response.EnsureSuccessStatusCode();

var responseBody = await response.Content.ReadAsStringAsync();

Console.WriteLine(responseBody);





