using Armory.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armory.UI.Forms
{
    public partial class AddPlane : Form
    {
        private readonly ArmoryContext? _db;

        public AddPlane(ArmoryContext db)
        {
            InitializeComponent();
            _db = db;
        }

        public AddPlane(ArmoryContext db, Plane plane) : this(db)
        {
            Plane = plane ?? new Plane();
            tbNumber.Text = Plane.Number;
        }

        public Plane? Plane { get; set; }

        private void BntSave_Click(object sender, EventArgs e)
        {
            // Проверка, чтобы все поля были заполнены:
            List<Control> controls = Checker.CheckControlsOnNull(Controls);
            if (controls.Count > 0)
            {
                Checker.SetControlsToRed(controls);
                MessageBox.Show("Неверно заполнены поля.");
                return;
            }           

            Plane ??= new Plane();
            Plane.Number = tbNumber.Text;

            DialogResult = DialogResult.OK;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
