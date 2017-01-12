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
    public partial class vertBar : UserControl
    {
        public Label l1;
       public int uvalue;
        public vertBar()
        {
            InitializeComponent();
           
        }

        public void value(int _value)
        {
          int  maxvalue = Form2.arr.Max();
            int h = _value * 400 / maxvalue;
            if (h == 0)
            { h = 1; }
            this.label_Val.Text = _value.ToString();
            this.bar.Size = new Size(
               this.bar.Size.Width,
               h
            );
            this.bar.Location = new Point(
               this.bar.Location.X,
               364 - this.bar.Size.Height
            );

            uvalue=_value;
        }

        private void vertBar_Load(object sender, EventArgs e)
        {
            l1 = bar;
        }

        public void changecolor()
        {
            if (bar.BackColor == Color.DarkBlue)
                bar.BackColor = Color.Red;
            else
                bar.BackColor = Color.DarkBlue;
        }
        public void donecolor()
        { this.bar.BackColor = Color.IndianRed; }
        public void mincolor()
        { bar.BackColor = Color.DeepPink; }
      



    }
}
