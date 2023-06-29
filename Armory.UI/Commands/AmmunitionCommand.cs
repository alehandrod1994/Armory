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
    public class AmmunitionCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddAmmunition(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Ammunitions.Add(form.Ammunition!);
                SaveChanges(db, "Данные успешно сохранены.");
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.Ammunitions.Find(id) is Ammunition ammunition)
            {
                var form = new AddAmmunition(db, ammunition);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db, "Данные успешно изменены.");
                }
            }
        }

        public void Remove(ArmoryContext db, int id)
        {
            if (db.Ammunitions.Find(id) is Ammunition ammunition)
            {
                db.Ammunitions.Remove(ammunition);
                SaveChanges(db, "Данные успешно удалены.");
            }
        }

        public void Import(ArmoryContext db)
        {
            string path = ImportDataFromExcel();

            if (path != "")
            {
                var integrator = new Integrator(db, path);
                List<Ammunition>? ammunitions = integrator.ImportAmmunitionData();

                if (ammunitions != null)
                {
                    db.Ammunitions.AddRange(ammunitions);
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
