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
    public class CrewMemberCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddCrewMember(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.CrewMembers.Add(form.CrewMember!);
                SaveChanges(db, "Данные успешно сохранены.");
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.CrewMembers.Find(id) is CrewMember crewMember)
            {
                var form = new AddCrewMember(db, crewMember);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db, "Данные успешно изменены.");
                }
            }
        }

        public void Remove(ArmoryContext db, int id)
        {
            if (db.CrewMembers.Find(id) is CrewMember crewMember)
            {
                db.CrewMembers.Remove(crewMember);
                SaveChanges(db, "Данные успешно удалены.");
            }
        }

        public void Import(ArmoryContext db)
        {
            string path = ImportDataFromExcel();

            if (path != "")
            {
                var integrator = new Integrator(db, path);
                List<CrewMember>? crewMembers = integrator.ImportCrewMemberData();

                if (crewMembers != null)
                {
                    db.CrewMembers.AddRange(crewMembers);
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
