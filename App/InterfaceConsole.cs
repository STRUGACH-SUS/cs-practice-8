namespace App;

public class InterfaceConsole
{
    public const string uriStart = "https://seadox.ru/api/seadocs/",
        firstQuestion = """Введите ID документа по запросу https://seadox.ru/api/seadocs/{ID} (Пример: z8e ): """,
        cancel = "Отмена операции",
        startGetData = "Получение данных",
        finalGetData = "Данные получены",
        error = "Произошла оошибка",
        errorInUri = "Данного Uri не существует";
    
    public static void WriteMessage(string key)
    {
        Console.WriteLine(key);
    }
    
    public static void WriteInfoOfDoc(string id, string name, string description, string created, string updated, string children, string parent)
    {
        Console.WriteLine($$"""
                            ID документа : {{id}} 
                            Имя документа : {{name}}
                            Описание : {{description}}
                            Дата создания : {{created}}
                            Дата обновления : {{updated}}
                            Дочерние документы : {{children}}
                            Родительские документы : {{parent}}
                            """ );
    }
}