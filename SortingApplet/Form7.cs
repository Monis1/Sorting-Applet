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

namespace SortingApplet
{
    public partial class Form7 : Form
    {
        cell[] c1 = new cell[5];
        cell[] c2 = new cell[5];
        Thread Merging;
        bool isrunning;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            c1[0] = cell1;
            c1[1] = cell2;
            c1[2] = cell3;
            c1[3] = cell4;
            c1[4] = cell5;
            c2[0] = cell6;
            c2[1] = cell7;
            c2[2] = cell8;
            c2[3] = cell9;
            c2[4] = cell10;
   
            for (int i = 0; i < c1.Length; i++)
            {
                c1[i].cellvalue = Form2.arr[i];
                c2[i].cellvalue = Form2.arr[i + 5];
                
            }
            exchangesort(ref c1);
            exchangesort(ref c2);
            Merging = new Thread(merging);
        }
        void merging()
        {
            isrunning = true;
            int i = 0,j=0;

            while (i <= 4&&j<=4)
            {
                if (c1[i].cellvalue < c2[j].cellvalue)
                {
              
                c1[i].merge_it(true);
                Thread.Sleep(5000);
                    i++;
                   
                }
                else
                {
                
                    c2[j].merge_it(false);
                    Thread.Sleep(5000);
                    j++;
                   
                }
                Thread.Sleep(4000);
            }

            
            while (i <= 4)
            {
            
                c1[i].merge_it(true);
                Thread.Sleep(5000);
                i++;
               
            }
            Thread.Sleep(5000);
            while (j <= 4)
            {
            
                c2[j].merge_it(false);
                Thread.Sleep(5000);
                j++;
               
            }

            isrunning = false;
        }

        void exchangesort(ref cell[] temp)
        {
            for (int i = 0; i < temp.Length-1; i++)
            {
                for (int j = i+1; j < temp.Length; j++)
                {
                    if(temp[j].cellvalue<temp[i].cellvalue)
                    { swap(temp[j], temp[i]); }
                }
            }
        
        
        }
        void swap(cell a, cell b)
        { int temp = a.cellvalue;
        a.cellvalue = b.cellvalue;
        b.cellvalue = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.save = true;
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (Merging.ThreadState == ThreadState.Unstarted)
                    Merging.Start();
                else
                   Merging.Resume();
            }
            catch { }
        }

        private void cell7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Merging.Suspend();
            }
            catch { }
        }

    }
}
