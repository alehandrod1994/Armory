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
    public class ActCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddAct(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Acts.Add(form.Act!);
                SaveChanges(db, "Данные успешно сохранены.");
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.Acts.Find(id) is Act act)
            {
                var form = new AddAct(db, act);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db, "Данные успешно изменены.");
                }
            }
        }
     
        public void Remove(ArmoryContext db, int id)
        {
            if (db.Acts.Find(id) is Act act)
            {
                db.Acts.Remove(act);
                SaveChanges(db, "Данные успешно удалены.");
            }
        }

        public void Import(ArmoryContext db)
        {
            string path = ImportDataFromExcel();

            if (path != "")
            {
                var integrator = new Integrator(db, path);
                List<Act>? acts = integrator.ImportActData();

                if (acts != null)
                {
                    db.Acts.AddRange(acts);
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
