
namespace SGM_College_APP
{
    partial class Frm_Student_Details_Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Student_Details = new System.Windows.Forms.Label();
            this.Cmb_cours = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.Lbl_DOB = new System.Windows.Forms.Label();
            this.Leb_course = new System.Windows.Forms.Label();
            this.btn_Add_New_STD = new System.Windows.Forms.Button();
            this.lbl_Mob_no = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.tb_Mob = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.AutoSize = true;
            this.btn_Refresh.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Refresh.Location = new System.Drawing.Point(181, 651);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(273, 65);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click_1);
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.AutoSize = true;
            this.btn_Student_List.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Student_List.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_List.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Student_List.Location = new System.Drawing.Point(955, 651);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(343, 65);
            this.btn_Student_List.TabIndex = 9;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            this.btn_Student_List.Click += new System.EventHandler(this.btn_Student_List_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.AutoSize = true;
            this.btn_log_out.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_log_out.Font = new System.Drawing.Font("Mongolian Baiti", 21.91304F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.Color.Blue;
            this.btn_log_out.Location = new System.Drawing.Point(1167, 0);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(204, 65);
            this.btn_log_out.TabIndex = 10;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_Student_Details);
            this.panel1.Controls.Add(this.btn_log_out);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 100);
            this.panel1.TabIndex = 33;
            // 
            // lbl_Student_Details
            // 
            this.lbl_Student_Details.AutoSize = true;
            this.lbl_Student_Details.BackColor = System.Drawing.Color.White;
            this.lbl_Student_Details.Font = new System.Drawing.Font("Modern No. 20", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Details.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Student_Details.Location = new System.Drawing.Point(446, 21);
            this.lbl_Student_Details.Name = "lbl_Student_Details";
            this.lbl_Student_Details.Size = new System.Drawing.Size(387, 58);
            this.lbl_Student_Details.TabIndex = 11;
            this.lbl_Student_Details.Text = " Student Details";
            // 
            // Cmb_cours
            // 
            this.Cmb_cours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_cours.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.Cmb_cours.FormattingEnabled = true;
            this.Cmb_cours.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "BSc.C.S",
            "MCS",
            "MCA",
            "MSc.C.S"});
            this.Cmb_cours.Location = new System.Drawing.Point(636, 550);
            this.Cmb_cours.Name = "Cmb_cours";
            this.Cmb_cours.Size = new System.Drawing.Size(350, 49);
            this.Cmb_cours.TabIndex = 6;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.dtp_DOB.Location = new System.Drawing.Point(636, 460);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(350, 50);
            this.dtp_DOB.TabIndex = 5;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_Name.Location = new System.Drawing.Point(333, 238);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(121, 41);
            this.Lbl_Name.TabIndex = 32;
            this.Lbl_Name.Text = " Name";
            // 
            // Tb_Name
            // 
            this.Tb_Name.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.Tb_Name.Location = new System.Drawing.Point(638, 242);
            this.Tb_Name.MaxLength = 60;
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(348, 50);
            this.Tb_Name.TabIndex = 3;
            // 
            // Lbl_DOB
            // 
            this.Lbl_DOB.AutoSize = true;
            this.Lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DOB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_DOB.Location = new System.Drawing.Point(333, 453);
            this.Lbl_DOB.Name = "Lbl_DOB";
            this.Lbl_DOB.Size = new System.Drawing.Size(244, 41);
            this.Lbl_DOB.TabIndex = 31;
            this.Lbl_DOB.Text = "Date Of Birth";
            // 
            // Leb_course
            // 
            this.Leb_course.AutoSize = true;
            this.Leb_course.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leb_course.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Leb_course.Location = new System.Drawing.Point(333, 547);
            this.Leb_course.Name = "Leb_course";
            this.Leb_course.Size = new System.Drawing.Size(125, 41);
            this.Leb_course.TabIndex = 30;
            this.Leb_course.Text = "Course";
            // 
            // btn_Add_New_STD
            // 
            this.btn_Add_New_STD.AutoSize = true;
            this.btn_Add_New_STD.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Add_New_STD.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_STD.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Add_New_STD.Location = new System.Drawing.Point(518, 651);
            this.btn_Add_New_STD.Name = "btn_Add_New_STD";
            this.btn_Add_New_STD.Size = new System.Drawing.Size(372, 65);
            this.btn_Add_New_STD.TabIndex = 8;
            this.btn_Add_New_STD.Text = "Add New Student";
            this.btn_Add_New_STD.UseVisualStyleBackColor = false;
            this.btn_Add_New_STD.Click += new System.EventHandler(this.btn_Add_New_STD_Click);
            // 
            // lbl_Mob_no
            // 
            this.lbl_Mob_no.AutoSize = true;
            this.lbl_Mob_no.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_no.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Mob_no.Location = new System.Drawing.Point(331, 345);
            this.lbl_Mob_no.Name = "lbl_Mob_no";
            this.lbl_Mob_no.Size = new System.Drawing.Size(187, 41);
            this.lbl_Mob_no.TabIndex = 29;
            this.lbl_Mob_no.Text = "Mobile No";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Roll_No.Location = new System.Drawing.Point(331, 135);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(146, 41);
            this.lbl_Roll_No.TabIndex = 28;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // tb_Mob
            // 
            this.tb_Mob.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.tb_Mob.Location = new System.Drawing.Point(636, 345);
            this.tb_Mob.MaxLength = 10;
            this.tb_Mob.Name = "tb_Mob";
            this.tb_Mob.Size = new System.Drawing.Size(348, 50);
            this.tb_Mob.TabIndex = 4;
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.tb_Roll_No.Location = new System.Drawing.Point(636, 139);
            this.tb_Roll_No.MaxLength = 5;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(348, 50);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Search.Location = new System.Drawing.Point(990, 139);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(102, 50);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Frm_Student_Details_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 755);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Student_List);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cmb_cours);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Tb_Name);
            this.Controls.Add(this.Lbl_DOB);
            this.Controls.Add(this.Leb_course);
            this.Controls.Add(this.btn_Add_New_STD);
            this.Controls.Add(this.lbl_Mob_no);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.tb_Mob);
            this.Controls.Add(this.tb_Roll_No);
            this.Name = "Frm_Student_Details_Search";
            this.Text = "Frm_Student_Ditails_Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Student_Details;
        private System.Windows.Forms.ComboBox Cmb_cours;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.Label Lbl_DOB;
        private System.Windows.Forms.Label Leb_course;
        private System.Windows.Forms.Button btn_Add_New_STD;
        private System.Windows.Forms.Label lbl_Mob_no;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.TextBox tb_Mob;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Button btn_Search;
    }
}