namespace App;
/// <summary>
/// Служит для вывода всяких заготовленных сообщений.
/// </summary>
public class InterfaceConsole
{
    //Это и есть заготовки.
    public const string UriStart = "https://seadox.ru/api/seadocs/",
        FirstQuestion = """Введите ID документа по запросу https://seadox.ru/api/seadocs/{ID} (Пример: z8e ): """,
        Cancel = "Отмена операции",
        StartGetData = "Получение данных",
        FinalGetData = "Данные получены",
        Error = "Произошла оошибка",
        ErrorInUri = "Данного Uri не существует";
    
    /// <summary>
    /// Выводит сообщение по его "ключу".
    /// </summary>
    public static void WriteMessage(string key)
    {
        Console.WriteLine(key);
    }
    
    /// <summary>
    /// Выводит всю нужную информацию о документе.
    /// </summary>
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