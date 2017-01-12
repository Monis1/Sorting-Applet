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
    public partial class Form5 : Form
    {
        Thread Exchangesort;
        Label[] l1 = new Label[10];
        Stopwatch watch = new Stopwatch();
        bool isrunning;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            pointer1.hide();
            ppointer1.hide();
            l1[0] = label2;
            l1[1] = label3;
            l1[2] = label4;
            l1[3] = label5;
            l1[4] = label6;
            l1[5] = label7;
            l1[6] = label8;
            l1[7] = label9;
            l1[8] = label10;
            l1[9] = label11;
            for (int i = 0; i < l1.Length; i++)
            {
                l1[i].Text = Form2.arr[i].ToString();
            }
            Exchangesort = new Thread(exchangesort);
        }
        void swap(Label a, Label b)
        {
            string text = a.Text;
            a.Text = "";
            a.Text = b.Text;
            b.Text = "";
            b.Text = text;
        }
        void exchangesort()
        {
            isrunning = true;
            pointer1.show();
            ppointer1.show();
            int y = 8;
            watch.Start();
            for (int i = 0; i < l1.Length - 1; i++)
            {

                for (int j = i + 1; j < l1.Length; j++)
                {
                    watch.Stop();
                    ppointer1.move();
                    Thread.Sleep(2000);
                    status.Text = "Compare " + l1[i].Text + " and " + l1[j].Text;
                    Thread.Sleep(2000);
                    watch.Start();
                    if (int.Parse(l1[j].Text) < int.Parse(l1[i].Text))
                    {
                        watch.Stop();
                        status.Text = "Swap " + l1[i].Text + " and " + l1[j].Text
                            ;
                        Thread.Sleep(2000);
                        watch.Start();
                        swap(l1[j], l1[i]);
                    }
                    watch.Stop();
                    status.Text = "";

                }
                if (i == 8)
                {
                    ppointer1.hide();
                    pointer1.hide();
                }
                pointer1.move();
                Thread.Sleep(2000);
                if (y > 0)
                {
                    ppointer1.gotoo(256 - 21 * y); y--;
                }
                watch.Start();
            }
            MessageBox.Show("Time Taken="+watch.Elapsed.TotalSeconds+" Seconds");
            isrunning = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (Exchangesort.ThreadState == System.Threading.ThreadState.Unstarted)
                    Exchangesort.Start();
                else
                    Exchangesort.Resume();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Exchangesort.Suspend();
            }
            catch { }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            this.Hide();
            f2.save = true;
            if (isrunning)
                Exchangesort.Suspend();
            f2.Show();
        }






        

    }
}
