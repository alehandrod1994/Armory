using Armory.BL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Armory.UI.Forms
{
    public partial class AddWeapon : Form
    {
        private readonly ArmoryContext? _db;

        public AddWeapon(ArmoryContext db)
        {
            InitializeComponent();

            _db = db;
            SetData(cbTypes, _db!.WeaponTypes);
        }

        public AddWeapon(ArmoryContext db, Weapon weapon) : this(db)
        {
            Weapon = weapon ?? new Weapon();
            tbModel.Text = Weapon.Model;
            SetData(cbTypes, _db!.WeaponTypes, weapon!.Type!.Name!);
        }

        public Weapon? Weapon { get; set; }

        private static void SetData<T>(ComboBox cb, DbSet<T> set)
            where T : class
        {
            cb.Items.AddRange(set.ToArray());          
        }

        private static void SetData<T>(ComboBox cb, DbSet<T> set, string value)
            where T : class
        {
            if (set.ToArray().Length > 0)
            {
                cb.Items.AddRange(set.ToArray());
                cb.Text = value;
            }
        }

        private void BntSave_Click(object sender, EventArgs e)
        {
            // Проверка, чтобы все поля были заполнены:
            Checker.SetControlsToWhite(Controls);

            List<Control> controls = Checker.CheckControlsOnNull(Controls);
            if (controls.Count > 0)
            {
                Checker.SetControlsToRed(controls);
                MessageBox.Show("Неверно заполнены поля.");
                return;
            }

            // Добавление данных в другие таблицы, если данные новые:
            var type = new WeaponType { Name = cbTypes.Text };
            type = DbHelper.EnsureHasItem(_db!.WeaponTypes, type);

            Weapon ??= new Weapon();
            Weapon.Model = tbModel.Text;
            Weapon.Type = type;
          
            DialogResult = DialogResult.OK;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
