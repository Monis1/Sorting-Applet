using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingApplet
{
    public partial class cell : UserControl
    {
        static int incr = 1;
        public cell()
        {
            InitializeComponent();
        }
        int _cellvalue;
        public int cellvalue
        {
            get { return _cellvalue; }
            set
            {
                lvalue.Text = value.ToString();
                _cellvalue = value;
            }

        }
        private void cell_Load(object sender, EventArgs e)
        {

        }
        async public void move_down()
        {
            for (int i = 0; i < 28; i++)
            {
               await Task.Delay(3);
                this.Location = new Point(this.Location.X, this.Location.Y + 1);
            }

        }
        async public void move_left()
        {
            for (int i = 0; i < 95; i++)
            {
               await Task.Delay(3);
                this.Location = new Point(this.Location.X - 1, this.Location.Y);
            }

        }

        async public void insert()
        {


            for (int i = 0; i < 95; i++)
            {
                await Task.Delay(3);
                this.Location = new Point(this.Location.X + 1, this.Location.Y);
            }


        }

        async public void move_up()
        {
            for (int i = 0; i < 28; i++)
            {
                await Task.Delay(3);
                this.Location = new Point(this.Location.X, this.Location.Y - 1);
            }

        }
        async public void merge_it(bool di)
        {
            int i,x=this.Location.X;
           
            for ( i = 0; i <28*incr; i++)
            {
                await Task.Delay(3);
                this.Location = new Point(this.Location.X, this.Location.Y + 1);
            }
            incr++;
            while (true)
            {
                await Task.Delay(3);
                
                if (di)
                {
                    if (x == 421)
                        break;
                    else
                    {
                        x++;
                        this.Location = new Point(x, this.Location.Y);
                    }
                }

                else
                {
                    if (x == 421)
                        break;
                    else
                    {
                        x--;
                        this.Location = new Point(x, this.Location.Y);
                    }
                }
            }
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
