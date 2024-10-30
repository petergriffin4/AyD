﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entradaejemplo
{
    public partial class Producto : MetroFramework.Forms.MetroForm
    {
        public Producto()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroToggle1.Checked)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            } else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }
    }
}
