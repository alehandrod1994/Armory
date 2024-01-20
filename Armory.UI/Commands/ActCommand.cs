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
                SaveChanges(db);
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.Acts.Find(id) is Act act)
            {
                var form = new AddAct(db, act);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db);
                }
            }
        }
     
        public void Remove(ArmoryContext db, List<int> ids)
        {
            if (db.Acts.Find(ids[0]) is Act)
            {
                List<Act> acts = new();

                foreach (int id in ids)
                {
                    acts.Add(db.Acts.Find(id)!);
                }

                db.Acts.RemoveRange(acts);
                SaveChanges(db);
            }
        }

        public void Import(ArmoryContext db, Integrator integrator)
        {
            List<Act>? acts = integrator.ImportActs();

            if (acts != null)
            {
                db.Acts.AddRange(acts);
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
