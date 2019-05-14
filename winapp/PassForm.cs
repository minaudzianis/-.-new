using System;
using System.Drawing;
using System.Windows.Forms;

namespace winapp
{
    public partial class PassForm : Form
    {
        public PassForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show(
                     "Неверный пароль",
                     "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button2,
                     MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                int rightpass = 123222;
                int a = Convert.ToInt32(textBox1.Text);

                if (a != rightpass)
                {
                    MessageBox.Show(
                        "Неверный пароль",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.DefaultDesktopOnly);
                }

                if (a == rightpass)
                {
                    StForm f2 = new StForm();
                    Hide();
                    
                    f2.Show();
                    f2.Width = 430;
                    f2.BackButton.Location = new Point(82, 260);
                    f2.AddButton.Visible = true;
                    f2.EditButton.Visible = true;
                    f2.DelButton.Visible = true;
                    f2.TButton.Visible = false;
                }
            }
        }
    }
}
