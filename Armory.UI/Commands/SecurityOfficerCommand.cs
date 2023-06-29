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
                SaveChanges(db, "Данные успешно сохранены.");
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.SecurityOfficers.Find(id) is SecurityOfficer securityOfficer)
            {
                var form = new AddSecurityOfficer(db, securityOfficer);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db, "Данные успешно изменены.");
                }
            }
        }

        public void Remove(ArmoryContext db, int id)
        {
            if (db.SecurityOfficers.Find(id) is SecurityOfficer securityOfficer)
            {
                db.SecurityOfficers.Remove(securityOfficer);
                SaveChanges(db, "Данные успешно удалены.");
            }
        }

        public void Import(ArmoryContext db)
        {
            string path = ImportDataFromExcel();

            if (path != "")
            {
                var integrator = new Integrator(db, path);
                List<SecurityOfficer>? securityOfficers = integrator.ImportSecurityOfficerData();

                if (securityOfficers != null)
                {
                    db.SecurityOfficers.AddRange(securityOfficers);
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
