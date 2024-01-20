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
    public class AirportCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddAirport(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Airports.Add(form.Airport!);
                SaveChanges(db);
            }

        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.Airports.Find(id) is Airport airport)
            {
                var form = new AddAirport(db, airport);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db);
                }
            }
        }

        public void Remove(ArmoryContext db, List<int> ids)
        {
            if (db.Airports.Find(ids[0]) is Airport)
            {
                List<Airport> airports = new();

                foreach (int id in ids)
                {
                    airports.Add(db.Airports.Find(id)!);
                }

                db.Airports.RemoveRange(airports);
                SaveChanges(db);              
            }
        }

        public void Import(ArmoryContext db, Integrator integrator)
        {
            //Dictionary<string, string> airportColumns = new()
            //{
            //    {"Name", "Аэропорт"},
            //    {"City", "Город"}
            //};


            List<Airport>? airports = integrator.ImportAirports();

            if (airports != null)
            {
                db.Airports.AddRange(airports);
                SaveChanges(db);
                MessageBox.Show("Данные успешно добавлены");
            }
            else
            {
                var messageController = new MessageController();
                MessageBox.Show(messageController.GetMessage(integrator.Result));
            }
            
        }

    }
}
