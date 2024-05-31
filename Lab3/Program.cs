namespace Lab3;

// Объявляем класс Template
public class Template
{
    // Объявляем свойство Name для хранения имени шаблона
    public string Name { get; set; }

    // Объявляем свойство Cost для хранения имени шаблона
    public decimal Cost { get; set; }

    // Объявляем конструктор класса Template, инициализирующий свойства Name и Cost
    public Template(string name, decimal cost)
    {

        // Присваиваем значение параметра название свойству Name
        Name = name;

        // Присваиваем значение параметра стоимость свойству Cost
        Cost = cost;
    }
}

// Объявляем класс CMS, представляющий систему управления контентом
public class CMS
{

    // Объявляем свойство Templates для хранения списка шаблонов
    public List<Template> Templates { get; set; }

    // Объявляем конструктор класса CMS, инициализирующий свойство Templates пустым списком
    public CMS()
    {

        // Создаем новый список шаблонов
        Templates = new List<Template>();
    }

    // Объявляем метод AddTemplate, который добавляет шаблон
    public void AddTemplate(Template template)
    {

        // Добавляем переданный шаблон в список Templates
        Templates.Add(template);
    }

    // Объявляем метод PrintTemplates, который выводит информацию о шаблонах в консоль
    public void PrintTemplates()
    {

        // Выводим заголовок "Шаблоны:" в консоль
        Console.WriteLine("Шаблоны:");

        // Цикл foreach, который перебирает каждый шаблон в списке Templates
        foreach (var template in Templates)
        {

            // Выводим название и стоимость шаблона в консоль в формате "Название - Стоимость"
            Console.WriteLine($"{template.Name} - {template.Cost}");
        }
    }
}

// Объявляем класс Program
public class Program
{

    // Объявляем точку входа в программу с помощью статистического метода Main
    public static void Main(string[] args)
    {
        // Создаем экземпляр CMS с типом cms
        CMS cms = new CMS();

        // Добавляем шаблон с названием "Шаблон А" и стоимостью 440 в CMS
        cms.AddTemplate(new Template("Шаблон А", 440));

        // Добавляем шаблон с названием "Шаблон Б" и стоимостью 880 в CMS
        cms.AddTemplate(new Template("Шаблон Б", 880));

        // Вызываем метод PrintTemplates для вывода информации о шаблонах в консоль
        cms.PrintTemplates();

    }
}