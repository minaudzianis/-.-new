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
    public partial class StForm : Form
    {
        public StForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Hide();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Rectangle itemRect = listBox1.GetItemRectangle(listBox1.SelectedIndex);

            if (itemRect.Contains(e.Location))
            {
                System.Diagnostics.Process.Start("Упражнения\\Die Kleidung.docx");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                return;
            }

            catch
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //listBox1.SelectedIndex = Convert.ToInt32(textBox1.Text);//учитывай какие у тебя здесь значения
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox1.Text = listBox1.SelectedIndex.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Insert();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PassForm newform = new PassForm();
            newform.ShowDialog();
            Hide();
            //this.Hide();
        }
    }
}
