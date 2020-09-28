using System;
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
    public partial class R : Form
    {
        public R()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            //checking valuables
            List<int> list = new List<int>();
            float check;
            try
            {
                list = new List<int> { int.Parse(m_nextr.Text), int.Parse(m_npr.Text), int.Parse(m_nmr.Text) };
            }
            catch (Exception)
            {
                MessageBox.Show("Введены неправильные значения");
                return;
            }
            foreach(int elem in list)
            {
                if (elem < 0)
                {
                    MessageBox.Show("Введены неправильные значения");
                    return;
                }
            }
            if ( !float.TryParse(m_zr.Text, out check) || float.Parse(m_zr.Text) < 0)
            {
                MessageBox.Show("Введены неправильные значения");
                return;
            }

            //main program
            else
            {
                int i = int.Parse(m_nextr.Text);
                GV.in_r[i, 0] = int.Parse(m_npr.Text);
                GV.in_r[i, 1] = int.Parse(m_nmr.Text);
                GV.z_r[i] = float.Parse(m_zr.Text);
                //MessageBox.Show(GV.in_r[i, 0].ToString() + " " + GV.in_r[i, 1].ToString() + " " + GV.z_r[i].ToString());
                i++;
                m_nextr.Text = i.ToString();
                if (i <= GV.nr)
                {
                    m_npr.Text = "0";
                    m_nmr.Text = "0";
                    m_zr.Text = "0";
                    m_npr.Focus();
                }
                else this.Close();
            }
        }
    }
}
