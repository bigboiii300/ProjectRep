using System;

namespace Vegetable_Store
{
    class Box
    {
        // Для расчета повреждения ящика.
        static Random r = new Random();
        // Вес ящика.
        public int Weight { get; set; }
        // Повреждения ящика.
        public double Damage { get; set; }
        // Цена за килограмм.
        public double Price { get; set; }

        public Box(int weight, double price)
        { 
            // Проверка на вводимый вес ящика.
            if (weight > 0)
            {
                Weight = weight;
            }
            else
                throw new ArgumentException("Вес не может быть меньше 0! Либо вес превышает максимальное значение! ");
            // Проверка на вводимую цену за килограмм.
            if (price > 0)
            {
                // Рандомим нанесенный ущерб ящику.
                Damage = r.NextDouble() / 2;
                // Проверка чтобы наша сумма не умножалась на 0.
                if (Damage > 0)
                {
                    Price = (price * Weight) - (price * Weight * Damage);
                }
            }
            else
                throw new ArgumentException("Стоимость не может быть меньше 0");
        }

        /// <summary>
        /// Вывод информации о ящике.
        /// </summary>
        /// <param name="box">Ящик</param>
        public void InfoBox(Box box)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Вес ящика:   \t {box.Weight}");
            Console.WriteLine($"Повреждение: \t {box.Damage}");
            Console.WriteLine($"Стоимость:   \t {box.Price}");
            Console.WriteLine(Environment.NewLine);
        }

    }
}
