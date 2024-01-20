using Armory.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armory.UI.Forms
{
    public partial class ImportDataForm : Form
    {
        private int _currentTabNumber;
        private int _maxTabNumber;
        private List<Tab>? _tabs;
        public ImportDataForm(ArmoryContext db)
        {
            InitializeComponent();

            Integrator = new Integrator(db);           

            _tabs = new List<Tab>()
            {
                new Tab(1, "Видео", panel1),
                new Tab(2, "Настройки", panel2)
            };

            _currentTabNumber = 1;
            _maxTabNumber = _tabs.Count;

            // TODO: Добавление columnsName в таблицу.

            
            

        }

        public Integrator Integrator { get; set; }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbRowNumber.Enabled = false;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tbRowNumber.Enabled = true;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                FileName = "",
                Filter = "Документ Excel (*.xls; *xlsx) | *.xls; *.xlsx",
                Title = "Выберите файл для импорта"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Integrator.Path = ofd.FileName;
                    tbPath.Text = Integrator.Path;
                }
                catch
                {
                    MessageBox.Show("Недопустимый формат файла");
                }
            }
        }

        private bool CheckTabControls()
        {
            Checker.SetControlsToWhite(panel2.Controls);

            List<Control> faildControls = new();
            List<Control> controls = new()
            {
                tbSheetNumber
            };

            if (radioButton2.Checked)
            {
                controls.Add(tbRowNumber);
            }

            faildControls.AddRange(Checker.CheckControlsOnNull(panel2.Controls));
            faildControls.AddRange(Checker.ParseIntControls(controls));

            if (faildControls.Count > 0)
            {
                Checker.SetControlsToRed(faildControls);
                MessageBox.Show("Неверно заполнены поля.");
                return false;
            }

            Integrator.SheetNumber = Convert.ToInt32(tbSheetNumber.Text);
            if (radioButton2.Checked)
            {
                Integrator.StartRow = Convert.ToInt32(tbRowNumber.Text);
            }

            return true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            _currentTabNumber = 2;
            OpenTab(_currentTabNumber);

            if (CheckTabControls())
            {
                DialogResult = DialogResult.OK;
            }           
        }

        private void OpenTab(int tabNumber)
        {
            if (tabNumber > _maxTabNumber)
            {
                return;
            }

            Panel panel = _tabs![tabNumber - 1].Panel;
            panel.BringToFront();
            panel.Show();

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

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            _currentTabNumber--;
            OpenTab(_currentTabNumber);         
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _currentTabNumber++;
            OpenTab(_currentTabNumber);
        }

     
    }
}
