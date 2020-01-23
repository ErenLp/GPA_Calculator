using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA
{
    public partial class Intro : Form
    {
        public Label[] l = new Label[512];
        public static TextBox[,] tb = new TextBox[512,3];
        public static int len=5;
        public Intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                len = Int32.Parse(textBox1.Text);

                Info f2 = new Info();
                this.Hide();
                f2.Show();

                for (int i = 0; i < len; i++)
                {
                    Console.WriteLine("INSIDE LENGTH " + len);
                    l[i] = new Label();
                    l[i].Top = 50 + i * 30;
                    l[i].Left = 5;
                    l[i].Font = new Font("Calibri", 16);
                    l[i].Text = (i + 1) + ": ";
                    l[i].Size = new Size(30, 20);
                    f2.Controls.Add(l[i]);
                    tb[i, 0] = new TextBox();
                    tb[i, 0].Font = new Font("Calibri", 12);
                    tb[i, 0].Size = new Size(200, 1);
                    tb[i, 0].TextAlign = HorizontalAlignment.Center;
                    tb[i, 0].Top = 50 + i * 30;
                    tb[i, 0].Left = 50;
                    f2.Controls.Add(tb[i, 0]);
                    tb[i, 1] = new TextBox();
                    tb[i, 1].Font = new Font("Calibri", 12);
                    tb[i, 1].Size = new Size(75, 1);
                    tb[i, 1].TextAlign = HorizontalAlignment.Center;
                    tb[i, 1].Top = 50 + i * 30;
                    tb[i, 1].Left = 280;
                    f2.Controls.Add(tb[i, 1]);
                    tb[i, 2] = new TextBox();
                    tb[i, 2].Font = new Font("Calibri", 12);
                    tb[i, 2].Size = new Size(75, 1);
                    tb[i, 2].TextAlign = HorizontalAlignment.Center;
                    tb[i, 2].Top = 50 + i * 30;
                    tb[i, 2].Left = 400;
                    f2.Controls.Add(tb[i, 2]);
                }
            }
            else
            {
                MessageBox.Show("Please enter the number of courses.");
            }
        }
        public int length() { return len; }

        private void Intro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
