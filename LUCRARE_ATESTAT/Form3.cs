using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUCRARE_ATESTAT
{
    public partial class Form3 : Form
    {
        int x = 0;
        string s;
        bool start;
        int[] v = new int[10];
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                label1.Text = Convert.ToString(++x) + s;
                pictureBox7.Hide();
                v[7] = 1;
                verificare();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            start = true;
            label1.Text = Convert.ToString(x) + s;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                label1.Text = Convert.ToString(++x) + s;
                pictureBox2.Hide();
                v[0] = 1;
                verificare();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                label1.Text = Convert.ToString(++x) + s;
                pictureBox4.Hide();
                v[1] = 1;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                label1.Text = Convert.ToString(++x) + s;
                pictureBox3.Hide();
                v[2] = 1;
                verificare();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                label1.Text = Convert.ToString(++x) + s;
                pictureBox6.Hide();
                v[3] = 1;
                verificare();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                label1.Text = Convert.ToString(++x) + s;
                pictureBox5.Hide();
                v[4] = 1;
                verificare();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                label1.Text = Convert.ToString(++x) + s;
                pictureBox9.Hide();
                v[5] = 1;
                verificare();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                label1.Text = Convert.ToString(++x) + s;
                pictureBox8.Hide();
                v[6] = 1;
                verificare();
            }
        }
        private void verificare()
        {
            if (x == 8)
            {
                MessageBox.Show("Felicitări! Ai reușit să găsești toate diferențele.");
                DialogResult ans = MessageBox.Show("Vrei să reiei jocul?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans.ToString() == "Yes")
                {
                    x = 0;
                    label1.Text = 0 + s;
                    pictureBox2.Show();
                    pictureBox3.Show();
                    pictureBox4.Show();
                    pictureBox5.Show();
                    pictureBox6.Show();
                    pictureBox7.Show();
                    pictureBox8.Show();
                    pictureBox9.Show();
                }
                else
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                DialogResult ans = MessageBox.Show("Nu ai reușit să găsești nicio diferență!" + Environment.NewLine + "Vrei să continui?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans.ToString() == "No")
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
            if (x == 1)
            {
                DialogResult ans = MessageBox.Show("Ai reușit să găsești doar o diferență!" + Environment.NewLine + "Vrei să continui?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans.ToString() == "No")
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
            if (x >= 2 && x <= 7)
            {
                DialogResult ans = MessageBox.Show("Ai reușit să găsești doar " + x + " diferențe!" + Environment.NewLine + "Vrei să continui?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans.ToString() == "No")
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
        }
    }
}
