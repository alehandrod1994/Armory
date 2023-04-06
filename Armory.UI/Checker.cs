using Armory.BL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Armory.UI
{
    public abstract class Checker
    {
        public static List<Control> CheckControlsOnNull(Form form)
        {
            List<Control> controls = new();

            foreach (Control control in form.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    // TODO: Удаление лишних пробелов:
                    // tbAirportName.Text = tbAirportName.Text.Replace(" ", "");

                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        controls.Add(control);                       
                    }
                }
            }

            // if (ParseDate(tbDate.Text) == null)
            // {
            // tbDate.Color = Color.Red;
            // MessageBox.Show("Заполните все поля.");
            // return false;
            // }
            // if (ParseDate(tbPassportWhenGiven.Text) == null)
            // {
            // tbPassportWhenGiven.Color = Color.Red;
            // MessageBox.Show("Заполните все поля.");
            // return false;
            // }

            // if (ParseInt(tbActNumber.Text) == null)
            // {
            // tbActNumber.Color = Color.Red;
            // MessageBox.Show("Заполните все поля.");
            // return false;
            // }			
            // if (ParseInt(tbPassportNumber.Text) == null)
            // {
            // tbPassportNumber.Color = Color.Red;
            // MessageBox.Show("Заполните все поля.");
            // return false;
            // }
            // if (ParseInt(tbPassportSeria.Text) == null)
            // {
            // tbPassportSeria.Color = Color.Red;
            // MessageBox.Show("Заполните все поля.");
            // return false;
            // }
            // if (ParseInt(cbFlightNumbers.Text) == null)
            // {
            // cbFlightNumbers.Color = Color.Red;
            // MessageBox.Show("Заполните все поля.");
            // return false;
            // }
            // if (ParseInt(cbPlaneNumbers.Text) == null)
            // {
            // cbPlaneNumbers.Color = Color.Red;
            // MessageBox.Show("Заполните все поля.");
            // return false;
            // }
            // if (ParseInt(tbAmmunitionCount.Text) == null)
            // {
            // tbAmmunitionCount.Color = Color.Red;
            // MessageBox.Show("Заполните все поля.");
            // return false;
            // }

            // if (ParseDouble(tbAmmunitionWeight.Text) == null)
            // {
            // tbAmmunitionCount.Color = Color.Red;
            // MessageBox.Show("Заполните все поля.");
            // return false;
            // }



            //if (!MarkOnValid<DateTime>(tbDate))
            //{
            //    return false;
            //}
            //if (!MarkOnValid<DateTime>(tbPassportWhenGiven))
            //{
            //    return false;
            //}
            //if (!MarkOnValid<int>(tbActNumber))
            //{
            //    return false;
            //}
            //if (!MarkOnValid<int>(tbPassportNumber))
            //{
            //    return false;
            //}
            //if (!MarkOnValid<int>(tbPassportSeria))
            //{
            //    return false;
            //}
            //if (!MarkOnValid<int>(tbAmmunitionCount))
            //{
            //    return false;
            //}
            //if (!MarkOnValid<double>(tbAmmunitionWeight))
            //{
            //    return false;
            //}

            return controls;

            // TODO: Открытие вкладки с неправильно заполненным полем.
        }

        public static IEnumerable<Control> ParseIntControls(List<Control> controls) 
        {
            foreach(Control control in controls) 
            {
                if (ParseInt(control.Text) == null)
                {
                    yield return control;
                }
            }
        }

        //private bool MarkOnValid<T>(Control control)
        //    where T : class
        //{
        //    if (Parse<T>(control.Text) == null)
        //    {
        //        var parent = control.Parent as Panel;
        //        OpenTab(parent);
        //        control.Color = Color.Red;
        //        MessageBox.Show("Заполните все поля.");
        //        return false;
        //    }

        //    return true;
        //}

        public static int? ParseInt(string value)
        {
            // TODO: Удаление лишних пробелов.

            if (int.TryParse(value, out int result))
            {
                return result;
            }

            return null;
        }

        public static double? ParseDouble(string value)
        {
            // TODO: Удаление лишних пробелов.

            if (double.TryParse(value, out double result))
            {
                return result;
            }

            return null;
        }

        public static DateTime? ParseDateTime(string value)
        {
            // TODO: Удаление лишних пробелов.

            if (DateTime.TryParse(value, out DateTime result))
            {
                return result;
            }

            return null;
        }


        // Добавление данных в другие таблицы, если данные новые, и возвращает элемент:
        public static T EnsureHavingItem<T>(ArmoryContext db, DbSet<T> set, T item)
            where T : class
        {
            // Возможно set.Load();
            var match = set.Local.Any(s => s.Equals(item));

            if (!match)
            {
                set.Add(item);
                db.SaveChanges();
                return set.Local.Last();
            }

            return item;
        }

        // Проверка, есть ли в базе уже такой объект:
        public static bool CheckOnDublicate<T>(DbSet<T> set, string value) 
            where T : class
        {
            var match = set.Local.Any(s => s.ToString() == value);

            if (match)
            {
                MessageBox.Show("Такая запись уже есть.");
                return true;
            }

            return false;
        }
    }
}
