using Armory.BL.Model;
using Armory.UI.Commands;
using Microsoft.EntityFrameworkCore;

namespace Armory.UI
{
    public partial class DataForm : Form
    {
        private readonly ArmoryContext _db;
        private ICommand? _command;
        private string? _title;

        public DataForm()
        {
            InitializeComponent();

            _db = new ArmoryContext();
            OpenData(_db.Acts, btnOpenActs.Text);

            //using ArmoryContext db = new();
            //var plane = new Plane
            //{
            //    Number = "QF7"
            //};
            //db.Planes.Add(plane);
            //db.SaveChanges();
        }

        #region Open Data
        private void OpenData<T>(DbSet<T> set, string title) where T : class
        {
            set.Load();
            table.DataSource = set.Local.ToBindingList();
            tableName.Text = title;
            _title = title;
        }

        private void BtnOpenActs_Click(object sender, EventArgs e)
        {
            OpenData(_db.Acts, ((Button)sender).Text);
        }

        private void BtnOpenAirports_Click(object sender, EventArgs e)
        {
            OpenData(_db.Airports, ((Button)sender).Text);
            _command = new AirportCommand();
        }

        private void BtnOpenAmmunitions_Click(object sender, EventArgs e)
        {
            OpenData(_db.Ammunitions, ((Button)sender).Text);
        }

        private void BtnOpenCities_Click(object sender, EventArgs e)
        {
            OpenData(_db.Cities, ((Button)sender).Text);
        }

        private void BtnOpenCrewMembers_Click(object sender, EventArgs e)
        {
            OpenData(_db.CrewMembers, ((Button)sender).Text);
        }

        private void BtnOpenFlights_Click(object sender, EventArgs e)
        {
            OpenData(_db.Flights, ((Button)sender).Text);
        }

        private void BtnOpenPlanes_Click(object sender, EventArgs e)
        {
            OpenData(_db.Planes, ((Button)sender).Text);
        }

        private void BtnOpenPositions_Click(object sender, EventArgs e)
        {
            OpenData(_db.Positions, ((Button)sender).Text);
        }

        private void BtnOpenSecurityOfficers_Click(object sender, EventArgs e)
        {
            OpenData(_db.SecurityOfficers, ((Button)sender).Text);
        }

        private void BtnOpenWeapons_Click(object sender, EventArgs e)
        {
            OpenData(_db.Weapons, ((Button)sender).Text);
        }

        private void BtnOpenWeaponTypes_Click(object sender, EventArgs e)
        {
            OpenData(_db.WeaponTypes, ((Button)sender).Text);
        }
        #endregion

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _command!.Add(_db);
            table.Refresh();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(table.SelectedRows[0].Cells[0].Value);
            _command!.Change(_db, id);
            table.Refresh();

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(table.SelectedRows[0].Cells[0].Value);
            _command!.Remove(_db, id);
            table.Refresh();

        }
    }
}