using Armory.BL.Model;
using Armory.UI.Commands;
using Microsoft.EntityFrameworkCore;

namespace Armory.UI
{
    public partial class DataForm : Form
    {
        private readonly ArmoryContext _db;
        private ICommand? _command;

        public DataForm(ArmoryContext db, int x, int y)
        {
            InitializeComponent();

            _db = db;
            Location = new Point(x, y);

            OpenData(_db.Acts, btnOpenActs.Text);
            _command = new ActCommand();
        }

        #region Open Data
        private void OpenData<T>(DbSet<T> set, string title) where T : class
        {
            table.DataSource = set.Local.ToBindingList();
            tableName.Text = title;
        }

        private void BtnOpenActs_Click(object sender, EventArgs e)
        {
            OpenData(_db.Acts, ((Button)sender).Text);
            _command = new ActCommand();
        }

        private void BtnOpenAirports_Click(object sender, EventArgs e)
        {
            OpenData(_db.Airports, ((Button)sender).Text);
            _command = new AirportCommand();
        }

        private void BtnOpenAmmunitions_Click(object sender, EventArgs e)
        {
            OpenData(_db.Ammunitions, ((Button)sender).Text);
            _command = new AmmunitionCommand();
        }

        private void BtnOpenCities_Click(object sender, EventArgs e)
        {
            OpenData(_db.Cities, ((Button)sender).Text);
            _command = new CityCommand();
        }

        private void BtnOpenCrewMembers_Click(object sender, EventArgs e)
        {
            OpenData(_db.CrewMembers, ((Button)sender).Text);
            _command = new CrewMemberCommand();
        }

        private void BtnOpenFlights_Click(object sender, EventArgs e)
        {
            OpenData(_db.Flights, ((Button)sender).Text);
            _command = new FlightCommand();
        }

        private void BtnOpenPlanes_Click(object sender, EventArgs e)
        {
            OpenData(_db.Planes, ((Button)sender).Text);
            _command = new PlaneCommand();
        }

        private void BtnOpenPositions_Click(object sender, EventArgs e)
        {
            OpenData(_db.Positions, ((Button)sender).Text);
            _command = new PositionCommand();
        }

        private void BtnOpenSecurityOfficers_Click(object sender, EventArgs e)
        {
            OpenData(_db.SecurityOfficers, ((Button)sender).Text);
            _command = new SecurityOfficerCommand();
        }

        private void BtnOpenWeapons_Click(object sender, EventArgs e)
        {
            OpenData(_db.Weapons, ((Button)sender).Text);
            _command = new WeaponCommand();
        }

        private void BtnOpenWeaponTypes_Click(object sender, EventArgs e)
        {
            OpenData(_db.WeaponTypes, ((Button)sender).Text);
            _command = new WeaponTypeCommand();
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

        private void BtnImport_Click(object sender, EventArgs e)
        {
            _command!.Import(_db);
            table.Refresh();
        }

        private void DataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }        
    }
}