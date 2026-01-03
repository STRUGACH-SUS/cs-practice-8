using System.Text.Json;

namespace App;

public class JsonDocInfo
{
    public string Id { get; }
    public string Name { get; }
    public string Description { get; }
    public string Created { get; }
    public string Updated { get; }
    public string Children { get; }
    public string Parent { get; }
    public JsonDocInfo(JsonElement json)
    {
        json.TryGetProperty("id", out var id);
        Id = id.GetString()!;
        
        json.TryGetProperty("name", out var name);
        Name = name.GetString()!=null? name.GetString()! : "имя документа отсутствует";
        
        json.TryGetProperty("description", out var description);
        Description = description.GetString()!=null? description.GetString()! : "описание документа отсутствует";
        
        json.TryGetProperty("createdAt", out var created);
        Created = created.GetDateTime().ToString()!=null? created.GetDateTime().ToString("dd-MM-yyyy HH:mm:ss"): "отсутствует дата создания документа";
        
        json.TryGetProperty("updatedAt", out var updated);
        Updated = updated.GetDateTime().ToString()!=null? updated.GetDateTime().ToString("dd-MM-yyyy HH:mm:ss"): "отсутствует дата обновления документа или документ не обновлялся";
        
        json.TryGetProperty("children", out var children);
        var childrenP = "";
        foreach (var idOfChild in children.EnumerateArray())
        {
            childrenP += idOfChild.GetProperty("id").GetString()+" ";
        }
        Children = childrenP!=null? childrenP: "отсутствуют дочерние документы";
        
        json.TryGetProperty("parentId", out var parent);
        Parent = parent.GetString()!=null? parent.GetString()!: "отсутствуют родительские документы";
    }
}