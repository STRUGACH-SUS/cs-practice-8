using App;

HttpClient http = new HttpClient();

CancellationTokenSource cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, _) =>
{ 
    InterfaceConsole.WriteMessage(InterfaceConsole.Cancel);
    cts.Cancel();
};

InterfaceConsole.WriteMessage(InterfaceConsole.FirstQuestion);
string uri = $"{InterfaceConsole.UriStart}{Console.ReadLine().Trim()}";
try
{
    if (!Uri.TryCreate(uri, UriKind.Absolute, out _))
    {
        throw new Exception();
    }
}
catch
{
    InterfaceConsole.WriteMessage(InterfaceConsole.ErrorInUri);
}

try
{
    InterfaceConsole.WriteMessage(InterfaceConsole.StartGetData);
    using var task = ConvertFormatOfFile.ProcessGetDataOfFile(uri, cts.Token, http);
    await task;
    InterfaceConsole.WriteMessage(InterfaceConsole.FinalGetData);
}
catch
{
    InterfaceConsole.WriteMessage(InterfaceConsole.Error);
    throw;
}
