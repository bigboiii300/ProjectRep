using System;
using System.IO;

namespace Vegetable_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа представляет собой склад,в котором можно добавлять или удалять контейнеры с ящиками");
            Console.WriteLine("Поддерживается 2 режима ввода данных:");
            Console.WriteLine("1. Ввод данных с консоли при помощи команд.");
            Console.WriteLine("2. Ввод данных при считывании с файлов.");
            Console.WriteLine("Чтобы выйти из программы введите exit");
            Console.WriteLine("Нажмите любую кнопку для начала работы");
            Console.ReadKey();
            string select;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите один из двух режимов:");
                select = Console.ReadLine();
                // Отлавливаем ошибки.
                try
                {
                    // Используем для ввода команд.
                    switch (select)
                    {
                        // Режим работы с консоли.
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Вводите команды для добавления или удаления контейнеров или ящиков");
                            Console.WriteLine("Чтобы добавить введите add ");
                            Console.WriteLine("Чтобы удалить введите delete");
                            Console.WriteLine("Чтобы посмотреть информацию о складе введите store");
                            Console.WriteLine("Если забудете команды введите help");
                            Commands();
                            break;
                        // Режим работы с файлами.
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Считывается информация с трех файлов.");
                            Console.WriteLine("Необходимо вводить пути к файлам о складе,контейнере и ящике");
                            GetInfoFromFile();
                            break;
                        // Помощь пользователю.
                        case "help":
                            Console.Clear();
                            Console.WriteLine("Чтобы передавать информацию с консоли введите 1");
                            Console.WriteLine("Чтобы передавать информацию в файлах введите 2");
                            Console.WriteLine("Для выхода из программы введите exit");
                            Console.WriteLine("Для продолжения нажмите любую кнопку.");
                            Console.ReadKey();
                            break;
                        // Выход из программы.
                        case "exit":
                            select = "exit";
                            break;
                        // В случае неверного ввода.
                        default:
                            Console.Clear();
                            Console.WriteLine("Выбор некорректный! Повторите ввод!");
                            Console.WriteLine("Если вы не знаете что вводить введите help");
                            Console.WriteLine("Для продолжения нажмите любую кнопку.");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (select != "exit");
        }

        /// <summary>
        /// Использование команд.
        /// </summary>
        private static void Commands()
        {
            // Ввод параментров склада.
            int capacity, payment;
            Console.WriteLine(Environment.NewLine + "Введите вместимость склада:");
            int.TryParse(Console.ReadLine(), out capacity);
            Console.WriteLine(Environment.NewLine + "Введите плату за аренду склада:");
            int.TryParse(Console.ReadLine(), out payment);
            // Ловим ошибки.
            try
            {
                Store store = new Store(capacity, payment);
                Console.WriteLine(Environment.NewLine + "Введите команду! Если вы забыли список команд введите help");
                ActionsWithStore(store);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Commands();
            }
        }

        /// <summary>
        /// Действия,которые выполняют команды.
        /// </summary>
        /// <param name="store">Склад</param>
        private static void ActionsWithStore(Store store)
        {
            // Ввод команды.
            string command = Console.ReadLine();
            while (command != "back")
            {
                switch (command)
                {
                    // Добавление контейнера на склад.
                    case "add":
                        Console.Clear();
                        // Получение контейнера.
                        Container container = GetContainer();
                        // Добавление контейнера на склад.
                        store.AddContainer(container);
                        Console.WriteLine("Продолжайте вводить команды!");
                        break;
                    // Удаление контейнера со склада.
                    case "delete":
                        Console.Clear();
                        int index;
                        Console.WriteLine("Введите номер контейнера,который хотите удалить:");
                        int.TryParse(Console.ReadLine(), out index);
                        // Удаление контейнера со склада.
                        store.DeleteContainer(index);
                        Console.WriteLine(Environment.NewLine + "Контейнер успешно удален!");
                        Console.WriteLine("Продолжайте вводить команды!");
                        break;
                    // Вывод информации о складе.
                    case "store":
                        Console.Clear();
                        // Информация о складе.
                        store.InfoStore(store);
                        Console.WriteLine(Environment.NewLine + "Продолжайте вводить команды!");
                        break;
                    // Помощь пользователю.
                    case "help":
                        Console.Clear();
                        Console.WriteLine("Список команд:");
                        Console.WriteLine("Чтобы добавить контейнер введите add");
                        Console.WriteLine("Чтобы удалить контейнер введите delete");
                        Console.WriteLine("Чтобы посмотреть информацию о складе введите store");
                        Console.WriteLine("Для возврата к выбору режима введите back");
                        break;
                    // В случае неверного ввода команды.
                    default:
                        Console.Clear();
                        Console.WriteLine("Выбор некорректный! Повторите ввод! Нажмите Enter и попробуйте снова!");
                        Console.WriteLine("Введите help , если вы не знаете что нужно вводить");
                        break;
                }
                command = Console.ReadLine();
            }
        }

        /// <summary>
        /// Получение контейнера.
        /// </summary>
        /// <returns></returns>
        private static Container GetContainer()
        {
            // Количество ящиков.
            int countOfBox;
            Console.WriteLine("Введите количество ящиков в одном контейнере:");
            int.TryParse(Console.ReadLine(), out countOfBox);
            Container container = new Container(countOfBox);
            Console.Clear();
            // Добавление определенного количества ящиков.
            for (int i = 0; i < countOfBox; i++)
            {
                int weight;
                double price;
                Console.WriteLine("Введите цену за килограмм:");
                double.TryParse(Console.ReadLine(), out price);
                Console.WriteLine("Введите вес одного ящика:");
                int.TryParse(Console.ReadLine(), out weight);
                Box box = new Box(weight, price);
                // Добавление ящика в контейнер.
                container.AddBox(box);
                // Вывод информации о ящике.
                box.InfoBox(box);
            }
            container.InfoContainer(container);
            return container;
        }

        /// <summary>
        /// Получение данных с файлов.
        /// </summary>
        private static void GetInfoFromFile()
        {
            // Ловим ошибки.
            try
            {
                Console.WriteLine("Формат файла: ");
                Console.WriteLine("              3   (На первой строчке указывается вместимость)");
                Console.WriteLine("              500 (На второй указывается плата за аренду)");
                Console.WriteLine(Environment.NewLine + "Введите путь к файлу,в котором хранится информация о складе:");
                // Путь к файлу,который содержит инфу о складе.
                string pathStore = Console.ReadLine();
                string[] infoStore = File.ReadAllLines(pathStore);
                int capacity, payment;
                int.TryParse(infoStore[0], out capacity);
                int.TryParse(infoStore[1], out payment);
                Store store = new Store(capacity, payment);
                FileActions(store);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(Environment.NewLine + "Файла не существует! Проверьте правильность пути либо создайте файл." + Environment.NewLine);
                Console.WriteLine("Нажмите любую кнопу чтобы попробовать снова");
                Console.ReadKey();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine(Environment.NewLine + "Доступ к выбранному пути запрещен!" + Environment.NewLine);
                Console.WriteLine("Нажмите любую кнопу чтобы попробовать снова");
                Console.ReadKey();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(Environment.NewLine + "Информация в файле отсутствует либо не является корректной!" + Environment.NewLine);
                Console.WriteLine("Нажмите любую кнопу чтобы попробовать снова");
                Console.ReadKey();
            }

        }

        /// <summary>
        /// Получение контейнера из файла.
        /// </summary>
        /// <returns></returns>
        private static Container GetContainerFromFile()
        {
            Console.WriteLine("Формат файла: ");
            Console.WriteLine("              3   (На первой строчке указывается вместимость)");
            Console.WriteLine(Environment.NewLine + "Введите путь к файлу,в котором хранится информация о контейнере:");
            int countOfBox;
            // Путь к файлу,который содержит инфу о контейнере.
            string pathContainer = Console.ReadLine();
            string[] infoContainer = File.ReadAllLines(pathContainer);
            int.TryParse(infoContainer[0], out countOfBox);
            Container container = new Container(countOfBox);
            Console.Clear();
            Console.WriteLine("Формат файла: ");
            Console.WriteLine("              20   (На первой строчке указывается цена за килограмм)");
            Console.WriteLine("              8    (На второй строчке указывается вес ящика)");
            Console.WriteLine(Environment.NewLine + "Введите путь к файлу,в котором хранится информация о ящике:");
            // Путь к файлу,который содержит инфу о ящике.
            string path = Console.ReadLine();
            string[] infoBox = File.ReadAllLines(path);
            // Добавление ящиков в контейнер.
            for (int i = 1; i < countOfBox; i++)
            {
                int weight;
                double price;
                double.TryParse(infoBox[i - 1], out price);
                int.TryParse(infoBox[i], out weight);
                Box box = new Box(weight, price);
                // Добавляем ящик в контейнер.
                container.AddBox(box);
                // Вывод информации о ящике.
                box.InfoBox(box);
            }
            // Вывод информации о контейнере.
            container.InfoContainer(container);
            return container;
        }

        /// <summary>
        /// Действия с файлами.
        /// </summary>
        /// <param name="store">Склад</param>
        private static void FileActions(Store store)
        {
            Console.Clear();
            Console.WriteLine("Введите команду для дальнейшего пользования. Если вы не знаете команды введите help");
            string command = Console.ReadLine();
            while (command != "back")
            {
                // Команды для управления
                switch (command)
                {
                    // Добавление контейнера.
                    case "add":
                        Console.Clear();
                        Container container = GetContainerFromFile();
                        store.AddContainer(container);
                        Console.WriteLine("Продолжайте вводить команды!");
                        break;
                    // Удаление контейнера.
                    case "delete":
                        Console.Clear();
                        int index;
                        Console.WriteLine("Введите номер контейнера,который хотите удалить:");
                        int.TryParse(Console.ReadLine(), out index);
                        store.DeleteContainer(index);
                        Console.WriteLine(Environment.NewLine + "Контейнер успешно удален!");
                        Console.WriteLine("Продолжайте вводить команды!");
                        break;
                    // Информация о складе.
                    case "store":
                        Console.Clear();
                        store.InfoStore(store);
                        Console.WriteLine(Environment.NewLine + "Продолжайте вводить команды!");
                        break;
                    // Помощь пользователю.
                    case "help":
                        Console.Clear();
                        Console.WriteLine("Список команд:");
                        Console.WriteLine("Чтобы добавить контейнер введите add");
                        Console.WriteLine("Чтобы удалить контейнер введите delete");
                        Console.WriteLine("Чтобы посмотреть информацию о складе введите store");
                        Console.WriteLine("Для возврата к выбору режима введите back");
                        break;
                    // В случае неверного ввода.
                    default:
                        Console.Clear();
                        Console.WriteLine("Выбор некорректный! Повторите ввод! Нажмите Enter и попробуйте снова!");
                        Console.WriteLine("Введите help , если вы не знаете что нужно вводить");
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
