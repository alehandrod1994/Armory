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
    public partial class AddCity : Form
    {
        private readonly ArmoryContext? _db;

        public AddCity(ArmoryContext db)
        {
            InitializeComponent();
            _db = db;
        }

        public AddCity(ArmoryContext db, City city) : this(db)
        {
            City = city ?? new City();
            tbName.Text = City.Name;
        }

        public City? City { get; set; }

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
            
            City ??= new City();
            City.Name = tbName.Text;

            DialogResult = DialogResult.OK;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
