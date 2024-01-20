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
    public class PlaneCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddPlane(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Planes.Add(form.Plane!);
                SaveChanges(db);
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.Planes.Find(id) is Plane plane)
            {
                var form = new AddPlane(db, plane);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db);
                }
            }
        }

        public void Remove(ArmoryContext db, List<int> ids)
        {
            //if (db.Planes.Find(ids) is Plane plane)
            //{
            //    db.Planes.Remove(plane);
            //    SaveChanges(db, "Данные успешно удалены.");
            //}
        }

        public void Import(ArmoryContext db, Integrator integrator)
        {
            //List<Plane>? planes = integrator.ImportPlanes();

            //if (planes != null)
            //{
            //    db.Planes.AddRange(planes);
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
