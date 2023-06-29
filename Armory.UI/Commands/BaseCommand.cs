using Armory.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.UI.Commands
{
    public abstract class BaseCommand
    {
        protected static void SaveChanges(ArmoryContext db, string message)
        {
            try 
            {
                db.SaveChanges();
                MessageBox.Show(message);
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить данные.");
            }
        }

        protected static string ImportDataFromExcel()
        {
            string path = "";

            OpenFileDialog ofd = new()
            {
                FileName = "",
                Filter = "Документ Excel (*.xls; *xlsx) | *.xls; *.xlsx",
                Title = "Выберите файл для импорта"
            };

            if (ofd.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    path = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Недопустимый формат файла.");
                }
            }

            return path;
        }
    }
}
