namespace App;

public class InterfaceConsole
{
    public static void WriteMessages(string id, string name, string description, string created, string updated, string children, string parent)
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