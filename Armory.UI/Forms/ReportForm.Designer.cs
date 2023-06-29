namespace Armory.UI.Forms
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.cbDepartureAirports = new System.Windows.Forms.ComboBox();
            this.cbDepartureCities = new System.Windows.Forms.ComboBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbActNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReportActAndPrint = new System.Windows.Forms.Button();
            this.btnReportAct = new System.Windows.Forms.Button();
            this.btnCreateNewReport = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panelEmployees = new System.Windows.Forms.Panel();
            this.cbSecurityOfficers = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCrewMembers = new System.Windows.Forms.ComboBox();
            this.cbPositions = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.panelPassenger = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPassportWhenGiven = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPassportWhoGiven = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPassportNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPassportSeria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPassengerPatronymic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPassengerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPassengerSurname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelFlight = new System.Windows.Forms.Panel();
            this.cbPlaneNumbers = new System.Windows.Forms.ComboBox();
            this.cbFlightNumbers = new System.Windows.Forms.ComboBox();
            this.cbArrivalAirports = new System.Windows.Forms.ComboBox();
            this.cbArrivalCities = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panelWeapon = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.tbWeaponBaggageTagNumber = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbWeaponCharacteristics = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbWeaponRegistrationNumber = new System.Windows.Forms.TextBox();
            this.cbWeaponTypes = new System.Windows.Forms.ComboBox();
            this.cbWeaponModels = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panelAmmunition = new System.Windows.Forms.Panel();
            this.tbAmmunitionBaggageTagNumber = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbAmmunitionWeight = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cbAmmunitions = new System.Windows.Forms.ComboBox();
            this.tbAmmunitionCount = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.panelSave = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelEmployees.SuspendLayout();
            this.panelPassenger.SuspendLayout();
            this.panelFlight.SuspendLayout();
            this.panelWeapon.SuspendLayout();
            this.panelAmmunition.SuspendLayout();
            this.panelSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.cbDepartureAirports);
            this.panelMain.Controls.Add(this.cbDepartureCities);
            this.panelMain.Controls.Add(this.tbDate);
            this.panelMain.Controls.Add(this.tbActNumber);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Location = new System.Drawing.Point(300, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(700, 500);
            this.panelMain.TabIndex = 22;
            // 
            // cbDepartureAirports
            // 
            this.cbDepartureAirports.FormattingEnabled = true;
            this.cbDepartureAirports.Location = new System.Drawing.Point(300, 226);
            this.cbDepartureAirports.Name = "cbDepartureAirports";
            this.cbDepartureAirports.Size = new System.Drawing.Size(300, 23);
            this.cbDepartureAirports.Sorted = true;
            this.cbDepartureAirports.TabIndex = 7;
            // 
            // cbDepartureCities
            // 
            this.cbDepartureCities.FormattingEnabled = true;
            this.cbDepartureCities.Location = new System.Drawing.Point(300, 183);
            this.cbDepartureCities.Name = "cbDepartureCities";
            this.cbDepartureCities.Size = new System.Drawing.Size(300, 23);
            this.cbDepartureCities.Sorted = true;
            this.cbDepartureCities.TabIndex = 6;
            this.cbDepartureCities.SelectedIndexChanged += new System.EventHandler(this.CbDepartureCities_SelectedIndexChanged);
            this.cbDepartureCities.SelectedValueChanged += new System.EventHandler(this.CbDepartureCities_SelectedValueChanged);
            this.cbDepartureCities.TextChanged += new System.EventHandler(this.CbDepartureCities_TextChanged);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(300, 139);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(300, 23);
            this.tbDate.TabIndex = 5;
            // 
            // tbActNumber
            // 
            this.tbActNumber.Location = new System.Drawing.Point(300, 98);
            this.tbActNumber.Name = "tbActNumber";
            this.tbActNumber.Size = new System.Drawing.Size(300, 23);
            this.tbActNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Аэропорт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Город:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Акт №";
            // 
            // btnReportActAndPrint
            // 
            this.btnReportActAndPrint.Location = new System.Drawing.Point(111, 158);
            this.btnReportActAndPrint.Name = "btnReportActAndPrint";
            this.btnReportActAndPrint.Size = new System.Drawing.Size(155, 41);
            this.btnReportActAndPrint.TabIndex = 29;
            this.btnReportActAndPrint.Text = "Оформить акт и распечатать";
            this.btnReportActAndPrint.UseVisualStyleBackColor = true;
            this.btnReportActAndPrint.Click += new System.EventHandler(this.BtnReportActAndPrint_Click);
            // 
            // btnReportAct
            // 
            this.btnReportAct.Location = new System.Drawing.Point(111, 82);
            this.btnReportAct.Name = "btnReportAct";
            this.btnReportAct.Size = new System.Drawing.Size(155, 34);
            this.btnReportAct.TabIndex = 28;
            this.btnReportAct.Text = "Оформить акт";
            this.btnReportAct.UseVisualStyleBackColor = true;
            this.btnReportAct.Click += new System.EventHandler(this.BtnReportAct_Click);
            // 
            // btnCreateNewReport
            // 
            this.btnCreateNewReport.Location = new System.Drawing.Point(39, 550);
            this.btnCreateNewReport.Name = "btnCreateNewReport";
            this.btnCreateNewReport.Size = new System.Drawing.Size(133, 40);
            this.btnCreateNewReport.TabIndex = 23;
            this.btnCreateNewReport.Text = "Создать новый отчёт";
            this.btnCreateNewReport.UseVisualStyleBackColor = true;
            this.btnCreateNewReport.Click += new System.EventHandler(this.BtnCreateNewReport_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(901, 621);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 23);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(300, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(108, 30);
            this.title.TabIndex = 8;
            this.title.Text = "Основная";
            // 
            // panelEmployees
            // 
            this.panelEmployees.BackColor = System.Drawing.SystemColors.Control;
            this.panelEmployees.Controls.Add(this.cbSecurityOfficers);
            this.panelEmployees.Controls.Add(this.label7);
            this.panelEmployees.Controls.Add(this.cbCrewMembers);
            this.panelEmployees.Controls.Add(this.cbPositions);
            this.panelEmployees.Controls.Add(this.label5);
            this.panelEmployees.Controls.Add(this.label6);
            this.panelEmployees.Location = new System.Drawing.Point(300, 100);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Size = new System.Drawing.Size(700, 500);
            this.panelEmployees.TabIndex = 26;
            // 
            // cbSecurityOfficers
            // 
            this.cbSecurityOfficers.FormattingEnabled = true;
            this.cbSecurityOfficers.Location = new System.Drawing.Point(300, 139);
            this.cbSecurityOfficers.Name = "cbSecurityOfficers";
            this.cbSecurityOfficers.Size = new System.Drawing.Size(300, 23);
            this.cbSecurityOfficers.Sorted = true;
            this.cbSecurityOfficers.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Сотрудник СТАБ:";
            // 
            // cbCrewMembers
            // 
            this.cbCrewMembers.FormattingEnabled = true;
            this.cbCrewMembers.Location = new System.Drawing.Point(300, 268);
            this.cbCrewMembers.Name = "cbCrewMembers";
            this.cbCrewMembers.Size = new System.Drawing.Size(300, 23);
            this.cbCrewMembers.Sorted = true;
            this.cbCrewMembers.TabIndex = 7;
            // 
            // cbPositions
            // 
            this.cbPositions.FormattingEnabled = true;
            this.cbPositions.Location = new System.Drawing.Point(300, 183);
            this.cbPositions.Name = "cbPositions";
            this.cbPositions.Size = new System.Drawing.Size(300, 23);
            this.cbPositions.Sorted = true;
            this.cbPositions.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Член экипажа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Должность сотрудника СТАБ:";
            // 
            // panelProgress
            // 
            this.panelProgress.Location = new System.Drawing.Point(300, 71);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(700, 7);
            this.panelProgress.TabIndex = 27;
            this.panelProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProgress_Paint);
            // 
            // panelPassenger
            // 
            this.panelPassenger.BackColor = System.Drawing.SystemColors.Control;
            this.panelPassenger.Controls.Add(this.label16);
            this.panelPassenger.Controls.Add(this.label15);
            this.panelPassenger.Controls.Add(this.tbPassportWhenGiven);
            this.panelPassenger.Controls.Add(this.label14);
            this.panelPassenger.Controls.Add(this.tbPassportWhoGiven);
            this.panelPassenger.Controls.Add(this.label13);
            this.panelPassenger.Controls.Add(this.tbPassportNumber);
            this.panelPassenger.Controls.Add(this.label9);
            this.panelPassenger.Controls.Add(this.tbPassportSeria);
            this.panelPassenger.Controls.Add(this.label8);
            this.panelPassenger.Controls.Add(this.tbPassengerPatronymic);
            this.panelPassenger.Controls.Add(this.label12);
            this.panelPassenger.Controls.Add(this.tbPassengerName);
            this.panelPassenger.Controls.Add(this.label10);
            this.panelPassenger.Controls.Add(this.tbPassengerSurname);
            this.panelPassenger.Controls.Add(this.label11);
            this.panelPassenger.Location = new System.Drawing.Point(300, 100);
            this.panelPassenger.Name = "panelPassenger";
            this.panelPassenger.Size = new System.Drawing.Size(700, 500);
            this.panelPassenger.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(300, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 25);
            this.label16.TabIndex = 21;
            this.label16.Text = "Данные паспорта";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(300, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "Ф.И.О. пассажира";
            // 
            // tbPassportWhenGiven
            // 
            this.tbPassportWhenGiven.Location = new System.Drawing.Point(300, 401);
            this.tbPassportWhenGiven.Name = "tbPassportWhenGiven";
            this.tbPassportWhenGiven.Size = new System.Drawing.Size(300, 23);
            this.tbPassportWhenGiven.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(164, 404);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Когда выдан:";
            // 
            // tbPassportWhoGiven
            // 
            this.tbPassportWhoGiven.Location = new System.Drawing.Point(300, 363);
            this.tbPassportWhoGiven.Name = "tbPassportWhoGiven";
            this.tbPassportWhoGiven.Size = new System.Drawing.Size(300, 23);
            this.tbPassportWhoGiven.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Кем выдан:";
            // 
            // tbPassportNumber
            // 
            this.tbPassportNumber.Location = new System.Drawing.Point(300, 301);
            this.tbPassportNumber.Name = "tbPassportNumber";
            this.tbPassportNumber.Size = new System.Drawing.Size(300, 23);
            this.tbPassportNumber.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Номер:";
            // 
            // tbPassportSeria
            // 
            this.tbPassportSeria.Location = new System.Drawing.Point(300, 260);
            this.tbPassportSeria.Name = "tbPassportSeria";
            this.tbPassportSeria.Size = new System.Drawing.Size(300, 23);
            this.tbPassportSeria.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Серия:";
            // 
            // tbPassengerPatronymic
            // 
            this.tbPassengerPatronymic.Location = new System.Drawing.Point(300, 164);
            this.tbPassengerPatronymic.Name = "tbPassengerPatronymic";
            this.tbPassengerPatronymic.Size = new System.Drawing.Size(300, 23);
            this.tbPassengerPatronymic.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Отчество:";
            // 
            // tbPassengerName
            // 
            this.tbPassengerName.Location = new System.Drawing.Point(300, 125);
            this.tbPassengerName.Name = "tbPassengerName";
            this.tbPassengerName.Size = new System.Drawing.Size(300, 23);
            this.tbPassengerName.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Имя:";
            // 
            // tbPassengerSurname
            // 
            this.tbPassengerSurname.Location = new System.Drawing.Point(300, 84);
            this.tbPassengerSurname.Name = "tbPassengerSurname";
            this.tbPassengerSurname.Size = new System.Drawing.Size(300, 23);
            this.tbPassengerSurname.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Фамилия:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(737, 621);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panelFlight
            // 
            this.panelFlight.BackColor = System.Drawing.SystemColors.Control;
            this.panelFlight.Controls.Add(this.cbPlaneNumbers);
            this.panelFlight.Controls.Add(this.cbFlightNumbers);
            this.panelFlight.Controls.Add(this.cbArrivalAirports);
            this.panelFlight.Controls.Add(this.cbArrivalCities);
            this.panelFlight.Controls.Add(this.label17);
            this.panelFlight.Controls.Add(this.label18);
            this.panelFlight.Controls.Add(this.label19);
            this.panelFlight.Controls.Add(this.label20);
            this.panelFlight.Location = new System.Drawing.Point(300, 100);
            this.panelFlight.Name = "panelFlight";
            this.panelFlight.Size = new System.Drawing.Size(700, 500);
            this.panelFlight.TabIndex = 23;
            // 
            // cbPlaneNumbers
            // 
            this.cbPlaneNumbers.FormattingEnabled = true;
            this.cbPlaneNumbers.Location = new System.Drawing.Point(300, 230);
            this.cbPlaneNumbers.Name = "cbPlaneNumbers";
            this.cbPlaneNumbers.Size = new System.Drawing.Size(300, 23);
            this.cbPlaneNumbers.Sorted = true;
            this.cbPlaneNumbers.TabIndex = 9;
            // 
            // cbFlightNumbers
            // 
            this.cbFlightNumbers.FormattingEnabled = true;
            this.cbFlightNumbers.Location = new System.Drawing.Point(300, 96);
            this.cbFlightNumbers.Name = "cbFlightNumbers";
            this.cbFlightNumbers.Size = new System.Drawing.Size(300, 23);
            this.cbFlightNumbers.Sorted = true;
            this.cbFlightNumbers.TabIndex = 8;
            // 
            // cbArrivalAirports
            // 
            this.cbArrivalAirports.FormattingEnabled = true;
            this.cbArrivalAirports.Location = new System.Drawing.Point(300, 186);
            this.cbArrivalAirports.Name = "cbArrivalAirports";
            this.cbArrivalAirports.Size = new System.Drawing.Size(300, 23);
            this.cbArrivalAirports.Sorted = true;
            this.cbArrivalAirports.TabIndex = 7;
            // 
            // cbArrivalCities
            // 
            this.cbArrivalCities.FormattingEnabled = true;
            this.cbArrivalCities.Location = new System.Drawing.Point(300, 143);
            this.cbArrivalCities.Name = "cbArrivalCities";
            this.cbArrivalCities.Size = new System.Drawing.Size(300, 23);
            this.cbArrivalCities.Sorted = true;
            this.cbArrivalCities.TabIndex = 6;
            this.cbArrivalCities.SelectedValueChanged += new System.EventHandler(this.CbArrivalCities_SelectedValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(111, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 15);
            this.label17.TabIndex = 3;
            this.label17.Text = "Аэропорт назначения:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(132, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Город назначения:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(121, 234);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "Бортовой номер ВС:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(205, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Рейс:";
            // 
            // panelWeapon
            // 
            this.panelWeapon.BackColor = System.Drawing.SystemColors.Control;
            this.panelWeapon.Controls.Add(this.label25);
            this.panelWeapon.Controls.Add(this.tbWeaponBaggageTagNumber);
            this.panelWeapon.Controls.Add(this.label23);
            this.panelWeapon.Controls.Add(this.tbWeaponCharacteristics);
            this.panelWeapon.Controls.Add(this.label21);
            this.panelWeapon.Controls.Add(this.tbWeaponRegistrationNumber);
            this.panelWeapon.Controls.Add(this.cbWeaponTypes);
            this.panelWeapon.Controls.Add(this.cbWeaponModels);
            this.panelWeapon.Controls.Add(this.label22);
            this.panelWeapon.Controls.Add(this.label24);
            this.panelWeapon.Location = new System.Drawing.Point(300, 100);
            this.panelWeapon.Name = "panelWeapon";
            this.panelWeapon.Size = new System.Drawing.Size(700, 500);
            this.panelWeapon.TabIndex = 24;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(92, 275);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(149, 15);
            this.label25.TabIndex = 15;
            this.label25.Text = "Номера багажных бирок:";
            // 
            // tbWeaponBaggageTagNumber
            // 
            this.tbWeaponBaggageTagNumber.Location = new System.Drawing.Point(300, 272);
            this.tbWeaponBaggageTagNumber.Multiline = true;
            this.tbWeaponBaggageTagNumber.Name = "tbWeaponBaggageTagNumber";
            this.tbWeaponBaggageTagNumber.Size = new System.Drawing.Size(300, 50);
            this.tbWeaponBaggageTagNumber.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(104, 234);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 15);
            this.label23.TabIndex = 13;
            this.label23.Text = "Характерные признаки:";
            // 
            // tbWeaponCharacteristics
            // 
            this.tbWeaponCharacteristics.Location = new System.Drawing.Point(300, 231);
            this.tbWeaponCharacteristics.Name = "tbWeaponCharacteristics";
            this.tbWeaponCharacteristics.Size = new System.Drawing.Size(300, 23);
            this.tbWeaponCharacteristics.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(93, 189);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(149, 15);
            this.label21.TabIndex = 11;
            this.label21.Text = "Регистрационный номер:";
            // 
            // tbWeaponRegistrationNumber
            // 
            this.tbWeaponRegistrationNumber.Location = new System.Drawing.Point(300, 186);
            this.tbWeaponRegistrationNumber.Name = "tbWeaponRegistrationNumber";
            this.tbWeaponRegistrationNumber.Size = new System.Drawing.Size(300, 23);
            this.tbWeaponRegistrationNumber.TabIndex = 10;
            // 
            // cbWeaponTypes
            // 
            this.cbWeaponTypes.FormattingEnabled = true;
            this.cbWeaponTypes.Location = new System.Drawing.Point(300, 96);
            this.cbWeaponTypes.Name = "cbWeaponTypes";
            this.cbWeaponTypes.Size = new System.Drawing.Size(300, 23);
            this.cbWeaponTypes.Sorted = true;
            this.cbWeaponTypes.TabIndex = 8;
            this.cbWeaponTypes.SelectedValueChanged += new System.EventHandler(this.CbWeaponTypes_SelectedValueChanged);
            // 
            // cbWeaponModels
            // 
            this.cbWeaponModels.FormattingEnabled = true;
            this.cbWeaponModels.Location = new System.Drawing.Point(300, 143);
            this.cbWeaponModels.Name = "cbWeaponModels";
            this.cbWeaponModels.Size = new System.Drawing.Size(300, 23);
            this.cbWeaponModels.Sorted = true;
            this.cbWeaponModels.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(188, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 15);
            this.label22.TabIndex = 2;
            this.label22.Text = "Модель:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(211, 101);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 15);
            this.label24.TabIndex = 0;
            this.label24.Text = "Тип:";
            // 
            // panelAmmunition
            // 
            this.panelAmmunition.BackColor = System.Drawing.SystemColors.Control;
            this.panelAmmunition.Controls.Add(this.tbAmmunitionBaggageTagNumber);
            this.panelAmmunition.Controls.Add(this.label27);
            this.panelAmmunition.Controls.Add(this.tbAmmunitionWeight);
            this.panelAmmunition.Controls.Add(this.label26);
            this.panelAmmunition.Controls.Add(this.cbAmmunitions);
            this.panelAmmunition.Controls.Add(this.tbAmmunitionCount);
            this.panelAmmunition.Controls.Add(this.label28);
            this.panelAmmunition.Controls.Add(this.label29);
            this.panelAmmunition.Location = new System.Drawing.Point(300, 100);
            this.panelAmmunition.Name = "panelAmmunition";
            this.panelAmmunition.Size = new System.Drawing.Size(700, 500);
            this.panelAmmunition.TabIndex = 30;
            // 
            // tbAmmunitionBaggageTagNumber
            // 
            this.tbAmmunitionBaggageTagNumber.Location = new System.Drawing.Point(300, 215);
            this.tbAmmunitionBaggageTagNumber.Multiline = true;
            this.tbAmmunitionBaggageTagNumber.Name = "tbAmmunitionBaggageTagNumber";
            this.tbAmmunitionBaggageTagNumber.Size = new System.Drawing.Size(300, 50);
            this.tbAmmunitionBaggageTagNumber.TabIndex = 12;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(87, 219);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(149, 15);
            this.label27.TabIndex = 11;
            this.label27.Text = "Номера багажных бирок:";
            // 
            // tbAmmunitionWeight
            // 
            this.tbAmmunitionWeight.Location = new System.Drawing.Point(300, 178);
            this.tbAmmunitionWeight.Name = "tbAmmunitionWeight";
            this.tbAmmunitionWeight.Size = new System.Drawing.Size(300, 23);
            this.tbAmmunitionWeight.TabIndex = 10;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(207, 183);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 15);
            this.label26.TabIndex = 9;
            this.label26.Text = "Вес:";
            // 
            // cbAmmunitions
            // 
            this.cbAmmunitions.FormattingEnabled = true;
            this.cbAmmunitions.Location = new System.Drawing.Point(300, 99);
            this.cbAmmunitions.Name = "cbAmmunitions";
            this.cbAmmunitions.Size = new System.Drawing.Size(300, 23);
            this.cbAmmunitions.Sorted = true;
            this.cbAmmunitions.TabIndex = 8;
            // 
            // tbAmmunitionCount
            // 
            this.tbAmmunitionCount.Location = new System.Drawing.Point(300, 139);
            this.tbAmmunitionCount.Name = "tbAmmunitionCount";
            this.tbAmmunitionCount.Size = new System.Drawing.Size(300, 23);
            this.tbAmmunitionCount.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(164, 142);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 15);
            this.label28.TabIndex = 1;
            this.label28.Text = "Количество:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(211, 101);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 15);
            this.label29.TabIndex = 0;
            this.label29.Text = "Тип:";
            // 
            // panelSave
            // 
            this.panelSave.BackColor = System.Drawing.SystemColors.Control;
            this.panelSave.Controls.Add(this.btnReportAct);
            this.panelSave.Controls.Add(this.btnReportActAndPrint);
            this.panelSave.Location = new System.Drawing.Point(300, 100);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(700, 500);
            this.panelSave.TabIndex = 31;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(39, 604);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(133, 40);
            this.btnTest.TabIndex = 32;
            this.btnTest.Text = "Тест";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 669);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCreateNewReport);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelEmployees);
            this.Controls.Add(this.panelPassenger);
            this.Controls.Add(this.panelWeapon);
            this.Controls.Add(this.panelFlight);
            this.Controls.Add(this.panelAmmunition);
            this.Controls.Add(this.panelSave);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ReportForm_Paint);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelEmployees.ResumeLayout(false);
            this.panelEmployees.PerformLayout();
            this.panelPassenger.ResumeLayout(false);
            this.panelPassenger.PerformLayout();
            this.panelFlight.ResumeLayout(false);
            this.panelFlight.PerformLayout();
            this.panelWeapon.ResumeLayout(false);
            this.panelWeapon.PerformLayout();
            this.panelAmmunition.ResumeLayout(false);
            this.panelAmmunition.PerformLayout();
            this.panelSave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panelMain;
        private Button btnCreateNewReport;
        private ComboBox cbDepartureAirports;
        private ComboBox cbDepartureCities;
        private TextBox tbDate;
        private TextBox tbActNumber;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnNext;
        private Label title;
        private Panel panelEmployees;
        private ComboBox cbCrewMembers;
        private ComboBox cbPositions;
        private Label label5;
        private Label label6;
        private ComboBox cbSecurityOfficers;
        private Label label7;
        private Panel panelProgress;
        private Panel panelPassenger;
        private TextBox tbPassengerSurname;
        private Label label11;
        private TextBox tbPassengerPatronymic;
        private Label label12;
        private TextBox tbPassengerName;
        private Label label10;
        private TextBox tbPassportWhenGiven;
        private Label label14;
        private TextBox tbPassportWhoGiven;
        private Label label13;
        private TextBox tbPassportNumber;
        private Label label9;
        private TextBox tbPassportSeria;
        private Label label8;
        private Label label16;
        private Label label15;
        private Button btnClear;
        private Panel panelFlight;
        private ComboBox cbArrivalAirports;
        private ComboBox cbArrivalCities;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private ComboBox cbFlightNumbers;
        private ComboBox cbPlaneNumbers;
        private Panel panelWeapon;
        private ComboBox cbWeaponTypes;
        private ComboBox cbWeaponModels;
        private Label label22;
        private Label label24;
        private Label label21;
        private TextBox tbWeaponRegistrationNumber;
        private Label label23;
        private TextBox tbWeaponCharacteristics;
        private Label label25;
        private TextBox tbWeaponBaggageTagNumber;
        private Panel panelAmmunition;
        private TextBox tbAmmunitionCount;
        private Label label28;
        private Label label29;
        private ComboBox cbAmmunitions;
        private TextBox tbAmmunitionWeight;
        private Label label26;
        private TextBox tbAmmunitionBaggageTagNumber;
        private Label label27;
        private Button btnReportActAndPrint;
        private Button btnReportAct;
        private Panel panelSave;
        private Button btnTest;
    }
}