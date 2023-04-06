using Armory.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.UI.Commands
{
    public class AirportCommand : ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddAirport(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Airports.Add(form.Airport!);
                db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены.");
            }

        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.Airports.Find(id) is Airport airport)
            {
                var form = new AddAirport(db, airport);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно изменены.");
                }
            }
        }

        public void Remove(ArmoryContext db, int id)
        {
            if (db.Airports.Find(id) is Airport airport)
            {
                db.Airports.Remove(airport);
                db.SaveChanges();
                MessageBox.Show("Данные успешно удалены.");
            }
        }
    }
}
