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
    public partial class AddWeaponType : Form
    {
        public AddWeaponType()
        {
            InitializeComponent();
        }

        public WeaponType? WeaponType { get; set; }
    }
}