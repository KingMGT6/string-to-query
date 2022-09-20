namespace STQ
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.picbconvert = new System.Windows.Forms.PictureBox();
            this.lblclear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbconvert)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(318, 434);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(421, 6);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(318, 434);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // picbconvert
            // 
            this.picbconvert.BackColor = System.Drawing.Color.Transparent;
            this.picbconvert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbconvert.Image = global::STQ.Properties.Resources.giphy;
            this.picbconvert.Location = new System.Drawing.Point(337, 172);
            this.picbconvert.Name = "picbconvert";
            this.picbconvert.Size = new System.Drawing.Size(78, 70);
            this.picbconvert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbconvert.TabIndex = 4;
            this.picbconvert.TabStop = false;
            this.picbconvert.Click += new System.EventHandler(this.picbconvert_Click);
            this.picbconvert.MouseLeave += new System.EventHandler(this.picbconvert_MouseLeave);
            this.picbconvert.MouseHover += new System.EventHandler(this.picbconvert_MouseHover);
            // 
            // lblclear
            // 
            this.lblclear.BackColor = System.Drawing.Color.Transparent;
            this.lblclear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblclear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclear.Location = new System.Drawing.Point(337, 254);
            this.lblclear.Name = "lblclear";
            this.lblclear.Size = new System.Drawing.Size(78, 49);
            this.lblclear.TabIndex = 5;
            this.lblclear.Text = "CLEAR TEXT";
            this.lblclear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblclear.Click += new System.EventHandler(this.lblclear_Click);
            this.lblclear.MouseLeave += new System.EventHandler(this.lblclear_MouseLeave);
            this.lblclear.MouseHover += new System.EventHandler(this.lblclear_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 457);
            this.Controls.Add(this.lblclear);
            this.Controls.Add(this.picbconvert);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String to Query";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbconvert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox picbconvert;
        private System.Windows.Forms.Label lblclear;
    }
}

