using System;
using System.Collections.ObjectModel;

namespace StoreManager
{
    public class DataGoods
    {
        public DataGoods(ObservableCollection<Goods> data)
        {
            data = Data;
        }

        // Коллекция товаров.
        public ObservableCollection<Goods> Data;
    }
}