﻿using Armory.BL.Model;
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
    public partial class AddCity : Form
    {
        public AddCity()
        {
            InitializeComponent();
        }

        public City? City { get; set; }
    }
}
