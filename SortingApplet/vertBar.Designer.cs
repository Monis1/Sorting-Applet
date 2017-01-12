namespace SortingApplet
{
    partial class vertBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Val = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Val
            // 
            this.label_Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_Val.AutoSize = true;
            this.label_Val.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Val.Location = new System.Drawing.Point(3, 373);
            this.label_Val.Name = "label_Val";
            this.label_Val.Size = new System.Drawing.Size(13, 17);
            this.label_Val.TabIndex = 4;
            this.label_Val.Text = "-";
            // 
            // bar
            // 
            this.bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bar.BackColor = System.Drawing.Color.DarkBlue;
            this.bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bar.ForeColor = System.Drawing.Color.DarkBlue;
            this.bar.Location = new System.Drawing.Point(3, 352);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(37, 10);
            this.bar.TabIndex = 5;
            // 
            // vertBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bar);
            this.Controls.Add(this.label_Val);
            this.Name = "vertBar";
            this.Size = new System.Drawing.Size(48, 390);
            this.Load += new System.EventHandler(this.vertBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Val;
        private System.Windows.Forms.Label bar;
    }
}
