using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        double M, N, t = 0;
        double h = 0.02;
        

        double[] T_next = new double[50];
        double[] T_cur = new double[50];

        
        public Form1()
        {
            InitializeComponent();
        }


        public void update_p()
        {

            
            for (int i = 0; i < 50; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i * h, T_cur[i]);
            }

            chart1.Update();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Visible = true;
            Func();
        }

        public double function()
        {
            return -2;
        }

        }
    }
}
