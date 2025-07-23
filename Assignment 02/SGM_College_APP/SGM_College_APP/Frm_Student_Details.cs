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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
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
        private void btn_save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Roll_No.Text != "" && Tb_Name.Text != "" && dtp_DOB.Text != "" && tb_Mob.Text != "" && Cmb_cours.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = DBCon;
                Cmd.CommandText = "Insert Into Student_Details (Roll_No,Name,Mob_No,DOB,Cource)Values(@RNo,@Nm,@MNo,@Dob,@Cource)";
                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = Tb_Name.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mob.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Cource", SqlDbType.NVarChar).Value = Cmb_cours.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("First Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Con_Close();
        }
        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List_Details obj = new frm_Student_List_Details();
            obj.Show();
            this.Hide();
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

        private void btn_log_out_Click_1(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Update1_Click(object sender, EventArgs e)
        {
            Frm_Student_Details_Search obj = new Frm_Student_Details_Search();
            obj.Show();
            this.Hide();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {

        }
    }
}
