using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculetor
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            txt_printup.Enabled = false;

        }

        private void btn_cl_Click(object sender, EventArgs e)
        {
            txt_printup.Text = ""; txt_printdown.Text = "";
            lab_op.Text = "";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //txt_printup.Text = txt_printup.Text.Substring(0, txt_printup.Text.Length - 1);
            txt_printdown.Text = txt_printdown.Text.Substring(0, txt_printdown.Text.Length - 1);

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            lab_op.Text = "";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_printdown.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_printdown.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_printdown.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_printdown.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_printdown.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_printdown.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_printdown.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_printdown.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_printdown.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_printdown.Text += "9";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            foreach(var i in txt_printdown.Text.ToCharArray())
            {
                if (i == '.') return; 
            }
            txt_printdown.Text += btn_dot.Text;
        }

        private void btn_N_P_Click(object sender, EventArgs e)
        {
            if (txt_printdown.Text[0] != '-') txt_printdown.Text = "-" + txt_printdown.Text;
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            if (txt_printdown.Text == "")
            {
                lab_op.Text = btn_sum.Text;
                return;
            }
            try
            {
                Convert.ToDouble(txt_printdown.Text);
                txt_printup.Text = txt_printdown.Text;
                lab_op.Text = btn_sum.Text;
                txt_printdown.Text = "";
            }
            catch (Exception)
            {


            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (txt_printdown.Text == "")
            {
                lab_op.Text = btn_sub.Text;
                return;
            }
            try
            {
                Convert.ToDouble(txt_printdown.Text);
                txt_printup.Text = txt_printdown.Text;
                lab_op.Text = btn_pow.Text;
                txt_printdown.Text = "";
            }
            catch (Exception)
            {


            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (txt_printdown.Text == "")
            {
                lab_op.Text = btn_mul.Text;
                return;
            }
            try
            {
                Convert.ToDouble(txt_printdown.Text);
                txt_printup.Text = txt_printdown.Text;
                lab_op.Text = btn_mul.Text;
                txt_printdown.Text = "";
            }
            catch (Exception)
            {


            }
        }

        private void btn_dv_Click(object sender, EventArgs e)
        {
            if (txt_printdown.Text == "")
            {
                lab_op.Text = btn_dv.Text;
                return;
            }
            try
            {
                Convert.ToDouble(txt_printdown.Text);
                txt_printup.Text = txt_printdown.Text;
                lab_op.Text = btn_dv.Text;
                txt_printdown.Text = "";
            }
            catch (Exception)
            {


            }
        }

        private void btn_re_Click(object sender, EventArgs e)
        {
            if (txt_printup.Text == "" || txt_printdown.Text == "" || lab_op.Text == "") return;
            try
            {
                Convert.ToDouble(txt_printdown.Text);
                switch(lab_op.Text[0])
                {
                    case '+':
                        txt_printup.Text = string.Format("{0}",(Convert.ToDouble(txt_printup.Text) + Convert.ToDouble(txt_printdown.Text)));
                        txt_printdown.Text = null;
                        break;

                }
            }
            catch (Exception)
            {
                return;
            }

        }
        private void btn_pow_Click(object sender, EventArgs e)
        {
            if (txt_printdown.Text == "")
            {
                lab_op.Text = btn_pow.Text;
                return;     
            }
            try
            {
                Convert.ToDouble(txt_printdown.Text);
                txt_printup.Text = txt_printdown.Text;
                lab_op.Text = btn_pow.Text;
                txt_printdown.Text = "";
            }
            catch (Exception)
            {


            }
        }
    }
}
