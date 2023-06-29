using Armory.BL.Controller;
using Armory.BL.Model;
using Armory.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.UI.Commands
{
    public class CityCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddCity(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Cities.Add(form.City!);
                SaveChanges(db, "Данные успешно сохранены.");
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.Cities.Find(id) is City city)
            {
                var form = new AddCity(db, city);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db, "Данные успешно изменены.");
                }
            }
        }

        public void Remove(ArmoryContext db, int id)
        {
            if (db.Cities.Find(id) is City city)
            {
                db.Cities.Remove(city);
                SaveChanges(db, "Данные успешно удалены.");
            }
        }

        public void Import(ArmoryContext db)
        {
            string path = ImportDataFromExcel();

            if (path != "")
            {
                var integrator = new Integrator(db, path);
                List<City>? cities = integrator.ImportCityData();

                if (cities != null)
                {
                    db.Cities.AddRange(cities);
                    SaveChanges(db, "Данные успешно добавлены.");
                }
                else
                {
                    var messageController = new MessageController();
                    MessageBox.Show(messageController.GetMessage(integrator.Result));
                }
            }
        }
    }
}
