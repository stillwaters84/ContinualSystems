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
    public partial class C : Form
    {
        public C()
        {
            InitializeComponent();
        }

        private void IDC_NEXTС_BUTTON_Click(object sender, EventArgs e)
        {
            //checking valuables
            var list = new List<int> { int.Parse(m_nextc.Text), int.Parse(m_npc.Text), int.Parse(m_nmc.Text) };
            foreach (int elem in list)
            {
                if (elem < 0)
                {
                    MessageBox.Show("Введены неправильные значения");
                    return;
                }
            }
            if (float.Parse(m_zc.Text) < 0)
            {
                MessageBox.Show("Введены неправильные значения");
                return;
            }

            //main program
            else
            {
                int i = int.Parse(m_nextc.Text);
                GV.in_c[i, 0] = int.Parse(m_npc.Text);
                GV.in_c[i, 1] = int.Parse(m_nmc.Text);
                GV.z_c[i] = float.Parse(m_zc.Text);
                //MessageBox.Show(GV.in_c[i, 0].ToString() + " " + GV.in_c[i, 1].ToString() + " " + GV.z_c[i].ToString());
                i++;
                m_nextc.Text = i.ToString();
                if (i <= GV.nr)
                {
                    m_npc.Text = "0";
                    m_nmc.Text = "0";
                    m_zc.Text = "0";
                    m_npc.Focus();
                }
                else this.Close();
            }
        }
    }
}
