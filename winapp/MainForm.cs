using System;
using System.Drawing;
using System.Windows.Forms;

namespace winapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            TextForm newform = new TextForm();
            newform.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ExForm newform = new ExForm();
            newform.Show();
            this.Hide();
        }
        public Boolean i = false;
        public Boolean j = false;
        public void button3_Click(object sender, EventArgs e)
        {
             
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }        
        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Im Supermarkt.mp3");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("In der Kaufhalle.mp3");
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://translate.google.by/?hl=ru&tab=TT#view=home&op=translate&sl=ru&tl=de&text=%D0%BF%D1%80%D0%B8%D0%B2%D0%B5%D1%82");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            InfoForm newform = new InfoForm();
            newform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StForm newform = new StForm();
            newform.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}