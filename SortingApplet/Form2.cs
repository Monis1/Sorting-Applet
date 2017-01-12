using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingApplet
{
    public partial class Form2 : Form
    {
        Label[] l1 = new Label[10];
        public static int[] arr = new int[10];
        public bool save;
        Random R = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
            if (save)
                for (int i = 0; i < l1.Length; i++)
                    l1[i].Text = arr[i].ToString();
                
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < l1.Length; i++)
            {
                l1[i].Text = "";
            }
        }

        private void Randomise_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < l1.Length; i++)
            {

                l1[i].Text = R.Next(300).ToString();

            }
        }

        private void Inputbox_KeyDown(object sender, KeyEventArgs e)
        {
            int range;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                   range= Convert.ToInt32(Inputbox.Text);
                   if (range > 10000 || range < -9999)
                   { throw new IndexOutOfRangeException(); }
                }
                catch
                {
                    MessageBox.Show("Invalid Input...", "ERROR!");
                    Inputbox.Text = "";
                    return;
                }


                for (int i = 0; i < l1.Length; i++)
                {
                    if (l1[i].Text == "")
                    {
                        l1[i].Text = Inputbox.Text;
                        Inputbox.Text = "";
                        break;
                    }



                }
            
            
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        void array()
        {
            for (int i = 0; i < l1.Length; i++)
            {
                arr[i] = Convert.ToInt32(l1[i].Text);
            }
        }
        private void Bubblesort_Click(object sender, EventArgs e)
        {
            if (label11.Text == "")
            { MessageBox.Show("Array is not full...", "ERROR!"); return; }
            array();
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();


        }

        private void Selectionsort_Click(object sender, EventArgs e)
        {

            if (label11.Text == "")
            { MessageBox.Show("Array is not full...", "ERROR!"); return; }
            array();
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();

        }

        private void Exchangesort_Click(object sender, EventArgs e)
        {
            if (label11.Text == "")
            { MessageBox.Show("Array is not full...", "ERROR!"); return; }
            array();
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();


        }

        private void Insertionsort_Click(object sender, EventArgs e)
        {

            if (label11.Text == "")
            { MessageBox.Show("Array is not full...", "ERROR!"); return; }
            array();
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();

        }

        private void Merging_Click(object sender, EventArgs e)
        {
            if (label11.Text == "")
            { MessageBox.Show("Array is not full...", "ERROR!"); return; }
            array();
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();
        }
    }
}
