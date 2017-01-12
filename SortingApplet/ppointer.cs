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
    public partial class ppointer : UserControl
    {
        public ppointer()
        {
            InitializeComponent();
        }
        public void show()
        { pictureBox1.Show(); }
        public void hide()
        { pictureBox1.Hide(); }
        public async void move()
        {
            int y;
            for (int i = 0; i < 22; i++)
            {
                await Task.Delay(25);
                y = this.Location.Y + 1;
                if (y < 266)
                    this.Location = new Point(this.Location.X, y);
                else
                    break;
            }



        }
        public void gotoo(int y)
        {
          this.Location = new Point(this.Location.X, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
