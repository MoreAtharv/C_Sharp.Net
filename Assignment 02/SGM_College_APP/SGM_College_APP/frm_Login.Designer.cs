
namespace SGM_College_APP
{
    partial class frm_Login
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
            this.tb_User_Name = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Submit_ = new System.Windows.Forms.Button();
            this.lbl_Login_Frm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_User_Name
            // 
            this.tb_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User_Name.Location = new System.Drawing.Point(583, 180);
            this.tb_User_Name.MaxLength = 10;
            this.tb_User_Name.Name = "tb_User_Name";
            this.tb_User_Name.Size = new System.Drawing.Size(348, 38);
            this.tb_User_Name.TabIndex = 0;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(583, 299);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(348, 38);
            this.tb_Password.TabIndex = 1;
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.Location = new System.Drawing.Point(243, 180);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(195, 41);
            this.lbl_User_Name.TabIndex = 2;
            this.lbl_User_Name.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btn_Submit_
            // 
            this.btn_Submit_.AutoSize = true;
            this.btn_Submit_.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Submit_.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit_.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Submit_.Location = new System.Drawing.Point(429, 430);
            this.btn_Submit_.Name = "btn_Submit_";
            this.btn_Submit_.Size = new System.Drawing.Size(281, 65);
            this.btn_Submit_.TabIndex = 4;
            this.btn_Submit_.Text = "Submit";
            this.btn_Submit_.UseVisualStyleBackColor = false;
            this.btn_Submit_.Click += new System.EventHandler(this.btn_Submit__Click);
            // 
            // lbl_Login_Frm
            // 
            this.lbl_Login_Frm.AutoSize = true;
            this.lbl_Login_Frm.BackColor = System.Drawing.Color.White;
            this.lbl_Login_Frm.Font = new System.Drawing.Font("Modern No. 20", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Frm.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Login_Frm.Location = new System.Drawing.Point(438, 40);
            this.lbl_Login_Frm.Name = "lbl_Login_Frm";
            this.lbl_Login_Frm.Size = new System.Drawing.Size(299, 58);
            this.lbl_Login_Frm.TabIndex = 5;
            this.lbl_Login_Frm.Text = "Login From";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1123, 599);
            this.Controls.Add(this.lbl_Login_Frm);
            this.Controls.Add(this.btn_Submit_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_User_Name);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_User_Name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_User_Name;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Submit_;
        private System.Windows.Forms.Label lbl_Login_Frm;
    }
}

