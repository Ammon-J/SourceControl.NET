using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingToKnowSourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // buttonValue keeps track of the number that needs to be times by 2
        long buttonValue = 1;

        private void DoubleBtn_Click(object sender, EventArgs e)
        {
            // If buttonValue is greater than what a long can store stop the program
            if(buttonValue * 2 < 922337203685477580)
            {
                buttonValue *= 2;
                // Display the number when the form loads
                DisplayNumber(buttonValue);
            }

            else
            {
                MessageBox.Show("Good job you reached the limit!", "Information"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display the number when the form loads
            DisplayNumber(buttonValue);
        }

        // Display the number in the label
        public void DisplayNumber(long buttonValue)
        {
            valueLabel.Text = String.Format("{0:n0}", buttonValue);
        }

        private void GetCompBtn_Click(object sender, EventArgs e)
        {
            // Genrate a random number to get a compliment
            Random rand = new Random();
            int index = rand.Next(4);

            // Get a compliment
            String compliment = GetCompliment(index);

            // Display the comliment
            DisplayCompliment(compliment);
        }

        public String GetCompliment(int index)
        {
            // Store the compliments
            List<String> compliments = new List<string>();

            compliments.Add("You are looking mighty fine today!");
            compliments.Add("I bet you make babies smile!");
            compliments.Add("You're like sunshine on a rainy day!");
            compliments.Add("The sun squints when it looks at you!");

            return compliments.ElementAt(index);
        }

        public void DisplayCompliment(String compliment)
        {
            compLabel.Text = compliment;
        }
    }
}
