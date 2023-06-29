using Armory.BL.Controller;
using Armory.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.UI.Commands
{
    public class AirportCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddAirport(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Airports.Add(form.Airport!);
                SaveChanges(db, "Данные успешно сохранены.");
            }

        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.Airports.Find(id) is Airport airport)
            {
                var form = new AddAirport(db, airport);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db, "Данные успешно изменены.");
                }
            }
        }      

        public void Remove(ArmoryContext db, int id)
        {
            if (db.Airports.Find(id) is Airport airport)
            {
                db.Airports.Remove(airport);
                SaveChanges(db, "Данные успешно удалены.");
            }
        }

        public void Import(ArmoryContext db)
        {
            string path = ImportDataFromExcel();

            if (path != "")
            {
                var integrator = new Integrator(db, path);
                List<Airport>? airports = integrator.ImportAirportData();

                if (airports != null)
                {
                    db.Airports.AddRange(airports);
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
