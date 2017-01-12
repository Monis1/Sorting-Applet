using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace SortingApplet
{
    public partial class Form4 : Form
    {
        Thread Selectionsort;
        vertBar[] vb = new vertBar[10];
        Stopwatch watch = new Stopwatch();
        bool isrunning;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            vb[0] = vertBar1;
            vb[1] = vertBar2;
            vb[2] = vertBar3;
            vb[3] = vertBar4;
            vb[4] = vertBar5;
            vb[5] = vertBar6;
            vb[6] = vertBar7;
            vb[7] = vertBar8;
            vb[8] = vertBar9;
            vb[9] = vertBar10;

            for (int i = 0; i < vb.Length; i++)
            {

                vb[i].value ( Form2.arr[i]);

            }
            Selectionsort = new Thread(selectionsort);

        }
        void selectionsort()
        {
            isrunning = true;
            int min;
            watch.Start();
            for (int i = 0; i < vb.Length - 1; i++)
            {
                min = i;
                watch.Stop();
                vb[i].mincolor();
                minval.Text = vb[i].uvalue.ToString();
                Thread.Sleep(200);
                watch.Start();
                for (int j = i + 1; j < vb.Length; j++)
                {
                    watch.Stop();
                    vb[j].changecolor();
                    Thread.Sleep(600);
                    vb[j].changecolor();
                    watch.Start();
                    if (vb[j].uvalue < vb[min].uvalue)
                    {

                        min = j;
                        watch.Stop();
                        minval.Text = "";
                        minval.Text = vb[j].uvalue.ToString();


                    }

                }
                Thread.Sleep(200);
                watch.Start();
                swapBar(vb[min], vb[i]);
                watch.Stop();
                minval.Text = "";
                vb[i].donecolor();
                watch.Start();
            }
            watch.Stop();
            vb[9].donecolor();
            MessageBox.Show("Time Taken=" + watch.Elapsed.TotalSeconds+" Seconds");
            isrunning = false;
        }
        void swapBar(vertBar a, vertBar b)
        {
            int temp = a.uvalue;
            a.value(b.uvalue);
            b.value(temp);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (Selectionsort.ThreadState == System.Threading.ThreadState.Unstarted)
                    Selectionsort.Start();
                else
                    Selectionsort.Resume();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Selectionsort.Suspend();
            }
            catch { }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.save = true;
            if (isrunning)
                Selectionsort.Suspend();
            f2.Show();
        }
    }
}
