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
    public partial class Info : Form
    {
        Intro f1;
        public Info()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Intro.len; i++)
                Intro.tb[i,2].Text=Intro.tb[i, 2].Text.ToUpper();
            Result.label.Font = new Font("Calibri", 20,FontStyle.Bold);
            Result.label.Size = new Size(100, 50);
            Result.label.Top = 50;
            Result.label.Left = 150;
            Result.label.Text = String.Format("{0:0.00}",gpa());
        }

        private double gpa()
        {
            double total = 0, totalCredit = 0, gpa = 0;
            Intro intro = new Intro();
            String gr;
            bool num;
            for (int i = 0; i < Intro.len; i++)
            {
                num = int.TryParse(Intro.tb[i, 1].Text, out int myint);
                if (num != true)
                    gpa = 9;
                gr = Intro.tb[i, 2].Text;
                if (gpa != 9)
                {
                    switch (gr)
                    {
                        case ("AA"):
                            total += Int32.Parse(Intro.tb[i, 1].Text) * 4;
                            break;
                        case ("BA"):
                            total += Int32.Parse(Intro.tb[i, 1].Text) * 3.5;
                            break;
                        case ("BB"):
                            total += Int32.Parse(Intro.tb[i, 1].Text) * 3;
                            break;
                        case ("CB"):
                            total += Int32.Parse(Intro.tb[i, 1].Text) * 2.5;
                            break;
                        case ("CC"):
                            total += Int32.Parse(Intro.tb[i, 1].Text) * 2;
                            break;
                        case ("DC"):
                            total += Int32.Parse(Intro.tb[i, 1].Text) * 1.5;
                            break;
                        case ("DD"):
                            total += Int32.Parse(Intro.tb[i, 1].Text) * 1;
                            break;
                        case ("FF"):
                            total += Int32.Parse(Intro.tb[i, 1].Text) * 0;
                            break;
                        case ("FD"):
                            total += Int32.Parse(Intro.tb[i, 1].Text) * 0;
                            break;
                        case ("NA"):
                            total += Int32.Parse(Intro.tb[i, 1].Text) * 0;
                            break;
                        default:
                            gpa = 5;
                            break;
                    }

                    if (Intro.tb[i, 1].Text != "" && (Int32.Parse(Intro.tb[i, 1].Text) >= 0 && Int32.Parse(Intro.tb[i, 1].Text) <= 7))
                        totalCredit += Int32.Parse(Intro.tb[i, 1].Text);
                    else
                        gpa = 6;
                }
            }
                    if (gpa < 5)
                    {
                        gpa = total / totalCredit;
                        Result r = new Result();
                        r.Show();
                    }
                    else if (gpa == 5)
                    {
                        MessageBox.Show("Please enter all necessary fields.");
                    }
                    else if (gpa == 9)
                         MessageBox.Show("Please enter credit fields correctly.");
                    else
                        MessageBox.Show("Please enter credit fields correctly.");        
            return gpa;
        }

        private void Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Intro f1 = new Intro();
            f1.Show();
        }
    }

}
