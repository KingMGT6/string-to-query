using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picbconvert_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text != string.Empty)
            {
                string[] testarr = richTextBox1.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                richTextBox2.Text = "('" + string.Join("','", testarr) + "')";
            }
        }

        private void picbconvert_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.picbconvert, "Convert to query");
            picbconvert.BackColor = Color.Yellow;
        }

        private void picbconvert_MouseLeave(object sender, EventArgs e)
        {
            picbconvert.BackColor = Color.Transparent;
        }

        private void lblclear_MouseHover(object sender, EventArgs e)
        {
            lblclear.BackColor = Color.Yellow;
        }

        private void lblclear_MouseLeave(object sender, EventArgs e)
        {
            lblclear.BackColor = Color.Transparent;
        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox2.ReadOnly = true;
        }
    }
}
