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
    public partial class AddSecurityOfficer : Form
    {
        private readonly ArmoryContext? _db;

        public AddSecurityOfficer(ArmoryContext db)
        {
            InitializeComponent();

            _db = db;
            SetData(cbPositions, _db!.Positions);
        }

        public AddSecurityOfficer(ArmoryContext db, SecurityOfficer securityOfficer) : this(db)
        {
            SecurityOfficer = securityOfficer ?? new SecurityOfficer();
            tbName.Text = SecurityOfficer.Name;
            SetData(cbPositions, _db!.Positions, securityOfficer!.Position!.Name!);
        }

        public SecurityOfficer? SecurityOfficer { get; set; }

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

            var position = new Position { Name = cbPositions.Text };
            position = DbHelper.EnsureHasItem(_db!.Positions, position);

            SecurityOfficer ??= new SecurityOfficer();
            SecurityOfficer.Name = tbName.Text;
            SecurityOfficer.Position = position;

            DialogResult = DialogResult.OK;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
