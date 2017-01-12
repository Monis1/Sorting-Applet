namespace SortingApplet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdexit = new System.Windows.Forms.Button();
            this.cmdbegin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdexit
            // 
            this.cmdexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexit.Location = new System.Drawing.Point(567, 221);
            this.cmdexit.Name = "cmdexit";
            this.cmdexit.Size = new System.Drawing.Size(192, 46);
            this.cmdexit.TabIndex = 3;
            this.cmdexit.Text = "Exit";
            this.cmdexit.UseVisualStyleBackColor = true;
            this.cmdexit.Click += new System.EventHandler(this.cmdexit_Click);
            // 
            // cmdbegin
            // 
            this.cmdbegin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdbegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdbegin.Location = new System.Drawing.Point(567, 151);
            this.cmdbegin.Name = "cmdbegin";
            this.cmdbegin.Size = new System.Drawing.Size(192, 46);
            this.cmdbegin.TabIndex = 2;
            this.cmdbegin.Text = "Begin";
            this.cmdbegin.UseVisualStyleBackColor = false;
            this.cmdbegin.Click += new System.EventHandler(this.cmdbegin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.ControlBox = false;
            this.Controls.Add(this.cmdexit);
            this.Controls.Add(this.cmdbegin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sorting Applet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdexit;
        private System.Windows.Forms.Button cmdbegin;
    }
}

