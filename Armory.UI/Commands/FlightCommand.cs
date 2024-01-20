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
    public class FlightCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddFlight(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Flights.Add(form.Flight!);
                SaveChanges(db);
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.Flights.Find(id) is Flight flight)
            {
                var form = new AddFlight(db, flight);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db);
                }
            }
        }

        public void Remove(ArmoryContext db, List<int> ids)
        {
            //if (db.Flights.Find(ids) is Flight flight)
            //{
            //    db.Flights.Remove(flight);
            //    SaveChanges(db, "Данные успешно удалены.");
            //}
        }

        public void Import(ArmoryContext db, Integrator integrator)
        {
            //List<Flight>? flights = integrator.ImportFlights();

            //if (flights != null)
            //{
            //    db.Flights.AddRange(flights);
            //    SaveChanges(db, "Данные успешно добавлены.");
            //}
            //else
            //{
            //    var messageController = new MessageController();
            //    MessageBox.Show(messageController.GetMessage(integrator.Result));
            //}
        }
    }
}
