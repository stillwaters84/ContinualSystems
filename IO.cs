﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GL
{
    public partial class IO : Form
    {
        public IO()
        {
            InitializeComponent();
        }

        private void IDC_IOOK_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                GV.lp = Int32.Parse(m_lp.Text);
                GV.lm = Int32.Parse(m_lm.Text);
                GV.kp = Int32.Parse(m_kp.Text);
                GV.km = Int32.Parse(m_km.Text);

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы неправильно ввели входные данные");
            }
        }
    }
}
