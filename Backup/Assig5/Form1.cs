using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assig5
{
    public partial class Form1 : Form
    {
        int ii, i; Random x = new Random();
        public Form1()
        {
            InitializeComponent();
            i = ii = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d=MessageBox.Show("Are you sure ? ","OK",MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                label1.Text = "Good... Enjoy your life.";
                label1.Font = new Font(label1.Font.Name, label1.Font.Size,
                    label1.Font.Style ^ FontStyle.Italic);
                label1.ForeColor = Color.Red;
                button1.Visible = false;
                button2.Visible = false;
            }
        }
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                for (; ; )
                {
                    i = x.Next(0, this.Size.Width - button2.Size.Width - 15);
                    ii = x.Next(0, this.Size.Height - button2.Size.Height - 35);
                    if ((i < (label1.Location.X - button2.Size.Width) ||    //-1 for fraction
                        i > (label1.Location.X + label1.Size.Width)) ||
                        (ii < (label1.Location.Y - button2.Size.Height) ||
                        ii > (label1.Location.Y + label1.Size.Height)))
                        if ((i < (button1.Location.X - button2.Size.Width) ||   //if --for YES buttom
                            i > (button1.Location.X + button1.Size.Width)) ||
                        (ii < (button1.Location.Y - button2.Size.Height) ||
                        ii > (button1.Location.Y + button1.Size.Height)))
                            if ((MousePosition.X > (i + button2.Size.Width) || MousePosition.X < i)
                                || ((MousePosition.Y > ii + button2.Size.Height) ||
                                MousePosition.Y < ii))    //for mouse location
                            { button2.Location = new Point(i, ii); break; }
                }
            }
            catch { }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

      

    }
}
