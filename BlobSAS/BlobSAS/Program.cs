#region GET
/*
using System.Net;
using System.Text;

UploadFileToAzureBlobStorage("Tamerlan dvoecnik", "tamerlan.txt");

void UploadFileToAzureBlobStorage(string content, string fileName)
{
    string sasToken = "sp=racwl&st=2023-04-27T17:24:12Z&se=2023-04-28T01:24:12Z&sv=2021-12-02&sr=c&sig=bItH9eQEjcEcO2xYGDkFTLBADOKyVW%2FXn6Y0ZpG3MGY%3D";
    string storageAccount = "nightcall";
    string containerName = "images";
    string blobName = fileName;

    string method = "GET";
    string sampleContent = content;
    int contentLength = Encoding.UTF8.GetByteCount(sampleContent);

    string requestUri = $"https://{storageAccount}.blob.core.windows.net/{containerName}/{blobName}?{sasToken}";

    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri);
    request.Method = method;
    request.ContentType = "text/plain; charset=UTF-8";
    request.ContentLength = contentLength;
    request.Headers.Add("x-ms-blob-type", "BlockBlob");

    using Stream requestStream = request.GetRequestStream();
    using FileStream fs = new("tamerlan.txt", FileMode.CreateNew);
    
    byte[] buffer = new byte[1024];
    
    requestStream.Read(buffer, 0, buffer.Length);
    fs.Write(buffer, 0, buffer.Length);

    using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
    {
        if (resp.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Success");
        }
        else
        {
            Console.WriteLine($"Fail: {resp.StatusCode}");
        }
    }
}
*/
#endregion

#region PUT
/*
using System.Net;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System;


await DownloadFileFromAzureBlobStorage("Yoda-HTML.png");

async Task DownloadFileFromAzureBlobStorage(string fileName)
{
    string connectionString = "DefaultEndpointsProtocol=https;AccountName=nightcall;AccountKey=vE3Z13s8NKpxFftJOgGweG5VM+CrR3qYM0ho80Tpg8gYaMSC3n156klcS2wMWeZsXJPY9ETFv/r1+ASt9H7jkw==;EndpointSuffix=core.windows.netDefaultEndpointsProtocol=https;AccountName=nightcall;AccountKey=vE3Z13s8NKpxFftJOgGweG5VM+CrR3qYM0ho80Tpg8gYaMSC3n156klcS2wMWeZsXJPY9ETFv/r1+ASt9H7jkw==;EndpointSuffix=core.windows.net";
    string storageAccount = "nightcall";
    string containerName = "images";
    string blobName = fileName;

    string requestUri = $"https://{storageAccount}.blob.core.windows.net/{containerName}/{blobName}?{connectionString}";

    using var httpClient = new HttpClient();

    using var stream = await httpClient.GetStreamAsync(requestUri);

    using var downloadedFileStream = new FileStream(fileName, FileMode.Create);

    await stream.CopyToAsync(downloadedFileStream);

    Console.WriteLine("File downloaded successfully.");
}

*/
#endregion



