using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech;
using System.Drawing;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fd = new FolderBrowserDialog();
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (.PNG)|*.PNG";
            //choofdlog.FilterIndex = 1;

            //choofdlog.Multiselect = true;
            

            //

            DialogResult result = choofdlog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pic_user.Image = Image.FromFile(choofdlog.FileName);
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save_info();
        }

        private string[] Get_info()
        {
            if ((txt_n.Text.Length != 0) && (txt_ph.Text.Length != 0) && (txt_e.Text.Length != 0))
            {
                string[] inf = new string[3] { txt_n.Text, txt_ph.Text, txt_e.Text };
                return inf;
            }
            else 
            { 
                
                return null; 
            
            }
        }
        void Save_info ()
        {
            //sw = new StreamWriter("Data.txt");
            sw = File.AppendText("Data.txt");
            String rd = "";
            foreach (String STR in Get_info())
            {
                rd += STR + ',';
            }
            sw.WriteLine(rd.Substring(0,rd.Length - 2));
            sw.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
