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
    public partial class Form6 : Form
    {
        cell[] cell_arr = new cell[10];
        Thread Insertionsort;
        Stopwatch watch = new Stopwatch();
        bool isrunning;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            cell_arr[0] = cell1;
            cell_arr[1] = cell2;
            cell_arr[2] = cell3;
            cell_arr[3] = cell4;
            cell_arr[4] = cell5;
            cell_arr[5] = cell6;
            cell_arr[6] = cell7;
            cell_arr[7] = cell8;
            cell_arr[8] = cell9;
            cell_arr[9] = cell10;
            for (int i = 0; i < cell_arr.Length; i++)
            {
                cell_arr[i].cellvalue = Form2.arr[i];
            }
            Insertionsort = new Thread(insertionsort);
        }

        void insertionsort()
        {
            isrunning = true;
            int inn, outt;
            watch.Start();
            for (outt = 1; outt < cell_arr.Length; outt++)
            {
                cell temp = cell_arr[outt];
                watch.Stop();
                cell_arr[outt].move_left();
                Thread.Sleep(2000);
                watch.Start();
                inn = outt;
                while (inn > 0 && cell_arr[inn - 1].cellvalue >= temp.cellvalue)
                {
                    watch.Stop();
                    Thread.Sleep(2000);
                    temp.move_up();
                    Thread.Sleep(2000);
                    cell_arr[inn - 1].move_down();
                    watch.Start();
                    swap(inn, inn - 1);


                    --inn;
                    watch.Stop();
                    Thread.Sleep(1000);
                }
                Thread.Sleep(2000);
         
                temp.insert();
               

                Thread.Sleep(2000);
                watch.Start();
            }

            MessageBox.Show("Time Taken=" + watch.Elapsed.TotalSeconds+" Seconds");
            isrunning = false;
        }

        void swap(int a, int b)
        {

            cell temp = cell_arr[a];
            cell_arr[a] = cell_arr[b];
            cell_arr[b] = temp;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (Insertionsort.ThreadState == System.Threading.ThreadState.Unstarted)
                    Insertionsort.Start();
                else
                    Insertionsort.Resume();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Insertionsort.Suspend();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.save = true;
            if (isrunning)
                Insertionsort.Suspend();
            f2.Show();
        }

    }
}
