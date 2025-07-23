using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_College_APP
{
    public partial class Frm_Student_Details_Search : Form
    {
        public Frm_Student_Details_Search()
        {
            InitializeComponent();
        }
        SqlConnection DBCon = new SqlConnection(@"Data Source=DESKTOP-2RCOABL;Initial Catalog=SGM_Student_Addmission_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (DBCon.State != ConnectionState.Open)
            {
                DBCon.Open();
            }
        }

        void Con_Close()
        {
            if (DBCon.State != ConnectionState.Closed)
            {
                DBCon.Close();
            }
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();

        }
       
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("Select * from Student_Details Where Roll_No = @RNo", DBCon);
            cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

            SqlDataReader Dr = cmd.ExecuteReader();
            if (Dr.Read())
            {
                Tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mob.Text = (Dr["MOB_No"].ToString());
                Cmb_cours.Text = Dr.GetString(Dr.GetOrdinal("Cource"));
                dtp_DOB.Text = (Dr["DOB"].ToString());

            }
            else
            {
                MessageBox.Show("No Record Found", "Invalid Roll No");
                tb_Roll_No.Clear();
            }
            Con_Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

      
        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            Tb_Name.Clear();
            tb_Mob.Clear();
            Cmb_cours.SelectedIndex = -1;
            dtp_DOB.ResetText();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List_Details obj = new frm_Student_List_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_STD_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();
            Obj.Show();
            this.Hide();
        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
