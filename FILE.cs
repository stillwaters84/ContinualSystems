using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GL
{
    public partial class FILE : Form
    {
        public FILE()
        {
            InitializeComponent();
        }

        private void IDC_FILEOK_BUTTON_Click(object sender, EventArgs e)
        {
            switch (GV.k)
            { 
                case 0:
                    GV.filename = m_file.Text;
                    if (GV.filename != "")
                    {
                        fileout(GV.filename);
                    }
                    else
                    {
                        MessageBox.Show("Введите имя файла");
                    }
                    break;
                case 1:
                    GV.filename = m_file.Text;
                    try
                    {
                        MessageBox.Show("Элементы в первой строке файла вводятся по такому порядку: Узлы, Резисторы, Конденсаторы, Катушки");
                        filein(GV.filename);
                    }
                    catch (Exception err)
                    {
                        throw new Exception(err.Message);
                    }
                    break;
            }
            this.Close();
        }

        private void fileout(String filename) 
        {
            StreamWriter fout = new StreamWriter(GV.filename);
            String str = "";
            int i;
            str = GV.nv.ToString() + " " + GV.nr.ToString() + " " +  GV.nc.ToString() + " " + GV.nl.ToString();
            fout.WriteLine(str);
            //for R-elements
            for (i = 1; i <= GV.nr; i++)
            {
                str = GV.in_r[i, 0].ToString() + " " + GV.in_r[i, 1].ToString() + " "
                + GV.z_r[i].ToString();
                fout.WriteLine(str);
            }
            //for C-elements
            for (i = 1; i <= GV.nc; i++)
            {
                str = GV.in_c[i, 0].ToString() + " " + GV.in_c[i, 1].ToString() + " "
                + GV.z_c[i].ToString();
                fout.WriteLine(str);
            }
            //for L-elements
            for (i = 1; i <= GV.nl; i++)
            {
                str = GV.in_l[i, 0].ToString() + " " + GV.in_l[i, 1].ToString() + " "
                + GV.z_l[i].ToString();
                fout.WriteLine(str);
            }
            fout.Close();
        }

        private void filein(String filename) 
        {
            StreamReader fin = new StreamReader(GV.filename);
            char[] sep = { ' ' };
            string str = "";
            str = fin.ReadLine();
            String[] s;
            try
            {
                s = str.Split(sep, 4);
                GV.nv = int.Parse(s[0]);
                GV.nr = int.Parse(s[1]);
                GV.nc = int.Parse(s[2]);
                GV.nl = int.Parse(s[3]);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в количестве элементов. Если какие-то элементы не присутствуют в схеме, то введите в первую строку файла значение 0");
                fin.Close();
                return;
            }
            for (int i = 1; i <= GV.nr; i++)
            {
                str = fin.ReadLine();
                try
                {
                    s = str.Split(sep, 3);
                    GV.in_r[i, 0] = int.Parse(s[0]);
                    GV.in_r[i, 1] = int.Parse(s[1]);
                    GV.z_r[i] = float.Parse(s[2]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в введённых резисторах");
                    fin.Close();
                    return;
                }
            }

            for (int i = 1; i <= GV.nc; i++)
            {
                str = fin.ReadLine();
                try
                {
                    s = str.Split(sep, 3);
                    GV.in_c[i, 0] = int.Parse(s[0]);
                    GV.in_c[i, 1] = int.Parse(s[1]);
                    GV.z_c[i] = float.Parse(s[2]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в введённых конденсаторах");
                    fin.Close();
                    return;
                }
            }

            for (int i = 1; i <= GV.nl; i++)
            {
                str = fin.ReadLine();
                try
                {
                    s = str.Split(sep, 3);
                    GV.in_l[i, 0] = int.Parse(s[0]);
                    GV.in_l[i, 1] = int.Parse(s[1]);
                    GV.z_l[i] = float.Parse(s[2]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в введённых катушках");
                    fin.Close();
                    return;
                }
            }
            MessageBox.Show("Значения успешно введены");
            fin.Close();
        }
    }
}
