﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_GUI
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            AddNV addNV = new AddNV();
            addNV.Show();
        }
    }
}
