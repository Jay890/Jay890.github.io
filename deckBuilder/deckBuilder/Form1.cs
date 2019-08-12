using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deckBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGradeZero_Click(object sender, EventArgs e)
        {
            int gradeZero;
           
            gradeZero = Convert.ToInt32(lblZero.Text);

            cardTotal.Text = gradeZero.ToString("n");


        }

        private void btnGradeOne_Click(object sender, EventArgs e)
        {
            int gradeOne;

            gradeOne = Convert.ToInt32(lblOne.Text);

            cardTotal.Text = gradeOne.ToString("n");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblZero.Text = "";
            lblOne.Text = "";
            lblTwo.Text = "";
            lblThree.Text = "";
            cardTotal.Text = "";
            cardsNeeded.Text = "";
        }

        private void btnGradeTwo_Click(object sender, EventArgs e)
        {
            int gradeTwo;

            gradeTwo = Convert.ToInt32(lblTwo.Text);

            cardTotal.Text = gradeTwo.ToString("n");
        }

        private void btnGradeThree_Click(object sender, EventArgs e)
        {
            int gradeThree;

            gradeThree = Convert.ToInt32(lblThree.Text);

            cardTotal.Text = gradeThree.ToString("n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gradeZero, gradeOne, gradeTwo, gradeThree, remaining,leftOver;
            remaining = 50;

            gradeZero = Convert.ToInt32(lblZero.Text);
            gradeOne = Convert.ToInt32(lblOne.Text);
            gradeTwo = Convert.ToInt32(lblTwo.Text);
            gradeThree = Convert.ToInt32(lblThree.Text);
  

            cardTotal.Text = (gradeZero + gradeOne + gradeTwo + gradeThree).ToString("n0");

            leftOver = Convert.ToInt32(cardTotal.Text);
            
            remaining = remaining - leftOver;
            cardsNeeded.Text = remaining.ToString("n0");
        }

        private void cardTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
