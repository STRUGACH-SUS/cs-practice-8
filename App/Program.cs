using App;

HttpClient http = new HttpClient();

CancellationTokenSource cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, _) =>
{ 
    InterfaceConsole.WriteMessage(InterfaceConsole.cancel);
    cts.Cancel();
};

InterfaceConsole.WriteMessage(InterfaceConsole.firstQuestion);
string uri = $"{InterfaceConsole.uriStart}{Console.ReadLine().Trim()}";
try
{
    if (!Uri.TryCreate(uri, UriKind.Absolute, out _))
    {
        throw new Exception();
    }
}
catch
{
    InterfaceConsole.WriteMessage(InterfaceConsole.errorInUri);
}

try
{
    InterfaceConsole.WriteMessage(InterfaceConsole.startGetData);
    using var task = ProcessWithFile.ProcessGetDataOfFile(uri, cts.Token, http);
    await task;
    InterfaceConsole.WriteMessage(InterfaceConsole.finalGetData);
}
catch
{
    InterfaceConsole.WriteMessage(InterfaceConsole.error);
    throw;
}
