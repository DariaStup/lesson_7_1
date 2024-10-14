using static lesson_7_1.Program;

namespace lesson_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла:");
            string path = @".\" + Console.ReadLine() + ".txt";
                     
            void Info() //показ информации о файле
            {
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Имя файла: {fileInfo.Name}");
                    Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
                    Console.WriteLine($"Размер: {fileInfo.Length}");
                }
            }
            void WriteText()
            {
                Console.WriteLine("Введите текст для записи в файл:");
                string originalText = Console.ReadLine();
                // запись строки
                File.WriteAllText(path, originalText);
            }
            void WriteNextText()
            {
                Console.WriteLine("Введите текст для записи в файл:");
                // дозапись в конец файла
                File.AppendAllText(path, "\n" + Console.ReadLine());
            }
            void ReadText()
            {
                // чтение файла
                string fileText = File.ReadAllText(path);
                Console.WriteLine(fileText);
            }
            void Doing()//меню для файла
            {
                while (true)
                {
                    Console.WriteLine($"Что будем делать?:\nЗаписать в блокнот заново - 1 \nДописать в блокнот - 2\nПрочитать - 3\nПосмотреть информацию - 4\nВернуться к выбору файла - 5");
                    string? input1 = Console.ReadLine();
                    int MenusPoint;
                    if (int.TryParse(input1, out MenusPoint))
                    {
                        switch (MenusPoint)
                        {
                            case 1:
                                WriteText();
                                break;
                            case 2:
                                WriteNextText();
                                break;
                            case 3:
                                ReadText();
                                break;
                            case 4:
                                Info();
                                break;
                            case 5:
                                ChooseFile();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод.");
                    }
                }
            }
            void ChooseFile() //метод выбора файла
            {
                Console.WriteLine("Введите имя файла:");
                string path = @".\" + Console.ReadLine() + ".txt";
                Doing();
            }
            Doing();
        }
    }
}