using System;
using System.Collections.Generic;

namespace Vegetable_Store
{
    class Store
    {
        // Вместительность склада.
        int capacity;
        // Цена за аренду склада.
        int payment;
        // Счетчик для добавления контейнеров.
        int count;
        // Цена всех контейнеров.
        double sumOfContainer;

        // Список контейнеров на складе.
        List<Container> store = new List<Container>();

        public Store(int _capacity, int _payment)
        {
            // Проверка на вместительность.
            if (_capacity <= 0)
                throw new ArgumentException("Вместительность не может быть меньше либо равна 0");
            capacity = _capacity;

            // Проверка на аренду.
            if (_payment <= 0)
                throw new ArgumentException("Плата за хранение не может быть меньше либо равна 0");
            payment = _payment;
            count = 0;
            sumOfContainer = 0;
        }

        /// <summary>
        /// Добавление контейнера на склад.
        /// </summary>
        /// <param name="container">Контейнер</param>
        public void AddContainer(Container container)
        {
            count++;
            // Проверка на рентабельность и вместимость.
            if ((payment <= container.GetPrice()) && (capacity >= count))
            {
                store.Add(container);
                sumOfContainer += container.GetPrice();
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Контейнер не может быть помещен на склад!");
                Console.WriteLine("Аренда превышает стоимость контейнера,либо на складе просто нет места!");
                Console.WriteLine("Удалите контейнер и поместите на склад новый.");
                count--;
                return;
            }
        }

        /// <summary>
        /// Удаление контейнера со склада.
        /// </summary>
        /// <param name="index">Номер контейнера</param>
        public void DeleteContainer(int index)
        {
            // Удаление контейнера по его номеру.
            store.Remove(store[index - 1]);
            // Минусуем счетчик.
            count--;
            // Убираем цену удаленного контейнера.
            sumOfContainer -= store[index - 1].GetPrice();
        }

        /// <summary>
        /// Информация о складе.
        /// </summary>
        /// <param name="store">Склад</param>
        public void InfoStore(Store store)
        {
            Console.WriteLine($"Вместимость склада:         \t{capacity}");
            Console.WriteLine($"Количество контейнеров:     \t{count}");
            Console.WriteLine($"Стоимость всех контейнеров: \t{sumOfContainer}");
            Console.WriteLine($"Стоимость аренды:           \t{payment}");
        }
    }

}
