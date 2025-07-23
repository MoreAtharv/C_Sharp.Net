
namespace SGM_College_APP
{
    partial class frm_Add_New_Student
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
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_Mob_no = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.tb_Mob = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.Leb_course = new System.Windows.Forms.Label();
            this.Lbl_DOB = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.Cmb_cours = new System.Windows.Forms.ComboBox();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.BackColor = System.Drawing.Color.White;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Modern No. 20", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(462, 36);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(418, 58);
            this.lbl_Add_New_Student.TabIndex = 11;
            this.lbl_Add_New_Student.Text = "Add New Student";
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_save.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_save.Location = new System.Drawing.Point(393, 654);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(204, 65);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_Mob_no
            // 
            this.lbl_Mob_no.AutoSize = true;
            this.lbl_Mob_no.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_no.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Mob_no.Location = new System.Drawing.Point(330, 348);
            this.lbl_Mob_no.Name = "lbl_Mob_no";
            this.lbl_Mob_no.Size = new System.Drawing.Size(187, 41);
            this.lbl_Mob_no.TabIndex = 9;
            this.lbl_Mob_no.Text = "Mobile No";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Roll_No.Location = new System.Drawing.Point(330, 138);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(146, 41);
            this.lbl_Roll_No.TabIndex = 8;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // tb_Mob
            // 
            this.tb_Mob.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.tb_Mob.Location = new System.Drawing.Point(635, 348);
            this.tb_Mob.MaxLength = 10;
            this.tb_Mob.Name = "tb_Mob";
            this.tb_Mob.Size = new System.Drawing.Size(348, 50);
            this.tb_Mob.TabIndex = 3;
            this.tb_Mob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.tb_Roll_No.Location = new System.Drawing.Point(635, 142);
            this.tb_Roll_No.MaxLength = 5;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(348, 50);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // Leb_course
            // 
            this.Leb_course.AutoSize = true;
            this.Leb_course.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leb_course.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Leb_course.Location = new System.Drawing.Point(332, 550);
            this.Leb_course.Name = "Leb_course";
            this.Leb_course.Size = new System.Drawing.Size(125, 41);
            this.Leb_course.TabIndex = 13;
            this.Leb_course.Text = "Course";
            // 
            // Lbl_DOB
            // 
            this.Lbl_DOB.AutoSize = true;
            this.Lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DOB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_DOB.Location = new System.Drawing.Point(332, 456);
            this.Lbl_DOB.Name = "Lbl_DOB";
            this.Lbl_DOB.Size = new System.Drawing.Size(244, 41);
            this.Lbl_DOB.TabIndex = 15;
            this.Lbl_DOB.Text = "Date Of Birth";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_Name.Location = new System.Drawing.Point(332, 241);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(121, 41);
            this.Lbl_Name.TabIndex = 17;
            this.Lbl_Name.Text = " Name";
            // 
            // Tb_Name
            // 
            this.Tb_Name.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.Tb_Name.Location = new System.Drawing.Point(637, 245);
            this.Tb_Name.MaxLength = 60;
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(348, 50);
            this.Tb_Name.TabIndex = 2;
            this.Tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.dtp_DOB.Location = new System.Drawing.Point(635, 463);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(350, 50);
            this.dtp_DOB.TabIndex = 4;
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
            this.Cmb_cours.Location = new System.Drawing.Point(635, 553);
            this.Cmb_cours.Name = "Cmb_cours";
            this.Cmb_cours.Size = new System.Drawing.Size(350, 49);
            this.Cmb_cours.TabIndex = 5;
            // 
            // btn_log_out
            // 
            this.btn_log_out.AutoSize = true;
            this.btn_log_out.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_log_out.Font = new System.Drawing.Font("Mongolian Baiti", 21.91304F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.Color.Blue;
            this.btn_log_out.Location = new System.Drawing.Point(1182, 3);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(204, 65);
            this.btn_log_out.TabIndex = 10;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click_1);
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.AutoSize = true;
            this.btn_Student_List.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Student_List.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_List.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Student_List.Location = new System.Drawing.Point(1001, 654);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(326, 65);
            this.btn_Student_List.TabIndex = 8;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            this.btn_Student_List.Click += new System.EventHandler(this.btn_Student_List_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.AutoSize = true;
            this.btn_Refresh.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Refresh.Location = new System.Drawing.Point(47, 654);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(273, 65);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_Add_New_Student);
            this.panel1.Controls.Add(this.btn_log_out);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 123);
            this.panel1.TabIndex = 18;
            // 
            // btn_Search1
            // 
            this.btn_Search1.AutoSize = true;
            this.btn_Search1.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Search1.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search1.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Search1.Location = new System.Drawing.Point(667, 654);
            this.btn_Search1.Name = "btn_Search1";
            this.btn_Search1.Size = new System.Drawing.Size(276, 65);
            this.btn_Search1.TabIndex = 9;
            this.btn_Search1.Text = "Search";
            this.btn_Search1.UseVisualStyleBackColor = false;
            this.btn_Search1.Click += new System.EventHandler(this.btn_Update1_Click);
            // 
            // frm_Add_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 755);
            this.Controls.Add(this.btn_Search1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Student_List);
            this.Controls.Add(this.Cmb_cours);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Tb_Name);
            this.Controls.Add(this.Lbl_DOB);
            this.Controls.Add(this.Leb_course);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_Mob_no);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.tb_Mob);
            this.Controls.Add(this.tb_Roll_No);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Student";
            this.Text = "Add_New_Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_Mob_no;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.TextBox tb_Mob;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label Leb_course;
        private System.Windows.Forms.Label Lbl_DOB;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox Cmb_cours;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Search1;
    }
}