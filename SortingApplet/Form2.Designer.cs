namespace SortingApplet
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Inputbox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Randomise = new System.Windows.Forms.Button();
            this.Bubblesort = new System.Windows.Forms.Button();
            this.Selectionsort = new System.Windows.Forms.Button();
            this.Exchangesort = new System.Windows.Forms.Button();
            this.Insertionsort = new System.Windows.Forms.Button();
            this.Merging = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Location = new System.Drawing.Point(35, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(763, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(621, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Number :";
            // 
            // Inputbox
            // 
            this.Inputbox.Location = new System.Drawing.Point(705, 43);
            this.Inputbox.Name = "Inputbox";
            this.Inputbox.Size = new System.Drawing.Size(52, 20);
            this.Inputbox.TabIndex = 5;
            this.Inputbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inputbox_KeyDown);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(237, 41);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Randomise
            // 
            this.Randomise.Location = new System.Drawing.Point(130, 41);
            this.Randomise.Name = "Randomise";
            this.Randomise.Size = new System.Drawing.Size(75, 23);
            this.Randomise.TabIndex = 7;
            this.Randomise.Text = "Randomise";
            this.Randomise.UseVisualStyleBackColor = true;
            this.Randomise.Click += new System.EventHandler(this.Randomise_Click);
            // 
            // Bubblesort
            // 
            this.Bubblesort.Location = new System.Drawing.Point(624, 127);
            this.Bubblesort.Name = "Bubblesort";
            this.Bubblesort.Size = new System.Drawing.Size(157, 45);
            this.Bubblesort.TabIndex = 27;
            this.Bubblesort.Text = "Apply Bubble Sort";
            this.Bubblesort.UseVisualStyleBackColor = true;
            this.Bubblesort.Click += new System.EventHandler(this.Bubblesort_Click);
            // 
            // Selectionsort
            // 
            this.Selectionsort.Location = new System.Drawing.Point(624, 177);
            this.Selectionsort.Name = "Selectionsort";
            this.Selectionsort.Size = new System.Drawing.Size(157, 45);
            this.Selectionsort.TabIndex = 28;
            this.Selectionsort.Text = "Apply Selection Sort";
            this.Selectionsort.UseVisualStyleBackColor = true;
            this.Selectionsort.Click += new System.EventHandler(this.Selectionsort_Click);
            // 
            // Exchangesort
            // 
            this.Exchangesort.Location = new System.Drawing.Point(624, 227);
            this.Exchangesort.Name = "Exchangesort";
            this.Exchangesort.Size = new System.Drawing.Size(157, 45);
            this.Exchangesort.TabIndex = 29;
            this.Exchangesort.Text = "Apply Exchange Sort";
            this.Exchangesort.UseVisualStyleBackColor = true;
            this.Exchangesort.Click += new System.EventHandler(this.Exchangesort_Click);
            // 
            // Insertionsort
            // 
            this.Insertionsort.Location = new System.Drawing.Point(624, 277);
            this.Insertionsort.Name = "Insertionsort";
            this.Insertionsort.Size = new System.Drawing.Size(157, 45);
            this.Insertionsort.TabIndex = 30;
            this.Insertionsort.Text = "Apply Insertion Sort";
            this.Insertionsort.UseVisualStyleBackColor = true;
            this.Insertionsort.Click += new System.EventHandler(this.Insertionsort_Click);
            // 
            // Merging
            // 
            this.Merging.Location = new System.Drawing.Point(624, 327);
            this.Merging.Name = "Merging";
            this.Merging.Size = new System.Drawing.Size(157, 45);
            this.Merging.TabIndex = 31;
            this.Merging.Text = "MergeSort Merging";
            this.Merging.UseVisualStyleBackColor = true;
            this.Merging.Click += new System.EventHandler(this.Merging_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(624, 378);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(157, 29);
            this.back.TabIndex = 32;
            this.back.Text = "Back to Main Menu!";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(196, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(196, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(196, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(196, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 224);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Merging);
            this.Controls.Add(this.Insertionsort);
            this.Controls.Add(this.Exchangesort);
            this.Controls.Add(this.Selectionsort);
            this.Controls.Add(this.Bubblesort);
            this.Controls.Add(this.Randomise);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Inputbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Sorting Applet";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Inputbox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Randomise;
        private System.Windows.Forms.Button Bubblesort;
        private System.Windows.Forms.Button Selectionsort;
        private System.Windows.Forms.Button Exchangesort;
        private System.Windows.Forms.Button Insertionsort;
        private System.Windows.Forms.Button Merging;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}