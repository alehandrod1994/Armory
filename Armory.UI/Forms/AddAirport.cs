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
            tbAirport.Text = Airport.Name;
        }

        public Airport? Airport { get; set; }

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
           
            var city = new City() { Name = tbCity.Text };
            city = DbHelper.EnsureHasItem(_db!.Cities, city);

            Airport ??= new Airport();
            Airport.Name = tbAirport.Text;
            Airport.City = city;

            DialogResult = DialogResult.OK;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
