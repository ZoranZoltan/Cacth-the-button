using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Assig5
{
    public partial class Form1 : Form
    {
        Thread th;
        int ii, i; Random x = new Random();
        public Form1()
        {
            InitializeComponent();
            i = ii = 0;
            pictureBox1.Hide();
            pictureBox2.Hide();
            label2.Hide();
            button3.Hide();
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d=MessageBox.Show("Da li ste sigurni ? ","OK",MessageBoxButtons.OK);
            if (d.ToString() == "OK") 
            {
                label1.Text = "Hvala na podršci, ljubim te!!!!!";
                label1.Font = new Font(label1.Font.Name, label1.Font.Size,
                    label1.Font.Style ^ FontStyle.Italic);
                label1.ForeColor = Color.Red;
                button1.Visible = false;
                button2.Visible = false;
                pictureBox1.Show();
                pictureBox2.Show();
                label2.Show();
                button3.Show();

           
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
                        if ((i < (button1.Location.X - button2.Size.Width) ||   //if --for ok buttom
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
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform(object obj)
        {
            Application.Run(new Form2());
        }
    }
}
