namespace Armory.UI.Forms
{
    partial class AddAct
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
            this.btnClose = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbArrivalAirports = new System.Windows.Forms.ComboBox();
            this.tbWeaponRegistrationNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbWeapons = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWeaponTypes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWeaponCharacteristics = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbWeaponBaggageTagNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAmmunitions = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAmmunitionCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAmmunitionWeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSecurityOfficers = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPositions = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbDepartureCities = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbArrivalCities = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbFlights = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbPlanes = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbCrewMembers = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbAmmunitionBaggageTagNumber = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbDepartureAirports = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(436, 876);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(321, 876);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(92, 23);
            this.bntSave.TabIndex = 6;
            this.bntSave.Text = "Сохранить";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.BntSave_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.Color.White;
            this.tbNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbNumber.Location = new System.Drawing.Point(280, 37);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(231, 23);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите номер акта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название аэропорта назначения:";
            // 
            // cbArrivalAirports
            // 
            this.cbArrivalAirports.FormattingEnabled = true;
            this.cbArrivalAirports.Location = new System.Drawing.Point(280, 99);
            this.cbArrivalAirports.Name = "cbArrivalAirports";
            this.cbArrivalAirports.Size = new System.Drawing.Size(231, 23);
            this.cbArrivalAirports.Sorted = true;
            this.cbArrivalAirports.TabIndex = 2;
            // 
            // tbWeaponRegistrationNumber
            // 
            this.tbWeaponRegistrationNumber.BackColor = System.Drawing.Color.White;
            this.tbWeaponRegistrationNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbWeaponRegistrationNumber.Location = new System.Drawing.Point(280, 233);
            this.tbWeaponRegistrationNumber.Name = "tbWeaponRegistrationNumber";
            this.tbWeaponRegistrationNumber.Size = new System.Drawing.Size(231, 23);
            this.tbWeaponRegistrationNumber.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите регистрационный номер оружия:";
            // 
            // cbWeapons
            // 
            this.cbWeapons.FormattingEnabled = true;
            this.cbWeapons.Location = new System.Drawing.Point(280, 141);
            this.cbWeapons.Name = "cbWeapons";
            this.cbWeapons.Size = new System.Drawing.Size(231, 23);
            this.cbWeapons.Sorted = true;
            this.cbWeapons.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите модель оружия:";
            // 
            // cbWeaponTypes
            // 
            this.cbWeaponTypes.FormattingEnabled = true;
            this.cbWeaponTypes.Location = new System.Drawing.Point(280, 186);
            this.cbWeaponTypes.Name = "cbWeaponTypes";
            this.cbWeaponTypes.Size = new System.Drawing.Size(231, 23);
            this.cbWeaponTypes.Sorted = true;
            this.cbWeaponTypes.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Введите тип оружия:";
            // 
            // tbWeaponCharacteristics
            // 
            this.tbWeaponCharacteristics.BackColor = System.Drawing.Color.White;
            this.tbWeaponCharacteristics.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbWeaponCharacteristics.Location = new System.Drawing.Point(280, 272);
            this.tbWeaponCharacteristics.Name = "tbWeaponCharacteristics";
            this.tbWeaponCharacteristics.Size = new System.Drawing.Size(231, 23);
            this.tbWeaponCharacteristics.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Введите характеристики оружия:";
            // 
            // tbWeaponBaggageTagNumber
            // 
            this.tbWeaponBaggageTagNumber.BackColor = System.Drawing.Color.White;
            this.tbWeaponBaggageTagNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbWeaponBaggageTagNumber.Location = new System.Drawing.Point(280, 310);
            this.tbWeaponBaggageTagNumber.Name = "tbWeaponBaggageTagNumber";
            this.tbWeaponBaggageTagNumber.Size = new System.Drawing.Size(231, 23);
            this.tbWeaponBaggageTagNumber.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Введите номер багажных бирок оружия:";
            // 
            // cbAmmunitions
            // 
            this.cbAmmunitions.FormattingEnabled = true;
            this.cbAmmunitions.Location = new System.Drawing.Point(280, 351);
            this.cbAmmunitions.Name = "cbAmmunitions";
            this.cbAmmunitions.Size = new System.Drawing.Size(231, 23);
            this.cbAmmunitions.Sorted = true;
            this.cbAmmunitions.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Введите тип патронов:";
            // 
            // tbAmmunitionCount
            // 
            this.tbAmmunitionCount.BackColor = System.Drawing.Color.White;
            this.tbAmmunitionCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAmmunitionCount.Location = new System.Drawing.Point(280, 391);
            this.tbAmmunitionCount.Name = "tbAmmunitionCount";
            this.tbAmmunitionCount.Size = new System.Drawing.Size(231, 23);
            this.tbAmmunitionCount.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Введите количество патронов:";
            // 
            // tbAmmunitionWeight
            // 
            this.tbAmmunitionWeight.BackColor = System.Drawing.Color.White;
            this.tbAmmunitionWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAmmunitionWeight.Location = new System.Drawing.Point(280, 433);
            this.tbAmmunitionWeight.Name = "tbAmmunitionWeight";
            this.tbAmmunitionWeight.Size = new System.Drawing.Size(231, 23);
            this.tbAmmunitionWeight.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Введите вес патронов:";
            // 
            // cbSecurityOfficers
            // 
            this.cbSecurityOfficers.FormattingEnabled = true;
            this.cbSecurityOfficers.Location = new System.Drawing.Point(280, 520);
            this.cbSecurityOfficers.Name = "cbSecurityOfficers";
            this.cbSecurityOfficers.Size = new System.Drawing.Size(231, 23);
            this.cbSecurityOfficers.Sorted = true;
            this.cbSecurityOfficers.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Введите Ф.И.О. сотрудника СТАБ:";
            // 
            // cbPositions
            // 
            this.cbPositions.FormattingEnabled = true;
            this.cbPositions.Location = new System.Drawing.Point(280, 563);
            this.cbPositions.Name = "cbPositions";
            this.cbPositions.Size = new System.Drawing.Size(231, 23);
            this.cbPositions.Sorted = true;
            this.cbPositions.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 563);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Введите должность сотрудника СТАБ:";
            // 
            // cbDepartureCities
            // 
            this.cbDepartureCities.FormattingEnabled = true;
            this.cbDepartureCities.Location = new System.Drawing.Point(280, 604);
            this.cbDepartureCities.Name = "cbDepartureCities";
            this.cbDepartureCities.Size = new System.Drawing.Size(231, 23);
            this.cbDepartureCities.Sorted = true;
            this.cbDepartureCities.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 604);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Введите город отправления:";
            // 
            // cbArrivalCities
            // 
            this.cbArrivalCities.FormattingEnabled = true;
            this.cbArrivalCities.Location = new System.Drawing.Point(280, 642);
            this.cbArrivalCities.Name = "cbArrivalCities";
            this.cbArrivalCities.Size = new System.Drawing.Size(231, 23);
            this.cbArrivalCities.Sorted = true;
            this.cbArrivalCities.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 642);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Введите город прибытия:";
            // 
            // cbFlights
            // 
            this.cbFlights.FormattingEnabled = true;
            this.cbFlights.Location = new System.Drawing.Point(280, 681);
            this.cbFlights.Name = "cbFlights";
            this.cbFlights.Size = new System.Drawing.Size(231, 23);
            this.cbFlights.Sorted = true;
            this.cbFlights.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 681);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "Введите номер рейса:";
            // 
            // cbPlanes
            // 
            this.cbPlanes.FormattingEnabled = true;
            this.cbPlanes.Location = new System.Drawing.Point(280, 721);
            this.cbPlanes.Name = "cbPlanes";
            this.cbPlanes.Size = new System.Drawing.Size(231, 23);
            this.cbPlanes.Sorted = true;
            this.cbPlanes.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 721);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(203, 15);
            this.label16.TabIndex = 36;
            this.label16.Text = "Введите бортовой номер самолёта:";
            // 
            // cbCrewMembers
            // 
            this.cbCrewMembers.FormattingEnabled = true;
            this.cbCrewMembers.Location = new System.Drawing.Point(280, 760);
            this.cbCrewMembers.Name = "cbCrewMembers";
            this.cbCrewMembers.Size = new System.Drawing.Size(231, 23);
            this.cbCrewMembers.Sorted = true;
            this.cbCrewMembers.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 760);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 15);
            this.label17.TabIndex = 38;
            this.label17.Text = "Введите Ф.И.О. члена экипажа:";
            // 
            // tbAmmunitionBaggageTagNumber
            // 
            this.tbAmmunitionBaggageTagNumber.BackColor = System.Drawing.Color.White;
            this.tbAmmunitionBaggageTagNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAmmunitionBaggageTagNumber.Location = new System.Drawing.Point(280, 477);
            this.tbAmmunitionBaggageTagNumber.Name = "tbAmmunitionBaggageTagNumber";
            this.tbAmmunitionBaggageTagNumber.Size = new System.Drawing.Size(231, 23);
            this.tbAmmunitionBaggageTagNumber.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 480);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(242, 15);
            this.label18.TabIndex = 40;
            this.label18.Text = "Введите номер багажных бирок патронов:";
            // 
            // cbDepartureAirports
            // 
            this.cbDepartureAirports.FormattingEnabled = true;
            this.cbDepartureAirports.Location = new System.Drawing.Point(280, 70);
            this.cbDepartureAirports.Name = "cbDepartureAirports";
            this.cbDepartureAirports.Size = new System.Drawing.Size(231, 23);
            this.cbDepartureAirports.Sorted = true;
            this.cbDepartureAirports.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(65, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 15);
            this.label19.TabIndex = 42;
            this.label19.Text = "Название аэропорта отправления:";
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.White;
            this.tbDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbDate.Location = new System.Drawing.Point(280, 804);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(231, 23);
            this.tbDate.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(197, 812);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 15);
            this.label20.TabIndex = 44;
            this.label20.Text = "Дата:";
            // 
            // AddAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 922);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbDepartureAirports);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbAmmunitionBaggageTagNumber);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbCrewMembers);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbPlanes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbFlights);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbArrivalCities);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbDepartureCities);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbPositions);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbSecurityOfficers);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbAmmunitionWeight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbAmmunitionCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbAmmunitions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbWeaponBaggageTagNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbWeaponCharacteristics);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbWeaponTypes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbWeapons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbWeaponRegistrationNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbArrivalAirports);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label1);
            this.Name = "AddAct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление акта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button bntSave;
        private TextBox tbNumber;
        private Label label1;
        private Label label2;
        private ComboBox cbArrivalAirports;
        private TextBox tbWeaponRegistrationNumber;
        private Label label3;
        private ComboBox cbWeapons;
        private Label label4;
        private ComboBox cbWeaponTypes;
        private Label label5;
        private TextBox tbWeaponCharacteristics;
        private Label label6;
        private TextBox tbWeaponBaggageTagNumber;
        private Label label7;
        private ComboBox cbAmmunitions;
        private Label label8;
        private TextBox tbAmmunitionCount;
        private Label label9;
        private TextBox tbAmmunitionWeight;
        private Label label10;
        private ComboBox cbSecurityOfficers;
        private Label label11;
        private ComboBox cbPositions;
        private Label label12;
        private ComboBox cbDepartureCities;
        private Label label13;
        private ComboBox cbArrivalCities;
        private Label label14;
        private ComboBox cbFlights;
        private Label label15;
        private ComboBox cbPlanes;
        private Label label16;
        private ComboBox cbCrewMembers;
        private Label label17;
        private TextBox tbAmmunitionBaggageTagNumber;
        private Label label18;
        private ComboBox cbDepartureAirports;
        private Label label19;
        private TextBox tbDate;
        private Label label20;
    }
}