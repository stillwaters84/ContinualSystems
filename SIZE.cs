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
    enum size
    {
        NumOfNodes, 
        Resistors, 
        Capasitors, 
        Inductions, 
        ITUN, 
        ITUT, 
        INUN, 
        INUT, 
        BPTransistors, 
        YPTransistors,
        OA,
        Transformers, 
        IOA, 
        ITransformers
    }
    public partial class SIZE : Form
    {
        public SIZE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checking invalid arguments without try-catch (working with stuff like "03 or 007")
            List<int> list = new List<int>();
            try
            {
                list.Add(int.Parse(NumOfNodes.Text));
                list.Add(int.Parse(Resistors.Text));
                list.Add(int.Parse(Capasitors.Text));
                list.Add(int.Parse(Inductions.Text));
                list.Add(int.Parse(ITUN.Text));
                list.Add(int.Parse(ITUT.Text));
                list.Add(int.Parse(INUN.Text));
                list.Add(int.Parse(INUT.Text));
                list.Add(int.Parse(BPTransistors.Text));
                list.Add(int.Parse(YPTransistors.Text));
                list.Add(int.Parse(OA.Text));
                list.Add(int.Parse(Transformers.Text));
                list.Add(int.Parse(IOA.Text));
                list.Add(int.Parse(ITransformers.Text));
            }
            catch (Exception err)
            {
                MessageBox.Show("Введены неправильные значения");
                return;
            }
            foreach (int elem in list)
            {
                if (elem < 0)
                {
                    MessageBox.Show("Введены неправильные значения");
                    return;
                }
            }

            //main program
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
            
            //MessageBox.Show(GV.nv.ToString() + " " + GV.nr.ToString() + " " + GV.nc.ToString() + " " + GV.nl.ToString());
            this.Close();
        }
    }
}
