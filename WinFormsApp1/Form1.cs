using System;
using System.Diagnostics.Eventing.Reader;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person new_person = new Person(NameBox.Text, Convert.ToInt32(AgeBox.Text), ProfessionBox.Text);
            string a = "";

            if (AgeBox.Text != " ")
            {
                if (AgeBox.Text != " ")
                {
                    new_person = new Person(NameBox.Text, Convert.ToInt32(AgeBox.Text), AgeBox.Text);
                }
                else
                {
                    new_person = new Person(NameBox.Text, Convert.ToInt32(AgeBox.Text), a);
                }
            }
            else
            {
                if (AgeBox.Text != " ")
                {
                    new_person = new Person(NameBox.Text, 0, AgeBox.Text);
                }
                else
                {
                    new_person = new Person(NameBox.Text, 0, a);
                }
            }
            resultbox.Text += new_person.GetInformation();
        }
    }
}

