using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGM_College_APP
{
    public partial class frm_Login : Form
    {
        

        public frm_Login()
        {
            InitializeComponent();
        }

     

        private void btn_Submit__Click(object sender, EventArgs e)
        {
            if (tb_User_Name.Text == "Admin" && tb_Password.Text == "a123")
            {
                frm_Add_New_Student ANS = new frm_Add_New_Student();
                ANS.Show();
                this.Hide();
            }
        }
    }
}
