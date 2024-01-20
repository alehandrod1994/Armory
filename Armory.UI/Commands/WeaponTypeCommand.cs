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
                SaveChanges(db);
            }
        }

        public void Change(ArmoryContext db, int id)
        {
            if (db.WeaponTypes.Find(id) is WeaponType weaponType)
            {
                var form = new AddWeaponType(db, weaponType);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveChanges(db);
                }
            }
        }

        public void Remove(ArmoryContext db, List<int> ids)
        {
            //if (db.WeaponTypes.Find(ids) is WeaponType weaponType)
            //{
            //    db.WeaponTypes.Remove(weaponType);
            //    SaveChanges(db, "Данные успешно удалены.");
            //}
        }

        public void Import(ArmoryContext db, Integrator integrator)
        {           
            //List<WeaponType>? weaponTypes = integrator.ImportWeaponTypes();

            //if (weaponTypes != null)
            //{
            //    db.WeaponTypes.AddRange(weaponTypes);
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
