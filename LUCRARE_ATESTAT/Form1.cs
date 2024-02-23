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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ok;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3)
            {
                button1.Enabled = true;
                string player = textBox1.Text;
                MessageBox.Show("Salut " + player + "! Aceasta este partea de tip Quiz a jocului The Ultimate Basketball Trivia. Să începem! ");
                ok = 1;
                this.timer1.Start();
            }
            else
            {
                MessageBox.Show("Numele este prea scurt!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Ești sigur că vrei să părăsești jocul?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                if (ok == 1)
                {
                    Form2 intrebarea1 = new Form2();
                    intrebarea1.Show();
                    this.Hide();
                }
                else
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            MessageBox.Show("Salut! Am să îți prezint câteva informații folositoare în legătură cu acest joc." + Environment.NewLine +
                "1) Butonul 'Quiz' te va introduce în jocul în care va trebui să alegi răspunsul corect la fiecare din cele 10 întrebări." + Environment.NewLine + "Pentru a alege un răspuns apasă CLICK pe unul din cele 4 butoane." + Environment.NewLine +
                "2) Butonul 'Difference Game' te va introduce în jocul în care va trebui să observi diferențele dintre 2 imagini." + Environment.NewLine + "În momentul în care ai zărit o diferență, apasă CLICK în zona în care se află diferența pentru a fi contorizată." + Environment.NewLine + "Apasă butonul de START pentru a începe." + Environment.NewLine +
                "3) Nu uita să introduci un nume pentru a putea începe unul dintre jocuri!" + Environment.NewLine +
                "4) Have fun! :)");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3)
            {
                button4.Enabled = true;
                string player = textBox1.Text;
                MessageBox.Show("Salut " + player + "! Aceasta este partea de tip Difference a jocului The Ultimate Basketball Trivia. Să începem! ");
                ok = 2;
                this.timer1.Start();
            }
            else
            {
                MessageBox.Show("Numele este prea scurt!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
