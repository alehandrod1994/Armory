using Armory.BL.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class MainForm : Form
    {
        private ArmoryContext? _db;

        public MainForm()
        {
            InitializeComponent();

            _db = new ArmoryContext();
            _db.Acts.Load();
            _db.Airports.Load();
            _db.Ammunitions.Load();
            _db.Cities.Load();
            _db.CrewMembers.Load();
            _db.Flights.Load();
            _db.Planes.Load();
            _db.Positions.Load();
            _db.SecurityOfficers.Load();
            _db.Weapons.Load();
            _db.WeaponTypes.Load();
        }

        private void BtnCreateNewReport_Click(object sender, EventArgs e)
        {
            var form = new ReportForm(_db!, Location.X, Location.Y);
            form.Show();
            Hide();
        }

        private void BtnShowDataForm_Click(object sender, EventArgs e)
        {
            var form = new DataForm(_db!, Location.X, Location.Y);
            form.Show();
            Hide();
        }
    }
}
