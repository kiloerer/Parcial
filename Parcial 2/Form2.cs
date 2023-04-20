using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Parcial_2.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Parcial_2
{
    public partial class Form2 : Form
    {
        public int finalscore2nd { get; set; }
        public int partialscore { get; set; }
        public int toftot { get; set; }
        int score1 = 0;
        int score2 = 0;


        public Form2()
        {
            InitializeComponent();
        }

        private void Question3_Enter(object sender, EventArgs e)
        {

        }

        private void True1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void False1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void True2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void False2_CheckedChanged(object sender, EventArgs e)
        {
         
        }
        private void RadioQuestion3(object sender, EventArgs e)
        {
            if (False1.Checked == true)
            
                score1 = 10;
                else if (True1.Checked == true)
                score1 = 0;
            
        }
        private void RadioQuestion4(object sender, EventArgs e)
        {
            if (False2.Checked == true)
            
                score2 = 0;
                else if (True2.Checked == true)
                    score2 = 10;
            
        }

        private void continuebott_Click(object sender, EventArgs e)
        {
            {
                toftot = score1 + score2;
                finalscore2nd = puntaje.finalscore1st;
                partialscore = toftot + finalscore2nd;
                puntaje.finalscore2nd = partialscore;
                partialscore = puntaje.finalscore2nd;
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
                
                

            }       

        }
    }
   
}
