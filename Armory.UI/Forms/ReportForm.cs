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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace Armory.UI.Forms
{
    // Вкладки:
    // Основная : акт, дата, аэропорт.
    // Сотрудники : фио стаб, должности стаб, фио экипажа. 
    // Пассажир : фио, паспорт.
    // Рейс : номер рейса, маршрут, номер самолёта.
    // Оружие.
    // Патроны.
    // Сохранение: сохранить, сохранить и распечатать, превью.

    public partial class ReportForm : Form
	{
		private readonly ArmoryContext? _db;
		private int _currentTabNumber;
		private int _maxTabNumber;
		private List<Tab>? _tabs;


		public ReportForm(ArmoryContext db, int x, int y)
		{
			InitializeComponent();

			_db = db;
			Location = new Point(x, y);

			CreateNewReport();
		}

		private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void BtnCreateNewReport_Click(object sender, EventArgs e)
		{
			CreateNewReport();
		}

		private void ClearAllData()
		{
            //tbActNumber.Text = "";
            //tbDate.Text = "";
            //cbDepartureCities.Items.Clear();
            //cbDepartureAirports.Items.Clear();

            //cbSecurityOfficers.Items.Clear();
            //cbPositions.Items.Clear();
            //tbPassengerName.Text = "";
            //tbPassengerLastNameName.Text = "";
            //tbPassengerMiddleNameName.Text = "";
            //tbPassportNumber.Text = "";
            //tbPassportSeria.Text = "";
            //tbPassportWhoGiven.Text = "";
            //tbPassportWhenGiven.Text = "";
            //cbFlightNumbers.Items.Clear();
            //cbDestinationCities.Items.Clear();
            //cbPlaneNumbers.Items.Clear();
            //cbWeaponTypes.Items.Clear();
            //cbWeaponModels.Items.Clear();
            //tbWeaponRegistrationNumber.Text = "";
            //tbWeaponCharacteristics.Text = "";
            //tbWeaponBaggageTagNumber.Text = "";
            //tbAmmunitionCount.Text = "";
            //tbAmmunitionWeight.Text = "";
            //cbAmmunitions.Items.Clear();
            //tbAmmunitionBaggageTagNumber.Text = "";
            //cbCrewMembers.Items.Clear();

            Panel panel = _tabs![_currentTabNumber - 1].Panel;

            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }

                if (control is ComboBox box)
                {
                    box.Text = "";
                    box.Items.Clear();
                }
            }

        }

        private void CreateNewReport()
		{		
			_tabs = new List<Tab>()
			{
				new Tab(1, "Основная", panelMain),
				new Tab(2, "Сотрудники", panelEmployees),
				new Tab(3, "Пассажир", panelPassenger),
				new Tab(4, "Рейс", panelFlight),
				new Tab(5, "Оружие", panelWeapon),
				new Tab(6, "Патроны", panelAmmunition),
				new Tab(7, "Сохранение", panelSave)
			};

            _currentTabNumber = 1;
            _maxTabNumber = _tabs.Count;
            OpenTab(_currentTabNumber);

            panelProgress.Invalidate();
            btnPrevious.Enabled = false;
			btnNext.Enabled = true;

			ClearAllData();

			if (_db!.Acts.OrderBy(a => a.ID).Last() is Act act)
			{
                int actNumber = act.Number;

				if (act.Date.Year != DateTime.Today.Year)
				{
                    actNumber = 0;
				}

                actNumber++;
                tbActNumber.Text = actNumber.ToString();
			}

			// TODO: Проверить, увеличивается ли номер последнего акта в общем списке.

			tbDate.Text = DateTime.Today.ToShortDateString();

			cbDepartureCities.Items.AddRange(_db.Cities.ToArray());
            cbDepartureAirports.Items.AddRange(_db.Airports.ToArray());


            if (_db.Cities.FirstOrDefault(c => c.Name == "Красноярск") is City city)
			{
				cbDepartureCities.SelectedItem = city;
			}

			
			if (_db.Airports.FirstOrDefault(a => a.Name!.Contains("Красноярск")) is Airport airport)
			{
				cbDepartureAirports.Text = airport.Name;
			}

            cbSecurityOfficers.Items.AddRange(_db.SecurityOfficers.ToArray());
            cbPositions.Items.AddRange(_db.Positions.ToArray());
            cbCrewMembers.Items.AddRange(_db.CrewMembers.ToArray());

            cbFlightNumbers.Items.AddRange(_db.Flights.ToArray());
            cbArrivalCities.Items.AddRange(_db.Cities.ToArray());
            cbArrivalAirports.Items.AddRange(_db.Cities.ToArray());
            cbPlaneNumbers.Items.AddRange(_db.Planes.ToArray());

            cbWeaponTypes.Items.AddRange(_db.WeaponTypes.ToArray());
            cbWeaponModels.Items.AddRange(_db.Weapons.ToArray());
            cbAmmunitions.Items.AddRange(_db.Ammunitions.ToArray());
        }

        //private void cbSecurityOfficers_OnChanged(object sender, EventHandler args)
        //{
        //    var officer = _db.SecurityOfficers.FirstOrDefault(e => e.Name == cbSecurityOfficers.Text);
        //    if (officer != null)
        //    {
        //        cbPositions.Text = officer.Position.Name;
        //    }
        //}

        //private void cbWeaponTypes_OnChanged(object sender, EventHandler args)
        //{
        //    cbWeaponModels.Items.Clear();
        //    var weapons = _db.Weapons.Where(w => w.Type.Name == cbWeaponTypes.Text);
        //    if (weapons != null)
        //    {
        //        cbWeaponModels.Items.AddRange(weapons.ToArray());
        //    }
        //}

        private void PickAirportsFromCity(ComboBox airportsBox, ComboBox citiesBox)
        {
            airportsBox.Text = "";
            airportsBox.Items.Clear();

            var items = _db!.Airports.Where(a => a!.City!.Name == citiesBox.Text);
            if (items != null)
            {
                airportsBox.Items.AddRange(items.ToArray());
            }
            else
            {
                airportsBox.Items.AddRange(_db.Airports.ToArray());
            }
        }

        private void CbArrivalCities_SelectedValueChanged(object sender, EventArgs e)
        {
            PickAirportsFromCity(cbArrivalAirports, cbArrivalCities);
        }

        private void CbDepartureCities_SelectedValueChanged(object sender, EventArgs e)
		{
            PickAirportsFromCity(cbDepartureAirports, cbDepartureCities);
        }     

        private void CbDepartureCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var airports = _db!.Airports.Where(a => a!.City!.Name == cbDepartureCities.Text);
            //if (airports != null)
            //{
            //    cbDepartureAirports.Items.Clear();
            //    cbDepartureAirports.Items.AddRange(airports.ToArray());
            //}
            //else
            //{
            //    cbDepartureAirports.Items.Clear();
            //    cbDepartureAirports.Items.AddRange(_db.Airports.ToArray());
            //}
        }

        private void CbDepartureCities_TextChanged(object sender, EventArgs e)
        {
			//var airports = _db!.Airports.Where(a => a!.City!.Name == cbDepartureCities.Text);
   //         if (airports != null)
   //         {
   //             cbDepartureAirports.Items.Clear();
   //             cbDepartureAirports.Items.AddRange(airports.ToArray());
   //         }
   //         else
   //         {
   //             cbDepartureAirports.Items.Clear();
   //             cbDepartureAirports.Items.AddRange(_db.Airports.ToArray());
   //         }
        }

        private void CbWeaponTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            cbWeaponModels.Text = "";
            cbWeaponModels.Items.Clear();

            var items = _db!.Weapons.Where(w => w!.Type!.Name == cbWeaponTypes.Text);
            if (items != null)
            {
                cbWeaponModels.Items.AddRange(items.ToArray());
            }
            else
            {
                cbWeaponModels.Items.AddRange(_db.Weapons.ToArray());
            }
        }

        private void OpenTab(int tabNumber)
		{
            if (tabNumber > _maxTabNumber)
            {
                return;
            }

            Tab tab = _tabs![tabNumber - 1];
            Panel panel = tab.Panel;
            panel.BringToFront();
            panel.Show();

            title.Text = tab.Name;
            panelProgress.Invalidate();

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            if (_currentTabNumber == 1)
            {
                btnPrevious.Enabled = false;
            }

            if (_currentTabNumber == _maxTabNumber)
            {
                btnNext.Enabled = false;
            }
        }

        private bool CheckTabControls()
        {
            Panel panel = _tabs![_currentTabNumber - 1].Panel;

            Checker.SetControlsToWhite(panel.Controls);
            List<Control> controls = Checker.CheckControlsOnNull(panel.Controls);

            switch (_currentTabNumber)
            {
                case 1:
                    controls.AddRange(Checker.ParseIntControls(new List<Control>() { tbActNumber }));
                    break;

                case 3:
                    controls.AddRange(Checker.ParsePassengerPassport(tbPassportSeria, tbPassportNumber, tbPassportWhenGiven));
                    break;

                case 6:
                    controls.AddRange(Checker.ParseIntControls(new List<Control>() { tbAmmunitionCount }));
                    controls.AddRange(Checker.ParseDoubleControls(new List<Control>() { tbAmmunitionWeight }));
                    break;

                default:
                    break;
            }

            if (controls.Count > 0)
            {
                Checker.SetControlsToRed(controls);
                MessageBox.Show("Неверно заполнены поля.");
                return false;
            }           
           
            return true;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            _currentTabNumber--;
            OpenTab(_currentTabNumber);          
        }

        private void BtnNext_Click(object sender, EventArgs e)
		{
            if (CheckTabControls())
            {
                _currentTabNumber++;
                OpenTab(_currentTabNumber);
            }
        }

		private void ReportForm_Paint(object sender, PaintEventArgs e)
		{
			int positionX = 300;
            int positionY = 70;
            int width = 700;

			Pen blackPen = new(Color.DarkGray, 1);
			e.Graphics.DrawLine(blackPen, positionX, positionY, positionX + width, positionY);			
		}

		private int CalculateProgress()
		{
			return _currentTabNumber * 700 / _maxTabNumber;
		}

		private void PanelProgress_Paint(object sender, PaintEventArgs e)
		{
			int width = CalculateProgress();

			Pen bluePen = new(Color.DodgerBlue, 7);
			e.Graphics.DrawLine(bluePen, 0, 0, width, 0);
		}

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Tab tab = _tabs![_currentTabNumber - 1];
            Panel panel = tab.Panel;
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }

                if (control is ComboBox box)
                {
                    box.Text = "";
                    box.Items.Clear();
                }
            }
        }

        private void BtnReportAct_Click(object sender, EventArgs e)
        {
            var position = new Position() { Name = cbPositions.Text };
            position = DbHelper.EnsureHasItem(_db!.Positions, position);

            var officer = new SecurityOfficer()
            {
                Name = cbSecurityOfficers.Text,
                Position = position
            };
            officer = DbHelper.EnsureHasItem(_db.SecurityOfficers, officer);

            var crewMember = new CrewMember() { Name = cbCrewMembers.Text };
            crewMember = DbHelper.EnsureHasItem(_db.CrewMembers, crewMember);

            var weaponType = new WeaponType() { Name = cbWeaponTypes.Text };
            weaponType = DbHelper.EnsureHasItem(_db.WeaponTypes, weaponType);

            var weapon = new Weapon()
            {
                Model = cbWeaponModels.Text,
                Type = weaponType
            };
            weapon = DbHelper.EnsureHasItem(_db.Weapons, weapon);

            var ammunition = new Ammunition() { Type = cbWeaponTypes.Text };
            ammunition = DbHelper.EnsureHasItem(_db.Ammunitions, ammunition);

            var departureCity = new City() { Name = cbDepartureCities.Text };
            departureCity = DbHelper.EnsureHasItem(_db.Cities, departureCity);

            var arrivalCity = new City() { Name = cbArrivalCities.Text };
            arrivalCity = DbHelper.EnsureHasItem(_db.Cities, arrivalCity);

            var departureAirport = new Airport()
            {
                Name = cbDepartureAirports.Text,
                City = departureCity
            };
            departureAirport = DbHelper.EnsureHasItem(_db.Airports, departureAirport);

            var arrivalAirport = new Airport()
            {
                Name = cbArrivalAirports.Text,
                City = arrivalCity
            };
            arrivalAirport = DbHelper.EnsureHasItem(_db.Airports, arrivalAirport);

            var flight = new Flight() { Number = cbFlightNumbers.Text };
            flight = DbHelper.EnsureHasItem(_db.Flights, flight);

            var plane = new Plane() { Number = cbPlaneNumbers.Text };
            plane = DbHelper.EnsureHasItem(_db.Planes, plane);

            var passport = new PassengerPassport(tbPassportSeria.Text, tbPassportNumber.Text, Convert.ToDateTime(tbPassportWhenGiven.Text).Date, tbPassportWhoGiven.Text);
            var passenger = new Passenger(tbPassengerSurname.Text, tbPassengerName.Text, tbPassengerPatronymic.Text, passport);

            var act = new Act()
            {
                Number = Convert.ToInt32(tbActNumber.Text),
                DepartureAirport = departureAirport,
                ArrivalAirport = arrivalAirport,
                Ammunition = ammunition,
                AmmunitionBaggageTagNumber = tbAmmunitionBaggageTagNumber.Text,
                AmmunitionCount = Convert.ToInt32(tbAmmunitionCount.Text),
                AmmunitionWeight = Convert.ToDouble(tbAmmunitionWeight.Text),
                CrewMember = crewMember,
                Date = Convert.ToDateTime(tbDate.Text),
                Flight = flight,
                Plane = plane,
                SecurityOfficer = officer,
                Weapon = weapon,
                WeaponBaggageTagNumber = tbWeaponBaggageTagNumber.Text,
                WeaponCharacteristics = tbWeaponCharacteristics.Text,
                WeaponRegistrationNumber = tbWeaponRegistrationNumber.Text
            };

            var report = new Report();
            MessageResult result = report.ReportAct(act, passenger);
            ShowExportResult(act, result, report.NewFilePath!);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var position = new Position() { Name = "Должность" };
            position = DbHelper.EnsureHasItem(_db!.Positions, position);

            var officer = new SecurityOfficer()
            {
                Name = "СТАБ",
                Position = position
            };
            officer = DbHelper.EnsureHasItem(_db.SecurityOfficers, officer);

            var crewMember = new CrewMember() { Name = "Экипаж" };
            crewMember = DbHelper.EnsureHasItem(_db.CrewMembers, crewMember);

            var weaponType = new WeaponType() { Name = "Автомат" };
            weaponType = DbHelper.EnsureHasItem(_db.WeaponTypes, weaponType);

            var weapon = new Weapon()
            {
                Model = "11",
                Type = weaponType
            };
            weapon = DbHelper.EnsureHasItem(_db.Weapons, weapon);

            var ammunition = new Ammunition() { Type = "Автомат" };
            ammunition = DbHelper.EnsureHasItem(_db.Ammunitions, ammunition);

            var departureCity = new City() { Name = "Красноярск" };
            departureCity = DbHelper.EnsureHasItem(_db.Cities, departureCity);

            var arrivalCity = new City() { Name = "Москва" };
            arrivalCity = DbHelper.EnsureHasItem(_db.Cities, arrivalCity);

            var departureAirport = new Airport()
            {
                Name = "Международный аэропорт Красноярск",
                City = departureCity
            };
            departureAirport = DbHelper.EnsureHasItem(_db.Airports, departureAirport);

            var arrivalAirport = new Airport()
            {
                Name = "Домодедово",
                City = arrivalCity
            };
            arrivalAirport = DbHelper.EnsureHasItem(_db.Airports, arrivalAirport);

            var flight = new Flight() { Number = "SU-147" };
            flight = DbHelper.EnsureHasItem(_db.Flights, flight);

            var plane = new Plane() { Number = "Q77" };
            plane = DbHelper.EnsureHasItem(_db.Planes, plane);

            var passport = new PassengerPassport("1234", "123456", Convert.ToDateTime("18.06.2023"), "EEEE Чертаново Южное по гор. Москве");
            var passenger = new Passenger("Иванов", "Иван", "Иванович", passport);

            var act = new Act()
            {
                Number = Convert.ToInt32(tbActNumber.Text),
                DepartureAirport = departureAirport,
                ArrivalAirport = arrivalAirport,
                Ammunition = ammunition,
                AmmunitionBaggageTagNumber = "123456",
                AmmunitionCount = 10,
                AmmunitionWeight = 100,
                CrewMember = crewMember,
                Date = DateTime.Today.Date,
                Flight = flight,
                Plane = plane,
                SecurityOfficer = officer,
                Weapon = weapon,
                WeaponBaggageTagNumber = "123456",
                WeaponCharacteristics = "123456",
                WeaponRegistrationNumber = "123456"
            };

            var report = new Report();
            MessageResult result = report.ReportAct(act, passenger);
            ShowExportResult(act, result, report.NewFilePath!);
        }

        private void BtnReportActAndPrint_Click(object sender, EventArgs e)
        {
            BtnReportAct_Click(sender, e);

            //    Print();
        }

        private void ShowExportResult(Act act, MessageResult result, string newFileName)
        {          
            switch (result)
            {
                case MessageResult.FailedConnection:
                    MessageBox.Show("Не удалось открыть подключение к файлу.");
                    break;

                case MessageResult.NotSaved:
                    MessageBox.Show("Не удалось сохранить файл.");
                    break;

                case MessageResult.Saved:
                    MessageBox.Show("Успешно.");
                    _db!.Acts.Add(act);
                    _db!.SaveChanges();
                    //var form = new SuccessfullyExport(newFileName);
                    //form.Show();
                    break;
            }
        }

       
    }
}
