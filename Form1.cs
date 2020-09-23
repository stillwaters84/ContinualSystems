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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ID_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_CONS_Click(object sender, EventArgs e)
        {
            SIZE size = new SIZE();
            size.ShowDialog();
            size.Dispose();
            if(GV.nr > 0)
            {

            }
        }
    }
}
