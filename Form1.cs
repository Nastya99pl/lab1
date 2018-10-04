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

            chart1.Series["Series1"].Points.Clear();

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
        public void Func()
        {
            teo = (h * h) / (2 * D);
            N = L / h;
            M = tmax / teo;
            t = 0;

            for (int i = 0; i < N; i++)
            {
                T_cur[i] = 0.0;
                T_next[i] = 0.0;
            }

            

            while (true)
            {
                t++;
                //T_cur[0] = (t * teo) / (1.0 + t * teo);
                T_cur[0] =  function()*teo*t ;
                for (int k = 1; k < N - 1; k++)
                {
                    T_next[k] = (teo * D / (h * h)) * T_cur[k + 1] + (1.0 - 2.0 * (teo * D / (h * h))) * T_cur[k] + (teo * D / (h * h)) * T_cur[k - 1];//каждый кадр пересчитывает массив точек
                }

                tmp = T_cur;
                T_cur = T_next;
                T_next = tmp;

                update_p();
            }

        }
    }
}
