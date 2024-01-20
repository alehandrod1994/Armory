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
                SaveChanges(db);
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.CrewMembers.Find(id) is CrewMember crewMember)
            {
                var form = new AddCrewMember(db, crewMember);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db);
                }
            }
        }

        public void Remove(ArmoryContext db, List<int> ids)
        {
            //if (db.CrewMembers.Find(ids) is CrewMember crewMember)
            //{
            //    db.CrewMembers.Remove(crewMember);
            //    SaveChanges(db, "Данные успешно удалены.");
            //}
        }

        public void Import(ArmoryContext db, Integrator integrator)
        {
            //List<CrewMember>? crewMembers = integrator.ImportCrewMembers();

            //if (crewMembers != null)
            //{
            //    db.CrewMembers.AddRange(crewMembers);
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
