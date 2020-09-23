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
    public partial class SIZE : Form
    {
        public SIZE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checking invalid arguments without try-catch
            var list = new List<int> { int.Parse(NumOfNodes.Text), int.Parse(Resistors.Text), int.Parse(Capasitors.Text), int.Parse(Inductions.Text),
                int.Parse(ITUN.Text), int.Parse(ITUT.Text), int.Parse(INUN.Text), int.Parse(INUT.Text), int.Parse(BPTransistors.Text), int.Parse(YPTransistors.Text),
                int.Parse(OA.Text), int.Parse(Transformers.Text), int.Parse(IOA.Text), int.Parse(ITransformers.Text)};

            foreach (int elem in list)
            {
                if (elem < 0)
                {
                    MessageBox.Show("Введены неправильные значения");
                    return;
                }
            }

            //main program
            //yes, deena, i did it like that - change it if you want
            GV.nv = list.ElementAt(0);
            GV.nr = list.ElementAt(1);
            GV.nc = list.ElementAt(2);
            GV.nl = list.ElementAt(3);
            GV.itun = list.ElementAt(4);
            GV.itut = list.ElementAt(5);
            GV.inun = list.ElementAt(6);
            GV.inut = list.ElementAt(7);
            GV.bpt = list.ElementAt(8);
            GV.ypt = list.ElementAt(9);
            GV.oa = list.ElementAt(10);
            GV.tr = list.ElementAt(11);
            GV.ioa = list.ElementAt(12);
            GV.itr = list.ElementAt(13);
            MessageBox.Show(GV.nv.ToString() + " " + GV.nr.ToString() + " " + GV.nc.ToString() + " " + GV.nl.ToString());
            this.Close();
        }
    }
}
