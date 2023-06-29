using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.BL.Model
{
    public abstract class DbHelper
    {
        // Добавление данных в другие таблицы, если данные новые, и возвращает элемент:
        public static T EnsureHasItem<T>(DbSet<T> set, T item)
            where T : class
        {
            var foundItem = set.Local.FirstOrDefault(s => s.ToString() == item.ToString());

            if (foundItem != null)
            {
                return foundItem;
            }

            return item;
        }

        //// Проверка, есть ли в базе уже такой объект:
        //public static bool CheckOnDublicate<T>(DbSet<T> set, string value)
        //    where T : class
        //{
        //    var match = set.Local.Any(s => s.ToString() == value);

        //    if (match)
        //    {
        //        MessageBox.Show("Такая запись уже есть.");
        //        return true;
        //    }

        //    return false;
        //}
    }
}
