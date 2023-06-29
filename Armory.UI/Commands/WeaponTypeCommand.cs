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
    public class WeaponTypeCommand : BaseCommand, ICommand
    {
        public void Add(ArmoryContext db)
        {
            var form = new AddWeaponType(db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.WeaponTypes.Add(form.WeaponType!);
                SaveChanges(db, "Данные успешно сохранены.");
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.WeaponTypes.Find(id) is WeaponType weaponType)
            {
                var form = new AddWeaponType(db, weaponType);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db, "Данные успешно изменены.");
                }
            }
        }

        public void Remove(ArmoryContext db, int id)
        {
            if (db.WeaponTypes.Find(id) is WeaponType weaponType)
            {
                db.WeaponTypes.Remove(weaponType);
                SaveChanges(db, "Данные успешно удалены.");
            }
        }

        public void Import(ArmoryContext db)
        {
            string path = ImportDataFromExcel();

            if (path != "")
            {
                var integrator = new Integrator(db, path);
                List<WeaponType>? types = integrator.ImportWeaponTypeData();

                if (types != null)
                {
                    db.WeaponTypes.AddRange(types);
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
