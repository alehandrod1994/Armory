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
    public class SecurityOfficerCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddSecurityOfficer(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.SecurityOfficers.Add(form.SecurityOfficer!);
                SaveChanges(db);
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.SecurityOfficers.Find(id) is SecurityOfficer securityOfficer)
            {
                var form = new AddSecurityOfficer(db, securityOfficer);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db);
                }
            }
        }

        public void Remove(ArmoryContext db, List<int> ids)
        {
            //if (db.SecurityOfficers.Find(ids) is SecurityOfficer securityOfficer)
            //{
            //    db.SecurityOfficers.Remove(securityOfficer);
            //    SaveChanges(db, "Данные успешно удалены.");
            //}
        }

        public void Import(ArmoryContext db, Integrator integrator)
        {
            //List<SecurityOfficer>? securityOfficers = integrator.ImportSecurityOfficers();

            //if (securityOfficers != null)
            //{
            //    db.SecurityOfficers.AddRange(securityOfficers);
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
