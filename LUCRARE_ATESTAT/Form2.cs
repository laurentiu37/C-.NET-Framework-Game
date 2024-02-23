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
    public partial class Form2 : Form
    {

        int RaspunsCorect;
        int NumarIntrebare = 1;
        int scor;
        int procentaj;
        int Intrebari;
        string mesaj_raspuns;
        public Form2()
        {
            InitializeComponent();
            askQuestion(NumarIntrebare);
            Intrebari = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if(buttonTag == RaspunsCorect)
                scor++;
            else
            {
                mesaj_raspuns = "Răspuns greșit! " + "Răspunsul corect era ";
                if (RaspunsCorect == 1)
                    mesaj_raspuns = mesaj_raspuns + button1.Text + ".";
                if (RaspunsCorect == 2)
                    mesaj_raspuns = mesaj_raspuns + button2.Text + ".";
                if (RaspunsCorect == 3)
                    mesaj_raspuns = mesaj_raspuns + button3.Text + ".";
                if (RaspunsCorect == 4)
                    mesaj_raspuns = mesaj_raspuns + button4.Text + ".";
                MessageBox.Show(mesaj_raspuns);
            }
            if (NumarIntrebare == Intrebari)
            {
                procentaj = (int)Math.Round((double)(scor * 100) / Intrebari);
                if (scor > 1)
                    MessageBox.Show(
                        "Joc încheiat!" + Environment.NewLine + "Ai răspuns la " + scor + " întrebări corect." + Environment.NewLine +
                        "Procentajul tău total este de " + procentaj + "%" + Environment.NewLine
                        );
                else if (scor == 1)
                    MessageBox.Show(
                        "Joc încheiat!" + Environment.NewLine + "Ai răspuns la " + scor + " întrebare corect." + Environment.NewLine +
                        "Procentajul tău total este de " + procentaj + "%" + Environment.NewLine
                        );
                else if (scor < 1)
                    MessageBox.Show(
                        "Joc încheiat!" + Environment.NewLine + "Ai răspuns la " + scor + " întrebări corect." + Environment.NewLine +
                        "Procentajul tău total este de " + procentaj + "%" + Environment.NewLine
                        );
                    DialogResult ans = MessageBox.Show("Vrei să reiei jocul?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans.ToString() == "Yes")
                {
                    scor = 0;
                    NumarIntrebare = 0;
                    askQuestion(NumarIntrebare);
                }
                else
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
            NumarIntrebare++;
            askQuestion(NumarIntrebare);
        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.intrebarea1;
                    lblQuestion.Text = "Care minge din următoarele reprezintă una de baschet?";
                    button1.Text = "1";
                    button2.Text = "2";
                    button3.Text = "3";
                    button4.Text = "4";
                    RaspunsCorect = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.intrebarea2;
                    lblQuestion.Text = "Câți jucători se află în permanență pe teren?";
                    button1.Text = "5";
                    button2.Text = "10";
                    button3.Text = "6";
                    button4.Text = "11";
                    RaspunsCorect = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.intrebarea3;
                    lblQuestion.Text = "Care echipe au cele mai multe titluri din NBA?";
                    button1.Text = "LA Lakers / Boston Celtics";
                    button2.Text = "LA Lakers / Chicago Bulls";
                    button3.Text = "Boston Celtics / Miami Heat";
                    button4.Text = "Miami Heat / Chicago Bulls";
                    RaspunsCorect = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.intrebarea4;
                    lblQuestion.Text = "Care jucător este considerat a fi cel mai mare din istoria baschetului?";
                    button1.Text = "Lebron James";
                    button2.Text = "Kobe Bryant";
                    button3.Text = "Steph Curry";
                    button4.Text = "Michael Jordan";
                    RaspunsCorect = 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.intrebarea5;
                    lblQuestion.Text = "Care echipă are cele mai multe titluri din România?";
                    button1.Text = "CSM Oradea";
                    button2.Text = "Steaua București";
                    button3.Text = "Dinamo București";
                    button4.Text = "U-BT Cluj-Napoca";
                    RaspunsCorect = 3;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.intrebarea6;
                    lblQuestion.Text = "Care jucător este considerat a fi cel mai mare din istoria baschetului românesc?";
                    button1.Text = "Gheorghe Mureșan";
                    button2.Text = "Antonio Alexe";
                    button3.Text = "Horia Păun";
                    button4.Text = "Marcel Țenter";
                    RaspunsCorect = 1;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.intrebarea7;
                    lblQuestion.Text = "Care este echipa cu cel mai lung parcurs european din România?";
                    button1.Text = "CSU Asesoft Ploiești";
                    button2.Text = "Energia Târgu-Jiu";
                    button3.Text = "CSM Oradea";
                    button4.Text = "U-BT Cluj-Napoca";
                    RaspunsCorect = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.intrebarea7;
                    lblQuestion.Text = "Care echipă încă existentă a reușit cea mai mare performanță în cupele europene?";
                    button1.Text = "CSU Asesoft Ploiești";
                    button2.Text = "CSM Oradea";
                    button3.Text = "Energia Târgu-Jiu";
                    button4.Text = "U-BT Cluj-Napoca";
                    RaspunsCorect = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.intrebarea9;
                    lblQuestion.Text = "Care echipă participantă în Euroligă are cele mai multe titluri?";
                    button1.Text = "Maccabi Tel Aviv";
                    button2.Text = "Panathinaikos";
                    button3.Text = "CSKA Moscova";
                    button4.Text = "Real Madrid";
                    RaspunsCorect = 4;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.intrebarea10;
                    lblQuestion.Text = "Care competiție este considerată a fi cea mai puternică?";
                    button1.Text = "Euroliga";
                    button2.Text = "Basketball Champions League";
                    button3.Text = "NBA";
                    button4.Text = "FIBA Europe Cup";
                    RaspunsCorect = 3;
                    break;
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
