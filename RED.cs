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
    public partial class RED : Form
    {
        public RED()
        {
            InitializeComponent();
        }

        private void m_redlst_DoubleClick(object sender, EventArgs e)
        {
            String i1, i2, i3, i4, i5, i6, i7, i8, i9;
            m_np1.Show();
            m_nm1.Show();
            m_np2.Show();
            m_nm2.Show();
            m_z1.Show();
            m_z2.Show();
            m_z3.Show();
            m_z4.Show();
            m_z5.Show();
            m_z6.Show();
            IDC_NP1_STATIC.Show();
            IDC_NM1_STATIC.Show();
            IDC_NP2_STATIC.Show();
            IDC_NM2_STATIC.Show();
            IDC_Z1_STATIC.Show();
            IDC_Z2_STATIC.Show();
            IDC_Z3_STATIC.Show();
            IDC_Z4_STATIC.Show();
            IDC_Z5_STATIC.Show();
            IDC_Z6_STATIC.Show();
            m_np1.Text = "";
            m_nm1.Text = "";
            m_np2.Text = "";
            m_nm2.Text = "";
            m_z1.Text = "";
            m_z2.Text = "";
            m_z3.Text = "";
            m_z4.Text = "";
            m_z5.Text = "";
            m_z6.Text = "";
            //Выбор типа компонента из списка и настройка панели
            int idx = m_redlst.SelectedIndex;
            switch (idx)
            {
                case 0:
                    i1 = "n+";
                    i2 = "n-";
                    i3 = "КОм";
                    IDC_NP2_STATIC.Text = i1;
                    IDC_NM2_STATIC.Text = i2;
                    IDC_Z1_STATIC.Text = i3;
                    m_np1.Hide();
                    m_nm1.Hide();
                    m_z2.Hide();
                    m_z3.Hide();
                    m_z4.Hide();
                    m_z5.Hide();
                    m_z6.Hide();
                    IDC_NP1_STATIC.Hide();
                    IDC_NM1_STATIC.Hide();
                    IDC_Z2_STATIC.Hide();
                    IDC_Z3_STATIC.Hide();
                    IDC_Z4_STATIC.Hide();
                    IDC_Z5_STATIC.Hide();
                    IDC_Z6_STATIC.Hide();
                    m_n.Focus();
                    break;
                case 1:
                    i1 = "n+";
                    i2 = "n-";
                    i3 = "мкФ";
                    IDC_NP2_STATIC.Text = i1;
                    IDC_NM2_STATIC.Text = i2;
                    IDC_Z1_STATIC.Text = i3;
                    m_np1.Hide();
                    m_nm1.Hide();
                    m_z2.Hide();
                    m_z3.Hide();
                    m_z4.Hide();
                    m_z5.Hide();
                    m_z6.Hide();
                    IDC_NP1_STATIC.Hide();
                    IDC_NM1_STATIC.Hide();
                    IDC_Z2_STATIC.Hide();
                    IDC_Z3_STATIC.Hide();
                    IDC_Z4_STATIC.Hide();
                    IDC_Z5_STATIC.Hide();
                    IDC_Z6_STATIC.Hide();
                    m_n.Focus();
                    break;
                case 2:
                    i1 = "n+";
                    i2 = "n-";
                    i3 = "мГн";
                    IDC_NP2_STATIC.Text = i1;
                    IDC_NM2_STATIC.Text = i2;
                    IDC_Z1_STATIC.Text = i3;
                    m_np1.Hide();
                    m_nm1.Hide();
                    m_z2.Hide();
                    m_z3.Hide();
                    m_z4.Hide();
                    m_z5.Hide();
                    m_z6.Hide();
                    IDC_NP1_STATIC.Hide();
                    IDC_NM1_STATIC.Hide();
                    IDC_Z2_STATIC.Hide();
                    IDC_Z3_STATIC.Hide();
                    IDC_Z4_STATIC.Hide();
                    IDC_Z5_STATIC.Hide();
                    IDC_Z6_STATIC.Hide();
                    m_n.Focus();
                    break;
            }
        }

        private void IDC_OUT_BUTTON_Click(object sender, EventArgs e)
        {
            int idx = m_redlst.SelectedIndex;
            GV.k = int.Parse(m_n.Text);
            switch (idx)
            {
                case 0:
                    m_np2.Text = GV.in_r[GV.k, 0].ToString();
                    m_nm2.Text = GV.in_r[GV.k, 1].ToString();
                    m_z1.Text = GV.z_r[GV.k].ToString();
                    break;
                    OK.Focus();
                case 1:
                    m_np2.Text = GV.in_c[GV.k, 0].ToString();
                    m_nm2.Text = GV.in_c[GV.k, 1].ToString();
                    m_z1.Text = GV.z_c[GV.k].ToString();
                    break;
                    OK.Focus();
                case 2:
                    m_np2.Text = GV.in_l[GV.k, 0].ToString();
                    m_nm2.Text = GV.in_l[GV.k, 1].ToString();
                    m_z1.Text = GV.z_l[GV.k].ToString();
                    break;
                    OK.Focus();
            }
        }

        private void IDC_IN_BUTTON_Click(object sender, EventArgs e)
        {
            int idx = m_redlst.SelectedIndex;
            GV.k = int.Parse(m_n.Text);
            switch (idx)
            {
                case 0:
                    try
                    {
                        GV.in_r[GV.k, 0] = int.Parse(m_np2.Text);
                        GV.in_r[GV.k, 1] = int.Parse(m_nm2.Text);
                        GV.z_r[GV.k] = float.Parse(m_z1.Text);
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }
                    if ((GV.in_r[GV.k, 0] < 0 )|| (GV.in_r[GV.k, 1] < 0) || (GV.z_r[GV.k] < 0))
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }
                    break;
                case 1:
                    try
                    {
                        GV.in_c[GV.k, 0] = int.Parse(m_np2.Text);
                        GV.in_c[GV.k, 1] = int.Parse(m_nm2.Text);
                        GV.z_c[GV.k] = float.Parse(m_z1.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }
                    if ((GV.in_c[GV.k, 0] < 0) || (GV.in_c[GV.k, 1] < 0) || (GV.z_c[GV.k] < 0))
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }
                    break;
                case 2:
                    try
                    {
                        GV.in_l[GV.k, 0] = int.Parse(m_np2.Text);
                        GV.in_l[GV.k, 1] = int.Parse(m_nm2.Text);
                        GV.z_l[GV.k] = float.Parse(m_z1.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }
                    if ((GV.in_l[GV.k, 0] < 0) || (GV.in_l[GV.k, 1] < 0) || (GV.z_l[GV.k] < 0))
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }
                    break;
            }
            OK.Focus();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
