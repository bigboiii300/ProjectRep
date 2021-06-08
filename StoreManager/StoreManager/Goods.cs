using System;

namespace StoreManager
{
    public class Goods
    {
        // Название товара.
        public string Name;

        // Код товара.
        public uint Code;

        // Количество товара.
        public uint Quantity;

        // Цена товара.
        public uint Price;

        public Goods(string name, uint code, uint quantity, uint price)
        {
            Name = name;
            Code = code;
            Quantity = quantity;
            Price = price;
        }
    }
}