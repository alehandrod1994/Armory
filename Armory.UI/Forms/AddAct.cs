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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace Armory.UI.Forms
{
    // TODO: Проверки на валидность ведённых данных.
    // TODO: Переопределить Equals и GetHashCode у моделей, чтобы определить есть ли уже такая запись в базе.
    // TODO: Переопределить ToString у моделей по типу "return Name".
    // TODO: Вывести из Акта отдельно информацию об Оружии и Патронах.
    // TODO: Изменить модель Airport и City, чтобы у каждого города было несколько аэропортов.
    public partial class AddAct : Form
    {
        private readonly ArmoryContext? _db;

        public AddAct(ArmoryContext db)
        {
            InitializeComponent();

            _db = db;

            SetData(cbDepartureAirports, db.Airports);
            SetData(cbArrivalAirports, db.Airports);
            SetData(cbSecurityOfficers, db.SecurityOfficers);
            SetData(cbPositions, db.Positions);
            SetData(cbFlights, db.Flights);
            SetData(cbDepartureCities, db.Cities);
            SetData(cbArrivalCities, db.Cities);
            SetData(cbPlanes, db.Planes);
            SetData(cbWeaponTypes, db.WeaponTypes);
            SetData(cbWeapons, db.Weapons);
            SetData(cbAmmunitions, db.Ammunitions);
            SetData(cbCrewMembers, db.CrewMembers);
        }

        public AddAct(ArmoryContext db, Act act) : this(db)
        {
            Act = act ?? new Act();

            tbNumber.Text = Act.Number.ToString();
            tbWeaponRegistrationNumber.Text = Act.WeaponRegistrationNumber;
            tbWeaponCharacteristics.Text = Act.WeaponCharacteristics;
            tbWeaponBaggageTagNumber.Text = Act.WeaponBaggageTagNumber;
            tbAmmunitionCount.Text = Act.AmmunitionCount.ToString();
            tbAmmunitionWeight.Text = Act.AmmunitionWeight.ToString();
            tbAmmunitionBaggageTagNumber.Text = Act.AmmunitionBaggageTagNumber;

            SetData(cbDepartureAirports, db.Airports, act!.DepartureAirport!.Name!);
            SetData(cbArrivalAirports, db.Airports, act!.ArrivalAirport!.Name!);            
            SetData(cbSecurityOfficers, db.SecurityOfficers, act.SecurityOfficer!.Name!);
            SetData(cbPositions, db.Positions, act.SecurityOfficer.Position!.Name!);
            SetData(cbFlights, db.Flights, act.Flight!.Number!);
            SetData(cbDepartureCities, db.Cities, act.DepartureAirport.City!.Name!);
            SetData(cbArrivalCities, db.Cities, act.ArrivalAirport.City!.Name!);
            SetData(cbPlanes, db.Planes, act.Plane!.Number!);
            SetData(cbWeaponTypes, db.WeaponTypes, act.Weapon!.Type!.Name!);
            SetData(cbWeapons, db.Weapons, act.Weapon!.Model!);
            SetData(cbAmmunitions, db.Ammunitions, act.Ammunition!.Type!);
            SetData(cbCrewMembers, db.CrewMembers, act.CrewMember!.Name!);
        }

        public Act? Act { get; set; }

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

        private static bool ParseControls(List<Control>? controls, Func<List<Control>, List<Control>> parse)
        {
            controls = parse?.Invoke(controls!);
            if (controls?.Count > 0)
            {
                Checker.SetControlsToRed(controls);
                MessageBox.Show("Неверно заполнены поля.");
                return false;
            }

            return true;
        }

        private void BntSave_Click(object sender, EventArgs e)
        {
            Checker.SetControlsToWhite(Controls);

            List<Control> controls = Checker.CheckControlsOnNull(Controls);
            if (controls.Count > 0)
            {
                Checker.SetControlsToRed(controls);
                MessageBox.Show("Неверно заполнены поля.");
                return;
            }

            //List<Control> controls = new();
            controls.Clear();
            controls.Add(tbNumber);
            controls.Add(tbAmmunitionCount);
            if (!ParseControls(controls, Checker.ParseIntControls)) return;

            controls.Clear();
            controls.Add(tbAmmunitionWeight);           
            if (!ParseControls(controls, Checker.ParseDoubleControls)) return;

            controls.Clear();
            controls.Add(tbDate);
            if (!ParseControls(controls, Checker.ParseDateTimeControls)) return;


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
                Model = cbWeapons.Text,
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

            var flight = new Flight() { Number = cbFlights.Text };
            flight = DbHelper.EnsureHasItem(_db.Flights, flight);

            var plane = new Plane() { Number = cbPlanes.Text };
            plane = DbHelper.EnsureHasItem(_db.Planes, plane);

            Act ??= new Act();
            Act.Number = Convert.ToInt32(tbNumber.Text);
            Act.DepartureAirport = departureAirport;
            Act.ArrivalAirport = arrivalAirport;
            Act.Ammunition = ammunition;
            Act.AmmunitionBaggageTagNumber = tbAmmunitionBaggageTagNumber.Text;
            Act.AmmunitionCount = Convert.ToInt32(tbAmmunitionCount.Text);
            Act.AmmunitionWeight = Convert.ToDouble(tbAmmunitionWeight.Text);
            Act.CrewMember = crewMember;
            Act.Date = Convert.ToDateTime(tbDate.Text);
            Act.Flight = flight;
            Act.Plane = plane;                    
            Act.SecurityOfficer = officer;
            Act.Weapon = weapon;
            Act.WeaponBaggageTagNumber = tbWeaponBaggageTagNumber.Text;
            Act.WeaponCharacteristics = tbWeaponCharacteristics.Text;
            Act.WeaponRegistrationNumber = tbWeaponRegistrationNumber.Text;

            DialogResult = DialogResult.OK;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
