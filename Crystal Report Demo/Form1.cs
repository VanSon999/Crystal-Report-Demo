﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crystal_Report_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 crpt = new CrystalReport1(); //Create object of Crystal Report
            crystalReportViewer1.ReportSource = null; //refresh resoure report of viewer1
            crystalReportViewer1.ReportSource = crpt; //loaded Crystal Report into Viewer
        }
    }
}
