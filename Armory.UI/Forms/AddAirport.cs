using Armory.BL.Model;
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

namespace Armory.UI
{
    public partial class AddAirport : Form
    {
        private readonly ArmoryContext? _db;

        public AddAirport(ArmoryContext db)
        {
            InitializeComponent();
            _db = db;
        }

        public AddAirport(ArmoryContext db, Airport airport) : this(db)
        {           
            Airport = airport ?? new Airport();
            tbName.Text = Airport.Name;
        }

        public Airport? Airport { get; set; }

        private void BntSave_Click(object sender, EventArgs e)
        {
            // Проверка, чтобы все поля были заполнены:
            List<Control> controls = Checker.CheckControlsOnNull(this);
            if (controls.Count > 0)
            {
                foreach (Control control in controls)
                {
                    control.BackColor = Color.LightCoral;
                }

                MessageBox.Show("Заполните все поля.");
                return;
            }

            // Проверка, есть ли в базе уже такой аэропорт:		
            if (Checker.CheckOnDublicate(_db!.Airports, tbName.Text)) return;

            Airport ??= new Airport();
            Airport.Name = tbName.Text;
            DialogResult = DialogResult.OK;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
