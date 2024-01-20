using Armory.BL.Controller;
using Armory.BL.Model;
using Armory.UI.Commands;
using Armory.UI.Forms;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

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

            OpenActs();

            //table.RowHeadersVisible = false;
            //table.Columns[1].HeaderText = "Город";
        }

        #region Open Data
        private void OpenData<T>(DbSet<T> set, string title) where T : class
        {
            table.DataSource = set.Local.ToBindingList();
            table.Columns[0].Visible = false;
            tableName.Text = title;           
        }

        private void OpenActs()
        {
            OpenData(_db.Acts, "Акты");

            table.Columns[2].Visible = false;
            table.Columns[4].Visible = false;
            table.Columns[6].Visible = false;
            table.Columns[11].Visible = false;
            table.Columns[16].Visible = false;
            table.Columns[18].Visible = false;
            table.Columns[20].Visible = false;
            table.Columns[22].Visible = false;

            _command = new ActCommand();
        }

        private void BtnOpenActs_Click(object sender, EventArgs e)
        {
            OpenActs();
        }

        private void BtnOpenAirports_Click(object sender, EventArgs e)
        {
            OpenData(_db.Airports, ((Button)sender).Text);
            table.Columns[2].Visible = false;
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
            table.Columns[2].Visible = false;
            _command = new SecurityOfficerCommand();          
        }

        private void BtnOpenWeapons_Click(object sender, EventArgs e)
        {
            OpenData(_db.Weapons, ((Button)sender).Text);
            table.Columns[2].Visible = false;
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
            var form = new RemoveForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                List<int> ids = new();

                foreach (DataGridViewRow row in table.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(row.Cells[0].Value));
                }

                _command!.Remove(_db, ids);
                table.Refresh();
            }          
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var form = new ImportDataForm(_db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _command!.Import(_db, form.Integrator);
                table.Refresh();
            }              
        }

        private void Table_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data!.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                var integrator = new Integrator(_db);
                string path = integrator.DragDrop(file);

                if (path != "")
                {
                    _command!.Import(_db, integrator);
                    table.Refresh();
                }
            }
        }

        private void Table_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data!.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void DataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }        
    }
}