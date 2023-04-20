using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{

    public partial class Form1 : Form
    {
        int score;
        public int finalscore1st { get; set; }
        int correct;
        int msq = 1;
        int totmsq;
        int ctf;
        public int finalscore2nd { get; set; }
        public int partialscore { get; set; }
        public int toftot { get; set; }
        int score1 = 0;
        int score2 = 0;
        public Form1()
        {
            InitializeComponent();
           
            AskQuest(msq);
            totmsq = 2;

        }

        private void Question1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        


        private void AskQuest(int questnumb)
        {
            switch(questnumb)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Primermundial;
                    Quest1.Text = "¿Cual Fue el Primer anfitrion en quedar Campeon de su \n Propio Mundial?";

                    BQ1.Text = "URUGUAY";
                    BQ2.Text = "BRASIL";
                    BQ3.Text = "INGLATERRA";
                    BQ4.Text = "ITALIA";

                    correct = 1;


 

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.barcelona;
                    Quest1.Text = "¿Cual de estos jugadores no jugo en el Barcelona?";

                    BQ1.Text = "YERRY MINA";
                    BQ2.Text = "ZLATAN IBRAHIMOVIC";
                    BQ3.Text = "SAMUEL ETO'O";
                    BQ4.Text = "XAVI ALONSO";

                    correct = 4;

                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void continuebott_Click(object sender, EventArgs e)
        {
            {
                toftot = score1 + score2;
                finalscore2nd = puntaje.finalscore1st;
                partialscore = toftot + finalscore2nd;
                puntaje.finalscore2nd = partialscore;
                partialscore = puntaje.finalscore2nd;
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();



            }
        }
    }
}
