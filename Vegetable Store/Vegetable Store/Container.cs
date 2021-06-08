using System;
using System.Collections.Generic;

namespace Vegetable_Store
{
    class Container
    {
        // Для расчета максимального веса контейнера.
        static Random r = new Random();
        // Для хранения ящиков в контейнере.
        List<Box> container = new List<Box>();
        
        // Количество ящиков.
        int countBox;
        // Максимальный вес,который получается при помощи рандома.
        int maxWeight;
        // Суммарный вес ящиков в контейнере,что является весом данного контейнера.
        int sumWeight;
        // Счетчик для подсчета ящиков.
        int count;

        public Container(int _countBox)
        {
            // Проверка на колчиство ящиков.
            if (_countBox <= 0)
            {
                throw new ArgumentException("Количество не может быть меньше либо равно 0");
            }
            else
                countBox = _countBox;
            maxWeight = r.Next(50, 1001);
            sumWeight = 0;
            count = 0;
        }

        /// <summary>
        /// Нахождение цены контейнера.
        /// </summary>
        /// <returns>Цена контейнера</returns>
        public double GetPrice()
        {
            double containerPrice = 0;
            // Суммируем цену всех ящиков для нахождения цены контейнера.
            foreach (var box in container)
            {
                containerPrice += box.Price;
            }
            return containerPrice;
        }

        /// <summary>
        /// Добавление ящика в контейнер.
        /// </summary>
        /// <param name="box">Ящик</param>
        public void AddBox(Box box)
        {
            // Нахождение веса контейнера.
            sumWeight += box.Weight;
            count++;
            // Проверка на переполнение и превышение максимального веса.
            if (sumWeight <= maxWeight && count <= countBox)
                container.Add(box);
            else
            {
                Console.WriteLine("Ящик не может быть помещен в контейнер!");
                Console.WriteLine("Вес ящиков превышает максимальный вес, либо в контейнере просто нет места!");
                sumWeight -= box.Weight;
                count--;
            }
        }

        /// <summary>
        /// Вывод информации о контейнере.
        /// </summary>
        /// <param name="container">Контейнер</param>
        public void InfoContainer(Container container)
        {
            Console.WriteLine(Environment.NewLine + "Информация о контейнере:");
            Console.WriteLine($"Максимальный вес:  \t{container.maxWeight}");
            Console.WriteLine($"Вес контейнера:    \t{container.sumWeight}");
            Console.WriteLine($"Количество ящиков: \t{container.countBox}");
            Console.WriteLine($"Цена контейнера:   \t{container.GetPrice()}");
        }
    }
}
