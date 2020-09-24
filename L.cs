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
    public partial class L : Form
    {
        public L()
        {
            InitializeComponent();
        }

        private void IDC_NEXTL_BUTTON_Click(object sender, EventArgs e)
        {
            {
                //checking valuables
                var list = new List<int> { int.Parse(m_nextl.Text), int.Parse(m_npl.Text), int.Parse(m_nml.Text) };
                foreach (int elem in list)
                {
                    if (elem < 0)
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }
                }
                if (float.Parse(m_zl.Text) < 0)
                {
                    MessageBox.Show("Введены неправильные значения");
                    return;
                }

                //main program
                else
                {
                    int i = int.Parse(m_nextl.Text);
                    GV.in_l[i, 0] = int.Parse(m_npl.Text);
                    GV.in_l[i, 1] = int.Parse(m_nml.Text);
                    GV.z_l[i] = float.Parse(m_zl.Text);
                    //MessageBox.Show(GV.in_l[i, 0].ToString() + " " + GV.in_l[i, 1].ToString() + " " + GV.z_l[i].ToString());
                    i++;
                    m_nextl.Text = i.ToString();
                    if (i <= GV.nr)
                    {
                        m_npl.Text = "0";
                        m_nml.Text = "0";
                        m_zl.Text = "0";
                        m_npl.Focus();
                    }
                    else this.Close();
                }
            }
        }
    }
}
