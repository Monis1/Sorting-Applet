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
    public partial class Form3 : Form
    {
        Thread Bubblesort;
        vertBar[] vb = new vertBar[10];
        Stopwatch watch = new Stopwatch();
        bool isrunning;
        public Form3()
        {
            InitializeComponent();
        }

        private void vertBar11_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
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
            Bubblesort = new Thread(bubblesort);
            
        }
        void bubblesort()
        {
            isrunning = true;
            int x = 9, y = 9;
         

            
 watch.Start();
            do
            {
                for (int i = 1; i <= x; i++)
                {watch.Stop();
                    Thread.Sleep(180);
                    
                    vb[i - 1].changecolor();
                   
                    vb[i].changecolor();
                    Thread.Sleep(600);
                 watch.Start();
                    if (vb[i - 1].uvalue > vb[i].uvalue)
                    {watch.Stop();
                        vb[i - 1].changecolor();
                        vb[i].changecolor();

                        Thread.Sleep(300);
                        watch.Start();
                        swapBar(vb[i - 1], vb[i]);
                        watch.Stop();
                        vb[i - 1].changecolor();
                        vb[i].changecolor();
                    }
                    vb[i - 1].changecolor();
                    vb[i].changecolor();
                }
            
                vb[y].donecolor();
            
                
                y--;
                watch.Start();
            } while (--x > 0);
  watch.Stop();
            vb[0].donecolor();

            MessageBox.Show("Time Taken="+watch.Elapsed.TotalSeconds+" Seconds");
            isrunning = false;
        }
        void swapBar(vertBar a,vertBar b)
        {
            int temp = a.uvalue;
            a.value(b.uvalue);
            b.value(temp);
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (Bubblesort.ThreadState == System.Threading.ThreadState.Unstarted)
                    Bubblesort.Start();
        
                
                else
                    Bubblesort.Resume();
            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Bubblesort.Suspend();
            }
            catch { }
        }
       
     

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.save = true;
            if(isrunning)
            Bubblesort.Suspend();
            f2.Show();
          
        }

    }
}
