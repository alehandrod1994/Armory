using Armory.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armory.UI
{
    public partial class AddSecurityOfficer : Form
    {
        public AddSecurityOfficer()
        {
            InitializeComponent();
        }

        public SecurityOfficer? SecurityOfficer { get; set; }
    }
}
