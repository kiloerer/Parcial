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
    public partial class Form4 : Form
    {

        public int finalscore2nd { get; set; }
        public int partialscore { get; set; }
        public int toftot { get; set; }
        int score1 = 0;
        int score2 = 0;


        string Rightans4 = "OLYMPIQUE DE MARSEILLA";
        string Rightans3 = "CELTA DE VIGO";

        int finalscore = 0;
        int finalscore1 = 0;
        int finalscore3nd = 0;
        int finalscorefrom = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Quest5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = Quest5.Text;
            if (item == Rightans4)
                score1 = 25;
            else if (item != Rightans3)
                score1 = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has finalizado las pruebas, tu puntaje es: " + finalscore);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.Text;
            if (item == Rightans4)
                score2 = 20;
            else if (item != Rightans3)
                score2 = 0;
            finalscorefrom = puntaje.finalscore2nd;
            puntaje.finalscore2nd = finalscorefrom;
            finalscore = finalscorefrom + score2 + score1;
        }
    }
}
