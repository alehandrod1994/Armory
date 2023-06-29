namespace Armory.UI.Forms
{
    partial class MainForm
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
            this.btnCreateNewReport = new System.Windows.Forms.Button();
            this.btnShowDataForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateNewReport
            // 
            this.btnCreateNewReport.Location = new System.Drawing.Point(392, 252);
            this.btnCreateNewReport.Name = "btnCreateNewReport";
            this.btnCreateNewReport.Size = new System.Drawing.Size(217, 75);
            this.btnCreateNewReport.TabIndex = 0;
            this.btnCreateNewReport.Text = "Создать новый отчёт";
            this.btnCreateNewReport.UseVisualStyleBackColor = true;
            this.btnCreateNewReport.Click += new System.EventHandler(this.BtnCreateNewReport_Click);
            // 
            // btnShowDataForm
            // 
            this.btnShowDataForm.Location = new System.Drawing.Point(642, 252);
            this.btnShowDataForm.Name = "btnShowDataForm";
            this.btnShowDataForm.Size = new System.Drawing.Size(217, 75);
            this.btnShowDataForm.TabIndex = 1;
            this.btnShowDataForm.Text = "Открыть базу";
            this.btnShowDataForm.UseVisualStyleBackColor = true;
            this.btnShowDataForm.Click += new System.EventHandler(this.BtnShowDataForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 669);
            this.Controls.Add(this.btnShowDataForm);
            this.Controls.Add(this.btnCreateNewReport);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateNewReport;
        private Button btnShowDataForm;
    }
}