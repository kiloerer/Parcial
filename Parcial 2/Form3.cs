using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Parcial_2
{
    public partial class Form3 : Form
    {

        public int finalscore2nd { get; set; }
        public int partialscore { get; set; }
        public int toftot { get; set; }
        int score1 = 0;
        int score2 = 0;


        string Rightans1 = "AFICION";
        string Rightans2 = "HACE";

        int finalscore = 0;
        int finalscore1 = 0;
        int finalscore3nd = 0;
        int finalscorefrom = 0;

        public Form3()
        {
            
            InitializeComponent();
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = Quest5.Text;
            if (item == Rightans1)
                score1 = 25;
            else if (item != Rightans1)
                score1 = 0;
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Quest6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = Quest6.Text;
            if (item == Rightans2)
                score2 = 25;
            else if (item != Rightans2)
                score2 = 0;
            finalscorefrom = puntaje.finalscore2nd;
            puntaje.finalscore2nd = finalscorefrom;
            finalscore = finalscorefrom + score2 + score1;
            
            
            

        }

        
        private void Form3_Load(object sender, EventArgs e)
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
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();



            }
        }

        private void Question5_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
