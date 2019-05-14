using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winapp
{
    public partial class ExForm : Form
    {
        public ExForm()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\An der Kasse.docx");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Die Kleidung.docx");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Im Kaufhaus 1.docx");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Im Kaufhaus 2.docx");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Im Kaufhaus 3.docx");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Im Kaufhaus 4.docx");
        }


        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Im Supermarkt 1.docx");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Im Supermarkt 2.docx");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Im Supermarkt 3.docx");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\In der Geschenkabteilung.docx");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Ordnen Sie die Lebensmittel den richtigen Oberbegriffen zu.docx");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Test zum Thema   das Essen.docx");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Ordne zu!.docx");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Упражнения\\Im Supermarkt 4.docx");
        }
    }
}
