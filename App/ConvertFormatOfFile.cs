using System.Net.Http.Json;
using System.Text.Json;

namespace App;

public class ConvertFormatOfFile
{
    async public static Task ProcessGetDataOfFile(string uri, CancellationToken cancellationToken, HttpClient http)
    { 
        var content = await http.GetFromJsonAsync<JsonElement>(uri, cancellationToken);
        
        JsonDocInfo doc =  new JsonDocInfo(content);
        
        InterfaceConsole.WriteInfoOfDoc(doc.Id, doc.Name, doc.Description, doc.Created, doc.Updated, doc.Children, doc.Parent);
    }
}