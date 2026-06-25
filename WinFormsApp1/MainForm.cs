using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm(string name, string role)
        {
            InitializeComponent();
            Main("id");
            pictureBox1.Image = Image.FromFile("C:\\Users\\daniil\\Downloads\\images.png");
            if (role == "Администратор")
            {
                lblName.Text = name;
            }
            else if (role == "Менеджер")
            {
                lblName.Text = name;
                btnAdmin.Hide();
            }
            else if (role == "Клиент")
            {
                lblName.Text = name;
                btnAdmin.Hide();
                btnManager.Hide();
            }
            else
            {
                btnAdmin.Hide();
                btnManager.Hide();
                lblName.Hide();
                cbSort.Hide();
            }
        }

        public void Main(string input)
        {
            flowLayoutPanel1.Controls.Clear();
            string[][] main = DBHelper.Start(input);
            foreach (string[] s in main)
            {
                plitka pl = new plitka();
                pl.ImportData(s);
                flowLayoutPanel1.Controls.Add(pl);
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {
                Main("id");
            }
            else if (cbSort.SelectedIndex == 1)
            {
                Main("name");
            }
            else if (cbSort.SelectedIndex == 2)
            {
                Main("price");
            }
            else if (cbSort.SelectedIndex == 3)
            {
                Main("discount");
            }
            else
            {
                MessageBox.Show("Не верный запрос!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
