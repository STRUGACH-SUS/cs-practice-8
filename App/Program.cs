

using App;

HttpClient http = new HttpClient();

CancellationTokenSource cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, _) =>
{ 
    cts.Cancel();
};

string uri = "https://seadox.ru/api/seadocs/9n";

using var task = ProcessWithFile.ProcessGetDataOfFile(uri, cts.Token, http);
await task;

