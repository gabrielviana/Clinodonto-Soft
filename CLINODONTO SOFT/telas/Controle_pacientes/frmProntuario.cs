﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLINODONTO_SOFT.telas
{
    public partial class frmProntuario : Form
    {
        public frmProntuario()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new frmFicha_clinica().ShowDialog();
        }
    }
}
