using System.Net.Http.Json;
using System.Text.Json;

namespace App;
/// <summary>
/// Служит для получения данных и их преобразования в файл.
/// </summary>
public class ConvertFormatOfFile
{
    /// <summary>
    /// Асинхронный метод для получения данных.
    /// </summary>
    async public static Task ProcessGetDataOfFile(string uri, CancellationToken cancellationToken, HttpClient http)
    { 
        var content = await http.GetFromJsonAsync<JsonElement>(uri, cancellationToken);
        
        JsonDocInfo doc =  new JsonDocInfo(content);
        
        InterfaceConsole.WriteInfoOfDoc(doc.Id, doc.Name, doc.Description, doc.Created, doc.Updated, doc.Children, doc.Parent);
    }
}