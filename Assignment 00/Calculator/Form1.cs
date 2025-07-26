using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frm_Calculator : Form
    {
        public frm_Calculator()
        {
            InitializeComponent();
        }

        private void frm_Calculator_Load(object sender, EventArgs e)
        {
            tb_Answer.Text = "Answer.";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int Res = Convert.ToInt32(tb_No1.Text) + Convert.ToInt32(tb_No2.Text);
            tb_Answer.Text = Convert.ToString(Res);
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            int Res = Convert.ToInt32(tb_No1.Text) - Convert.ToInt32(tb_No2.Text);
            tb_Answer.Text = Convert.ToString(Res);
        }

        private void btn_Mult_Click(object sender, EventArgs e)
        {
            int Res = Convert.ToInt32(tb_No1.Text) * Convert.ToInt32(tb_No2.Text);
            tb_Answer.Text = Convert.ToString(Res);
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            int Res = Convert.ToInt32(tb_No1.Text) / Convert.ToInt32(tb_No2.Text);
            tb_Answer.Text = Convert.ToString(Res);
        }

        private void btn_Mode_Click(object sender, EventArgs e)
        {
            int Res = Convert.ToInt32(tb_No1.Text) % Convert.ToInt32(tb_No2.Text);
            tb_Answer.Text = Convert.ToString(Res);
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tb_No1.Text) == Convert.ToInt32(tb_No2.Text))
            {
                tb_Answer.Text = tb_No1.Text + " And " + tb_No2.Text + " Are equal.";
            }
            else if (Convert.ToInt32(tb_No1.Text) > Convert.ToInt32(tb_No2.Text))
            {
                tb_Answer.Text = (tb_No1.Text) + " is Maximum.";
            }
            else
            {
                tb_Answer.Text = (tb_No2.Text) + " is Maximum.";
            }

        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tb_No1.Text) == Convert.ToInt32(tb_No2.Text))
            {
                tb_Answer.Text = tb_No1.Text + "And" + tb_No2.Text + "Are equal.";
            }
            else if (Convert.ToInt32(tb_No1.Text) < Convert.ToInt32(tb_No2.Text))
            {
                tb_Answer.Text = (tb_No1.Text) + " is Minimum.";
            }
            else
            {
                tb_Answer.Text = (tb_No2.Text) + " is Minimum.";
            }
        }
        void Clear_Controls()
        {
            tb_No1.Clear();
            tb_No2.Clear();
            tb_Answer.Clear();
        }

        
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Clere_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}

