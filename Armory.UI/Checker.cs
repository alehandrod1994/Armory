using Armory.BL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Armory.UI
{
    public abstract class Checker
    {
        public static List<Control> CheckControlsOnNull(Control.ControlCollection controls)
        {
            List<Control> failedControls = new();

            foreach (Control control in controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    // TODO: Удаление лишних пробелов:
                    // tbAirportName.Text = tbAirportName.Text.Replace(" ", "");

                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        failedControls.Add(control);                       
                    }
                }
            }
           
            return failedControls;
        }

        public static List<Control> ParseIntControls(List<Control> controls)
        {
            List<Control> failedControls = new();
            foreach (Control control in controls)
            {
                if (Parser.ParseInt(control.Text) == null)
                {
                    failedControls.Add(control);
                }
            }
            return failedControls;
        }

        public static List<Control> ParseDoubleControls(List<Control> controls)
        {
            List<Control> failedControls = new();
            foreach (Control control in controls)
            {
                control.Text = control.Text.Replace('.', ',');

                if (Parser.ParseDouble(control.Text) == null)
                {
                    failedControls.Add(control);
                }
            }
            return failedControls;
        }

        public static List<Control> ParseDateTimeControls(List<Control> controls)
        {
            List<Control> failedControls = new();
            foreach (Control control in controls)
            {
                if (Parser.ParseDateTime(control.Text) == null)
                {
                    failedControls.Add(control);
                }
            }
            return failedControls;
        }

        public static List<Control> ParsePassengerPassport(Control passportSeria, Control passportNumber, Control whenGiven)
        {
            List<Control> faildControls = new();

            if (Parser.ParseInt(passportSeria.Text) == null || passportSeria.Text.Length != 4)
            {
                faildControls.Add(passportSeria);
            }

            if (Parser.ParseInt(passportNumber.Text) == null || passportNumber.Text.Length != 6)
            {
                faildControls.Add(passportNumber);
            }

            if (Parser.ParseDateTime(whenGiven.Text) == null)
            {
                faildControls.Add(whenGiven);
            }

            return faildControls;
        }
              
        public static void SetControlsToWhite(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.BackColor = Color.White;
                }
            }
        }

        public static void SetControlsToRed(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.BackColor = Color.LightCoral;
                }
            }
        }        
    }
}
