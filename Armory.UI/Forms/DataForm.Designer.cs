namespace Armory.UI
{
    partial class DataForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenActs = new System.Windows.Forms.Button();
            this.btnOpenAirports = new System.Windows.Forms.Button();
            this.btnOpenAmmunitions = new System.Windows.Forms.Button();
            this.btnOpenCities = new System.Windows.Forms.Button();
            this.btnOpenCrewMembers = new System.Windows.Forms.Button();
            this.btnOpenFlights = new System.Windows.Forms.Button();
            this.btnOpenPlanes = new System.Windows.Forms.Button();
            this.btnOpenPositions = new System.Windows.Forms.Button();
            this.btnOpenSecurityOfficers = new System.Windows.Forms.Button();
            this.btnOpenWeapons = new System.Windows.Forms.Button();
            this.btnOpenWeaponTypes = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tableName = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenActs
            // 
            this.btnOpenActs.Location = new System.Drawing.Point(182, 124);
            this.btnOpenActs.Name = "btnOpenActs";
            this.btnOpenActs.Size = new System.Drawing.Size(100, 23);
            this.btnOpenActs.TabIndex = 0;
            this.btnOpenActs.Text = "Акты";
            this.btnOpenActs.UseVisualStyleBackColor = true;
            this.btnOpenActs.Click += new System.EventHandler(this.BtnOpenActs_Click);
            // 
            // btnOpenAirports
            // 
            this.btnOpenAirports.Location = new System.Drawing.Point(182, 153);
            this.btnOpenAirports.Name = "btnOpenAirports";
            this.btnOpenAirports.Size = new System.Drawing.Size(100, 23);
            this.btnOpenAirports.TabIndex = 1;
            this.btnOpenAirports.Text = "Аэропорты";
            this.btnOpenAirports.UseVisualStyleBackColor = true;
            this.btnOpenAirports.Click += new System.EventHandler(this.BtnOpenAirports_Click);
            // 
            // btnOpenAmmunitions
            // 
            this.btnOpenAmmunitions.Location = new System.Drawing.Point(182, 182);
            this.btnOpenAmmunitions.Name = "btnOpenAmmunitions";
            this.btnOpenAmmunitions.Size = new System.Drawing.Size(100, 23);
            this.btnOpenAmmunitions.TabIndex = 2;
            this.btnOpenAmmunitions.Text = "Патроны";
            this.btnOpenAmmunitions.UseVisualStyleBackColor = true;
            this.btnOpenAmmunitions.Click += new System.EventHandler(this.BtnOpenAmmunitions_Click);
            // 
            // btnOpenCities
            // 
            this.btnOpenCities.Location = new System.Drawing.Point(182, 211);
            this.btnOpenCities.Name = "btnOpenCities";
            this.btnOpenCities.Size = new System.Drawing.Size(100, 23);
            this.btnOpenCities.TabIndex = 3;
            this.btnOpenCities.Text = "Города";
            this.btnOpenCities.UseVisualStyleBackColor = true;
            this.btnOpenCities.Click += new System.EventHandler(this.BtnOpenCities_Click);
            // 
            // btnOpenCrewMembers
            // 
            this.btnOpenCrewMembers.Location = new System.Drawing.Point(182, 240);
            this.btnOpenCrewMembers.Name = "btnOpenCrewMembers";
            this.btnOpenCrewMembers.Size = new System.Drawing.Size(100, 23);
            this.btnOpenCrewMembers.TabIndex = 4;
            this.btnOpenCrewMembers.Text = "Экипаж";
            this.btnOpenCrewMembers.UseVisualStyleBackColor = true;
            this.btnOpenCrewMembers.Click += new System.EventHandler(this.BtnOpenCrewMembers_Click);
            // 
            // btnOpenFlights
            // 
            this.btnOpenFlights.Location = new System.Drawing.Point(182, 269);
            this.btnOpenFlights.Name = "btnOpenFlights";
            this.btnOpenFlights.Size = new System.Drawing.Size(100, 23);
            this.btnOpenFlights.TabIndex = 5;
            this.btnOpenFlights.Text = "Рейсы";
            this.btnOpenFlights.UseVisualStyleBackColor = true;
            this.btnOpenFlights.Click += new System.EventHandler(this.BtnOpenFlights_Click);
            // 
            // btnOpenPlanes
            // 
            this.btnOpenPlanes.Location = new System.Drawing.Point(182, 298);
            this.btnOpenPlanes.Name = "btnOpenPlanes";
            this.btnOpenPlanes.Size = new System.Drawing.Size(100, 23);
            this.btnOpenPlanes.TabIndex = 6;
            this.btnOpenPlanes.Text = "Самолёты";
            this.btnOpenPlanes.UseVisualStyleBackColor = true;
            this.btnOpenPlanes.Click += new System.EventHandler(this.BtnOpenPlanes_Click);
            // 
            // btnOpenPositions
            // 
            this.btnOpenPositions.Location = new System.Drawing.Point(182, 327);
            this.btnOpenPositions.Name = "btnOpenPositions";
            this.btnOpenPositions.Size = new System.Drawing.Size(100, 23);
            this.btnOpenPositions.TabIndex = 7;
            this.btnOpenPositions.Text = "Должности";
            this.btnOpenPositions.UseVisualStyleBackColor = true;
            this.btnOpenPositions.Click += new System.EventHandler(this.BtnOpenPositions_Click);
            // 
            // btnOpenSecurityOfficers
            // 
            this.btnOpenSecurityOfficers.Location = new System.Drawing.Point(182, 356);
            this.btnOpenSecurityOfficers.Name = "btnOpenSecurityOfficers";
            this.btnOpenSecurityOfficers.Size = new System.Drawing.Size(100, 23);
            this.btnOpenSecurityOfficers.TabIndex = 8;
            this.btnOpenSecurityOfficers.Text = "Сотрудники СТАБ";
            this.btnOpenSecurityOfficers.UseVisualStyleBackColor = true;
            this.btnOpenSecurityOfficers.Click += new System.EventHandler(this.BtnOpenSecurityOfficers_Click);
            // 
            // btnOpenWeapons
            // 
            this.btnOpenWeapons.Location = new System.Drawing.Point(182, 385);
            this.btnOpenWeapons.Name = "btnOpenWeapons";
            this.btnOpenWeapons.Size = new System.Drawing.Size(100, 23);
            this.btnOpenWeapons.TabIndex = 9;
            this.btnOpenWeapons.Text = "Оружие";
            this.btnOpenWeapons.UseVisualStyleBackColor = true;
            this.btnOpenWeapons.Click += new System.EventHandler(this.BtnOpenWeapons_Click);
            // 
            // btnOpenWeaponTypes
            // 
            this.btnOpenWeaponTypes.Location = new System.Drawing.Point(182, 414);
            this.btnOpenWeaponTypes.Name = "btnOpenWeaponTypes";
            this.btnOpenWeaponTypes.Size = new System.Drawing.Size(100, 23);
            this.btnOpenWeaponTypes.TabIndex = 10;
            this.btnOpenWeaponTypes.Text = "Типы оружия";
            this.btnOpenWeaponTypes.UseVisualStyleBackColor = true;
            this.btnOpenWeaponTypes.Click += new System.EventHandler(this.BtnOpenWeaponTypes_Click);
            // 
            // table
            // 
            this.table.AllowDrop = true;
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(401, 124);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowTemplate.Height = 25;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(666, 313);
            this.table.TabIndex = 11;
            this.table.DragDrop += new System.Windows.Forms.DragEventHandler(this.Table_DragDrop);
            this.table.DragEnter += new System.Windows.Forms.DragEventHandler(this.Table_DragEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(430, 483);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(654, 483);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(139, 36);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(865, 483);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(139, 36);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableName.Location = new System.Drawing.Point(401, 92);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(144, 21);
            this.tableName.TabIndex = 15;
            this.tableName.Text = "Название таблицы";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(992, 90);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Импорт";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 669);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btnOpenWeaponTypes);
            this.Controls.Add(this.btnOpenWeapons);
            this.Controls.Add(this.btnOpenSecurityOfficers);
            this.Controls.Add(this.btnOpenPositions);
            this.Controls.Add(this.btnOpenPlanes);
            this.Controls.Add(this.btnOpenFlights);
            this.Controls.Add(this.btnOpenCrewMembers);
            this.Controls.Add(this.btnOpenCities);
            this.Controls.Add(this.btnOpenAmmunitions);
            this.Controls.Add(this.btnOpenAirports);
            this.Controls.Add(this.btnOpenActs);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DataForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpenActs;
        private Button btnOpenAirports;
        private Button btnOpenAmmunitions;
        private Button btnOpenCities;
        private Button btnOpenCrewMembers;
        private Button btnOpenFlights;
        private Button btnOpenPlanes;
        private Button btnOpenPositions;
        private Button btnOpenSecurityOfficers;
        private Button btnOpenWeapons;
        private Button btnOpenWeaponTypes;
        private DataGridView table;
        private Button btnAdd;
        private Button btnChange;
        private Button btnRemove;
        private Label tableName;
        private Button btnImport;
    }
}