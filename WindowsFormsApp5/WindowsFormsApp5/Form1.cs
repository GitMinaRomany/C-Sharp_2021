using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string User, pass;
    
        public Form1()
        {
            InitializeComponent();
            User = "Admin";
            pass = "123";

        }

        private void t_Tick(object sender, EventArgs e)
        {
            lab_Time.Text = DateTime.Now.ToString("dd MMMM yyyy hh:m:ss tt");
        }

        private void btn_EX_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            do
            {
                Properties.Settings.Default.ch_Log = 
                    (txt_user.Text == User && txt_Pass.Text == pass) ? true: false;
                Properties.Settings.Default.Save();
                Form2 fr2 = new Form2();
                if (Properties.Settings.Default.ch_Log == true) fr2.Show();

            } while (!(Properties.Settings.Default.ch_Log));


            /* while(!(txt_user.Text == User && txt_Pass.Text == pass))
             {
                 MessageBox.Show("Error");
                 break;
             }*/


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_SEt_Click(object sender, EventArgs e)
        {
            Button bty = new Button();
            bty.Text = "New Button";
            bty.Width = 80;
            bty.Height = 25;
            bty.Visible = true;
            bty.Location = new Point(10, 10);
            panel1.Controls.Add(bty);

        }
    }
}
