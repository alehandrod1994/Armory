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
    public class WeaponCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddWeapon(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Weapons.Add(form.Weapon!);
                SaveChanges(db, "Данные успешно сохранены.");
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.Weapons.Find(id) is Weapon weapon)
            {
                var form = new AddWeapon(db, weapon);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db, "Данные успешно изменены.");
                }
            }
        }

        public void Remove(ArmoryContext db, int id)
        {
            if (db.Weapons.Find(id) is Weapon weapon)
            {
                db.Weapons.Remove(weapon);
                SaveChanges(db, "Данные успешно удалены.");
            }
        }

        public void Import(ArmoryContext db)
        {
            string path = ImportDataFromExcel();

            if (path != "")
            {
                var integrator = new Integrator(db, path);
                List<Weapon>? weapons = integrator.ImportWeaponData();

                if (weapons != null)
                {
                    db.Weapons.AddRange(weapons);
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
