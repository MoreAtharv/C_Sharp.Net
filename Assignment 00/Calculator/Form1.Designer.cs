
namespace Calculator
{
    partial class frm_Calculator
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
            this.lbl_Calculator = new System.Windows.Forms.Label();
            this.tb_No1 = new System.Windows.Forms.TextBox();
            this.tb_Answer = new System.Windows.Forms.TextBox();
            this.tb_No2 = new System.Windows.Forms.TextBox();
            this.lbl_No1 = new System.Windows.Forms.Label();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.lbl_No2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.btn_Div = new System.Windows.Forms.Button();
            this.btn_Mode = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Mult = new System.Windows.Forms.Button();
            this.btn_Clere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Calculator
            // 
            this.lbl_Calculator.AutoSize = true;
            this.lbl_Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calculator.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Calculator.Location = new System.Drawing.Point(57, 35);
            this.lbl_Calculator.Name = "lbl_Calculator";
            this.lbl_Calculator.Size = new System.Drawing.Size(331, 73);
            this.lbl_Calculator.TabIndex = 0;
            this.lbl_Calculator.Text = "Calculator";
            // 
            // tb_No1
            // 
            this.tb_No1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.7913F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_No1.Location = new System.Drawing.Point(251, 143);
            this.tb_No1.Name = "tb_No1";
            this.tb_No1.Size = new System.Drawing.Size(148, 51);
            this.tb_No1.TabIndex = 1;
            this.tb_No1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Answer
            // 
            this.tb_Answer.BackColor = System.Drawing.Color.OldLace;
            this.tb_Answer.Enabled = false;
            this.tb_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Answer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Answer.Location = new System.Drawing.Point(47, 560);
            this.tb_Answer.Name = "tb_Answer";
            this.tb_Answer.Size = new System.Drawing.Size(372, 47);
            this.tb_Answer.TabIndex = 2;
            // 
            // tb_No2
            // 
            this.tb_No2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.7913F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_No2.Location = new System.Drawing.Point(251, 216);
            this.tb_No2.Name = "tb_No2";
            this.tb_No2.Size = new System.Drawing.Size(148, 51);
            this.tb_No2.TabIndex = 2;
            this.tb_No2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_No1
            // 
            this.lbl_No1.AutoSize = true;
            this.lbl_No1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.7913F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_No1.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_No1.Location = new System.Drawing.Point(39, 148);
            this.lbl_No1.Name = "lbl_No1";
            this.lbl_No1.Size = new System.Drawing.Size(208, 44);
            this.lbl_No1.TabIndex = 4;
            this.lbl_No1.Text = "Number 1 :";
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Answer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Answer.Location = new System.Drawing.Point(134, 487);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(217, 54);
            this.lbl_Answer.TabIndex = 5;
            this.lbl_Answer.Text = "Answer  :";
            // 
            // lbl_No2
            // 
            this.lbl_No2.AutoSize = true;
            this.lbl_No2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.7913F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_No2.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_No2.Location = new System.Drawing.Point(39, 216);
            this.lbl_No2.Name = "lbl_No2";
            this.lbl_No2.Size = new System.Drawing.Size(208, 44);
            this.lbl_No2.TabIndex = 6;
            this.lbl_No2.Text = "Number 2 :";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(43, 306);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(72, 64);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sub.Location = new System.Drawing.Point(143, 306);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(72, 64);
            this.btn_Sub.TabIndex = 4;
            this.btn_Sub.Text = "-";
            this.btn_Sub.UseVisualStyleBackColor = false;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // btn_Div
            // 
            this.btn_Div.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Div.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Div.Location = new System.Drawing.Point(347, 306);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(72, 64);
            this.btn_Div.TabIndex = 6;
            this.btn_Div.Text = "/";
            this.btn_Div.UseVisualStyleBackColor = false;
            this.btn_Div.Click += new System.EventHandler(this.btn_Div_Click);
            // 
            // btn_Mode
            // 
            this.btn_Mode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Mode.Location = new System.Drawing.Point(43, 392);
            this.btn_Mode.Name = "btn_Mode";
            this.btn_Mode.Size = new System.Drawing.Size(72, 64);
            this.btn_Mode.TabIndex = 7;
            this.btn_Mode.Text = "%";
            this.btn_Mode.UseVisualStyleBackColor = false;
            this.btn_Mode.Click += new System.EventHandler(this.btn_Mode_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Min.Location = new System.Drawing.Point(249, 392);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(72, 64);
            this.btn_Min.TabIndex = 9;
            this.btn_Min.Text = "Min";
            this.btn_Min.UseVisualStyleBackColor = false;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Max.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Max.Location = new System.Drawing.Point(143, 392);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(72, 64);
            this.btn_Max.TabIndex = 8;
            this.btn_Max.Text = "Max";
            this.btn_Max.UseVisualStyleBackColor = false;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Mult
            // 
            this.btn_Mult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Mult.Location = new System.Drawing.Point(249, 306);
            this.btn_Mult.Name = "btn_Mult";
            this.btn_Mult.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.btn_Mult.Size = new System.Drawing.Size(72, 64);
            this.btn_Mult.TabIndex = 5;
            this.btn_Mult.Text = "*";
            this.btn_Mult.UseVisualStyleBackColor = false;
            this.btn_Mult.Click += new System.EventHandler(this.btn_Mult_Click);
            // 
            // btn_Clere
            // 
            this.btn_Clere.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Clere.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clere.Location = new System.Drawing.Point(347, 392);
            this.btn_Clere.Name = "btn_Clere";
            this.btn_Clere.Size = new System.Drawing.Size(72, 64);
            this.btn_Clere.TabIndex = 10;
            this.btn_Clere.Text = "C";
            this.btn_Clere.UseVisualStyleBackColor = false;
            this.btn_Clere.Click += new System.EventHandler(this.btn_Clere_Click);
            // 
            // frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(463, 648);
            this.Controls.Add(this.btn_Clere);
            this.Controls.Add(this.btn_Mult);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.btn_Mode);
            this.Controls.Add(this.btn_Div);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_No2);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.lbl_No1);
            this.Controls.Add(this.tb_No2);
            this.Controls.Add(this.tb_Answer);
            this.Controls.Add(this.tb_No1);
            this.Controls.Add(this.lbl_Calculator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frm_Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Calculator;
        private System.Windows.Forms.TextBox tb_No1;
        private System.Windows.Forms.TextBox tb_Answer;
        private System.Windows.Forms.TextBox tb_No2;
        private System.Windows.Forms.Label lbl_No1;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.Label lbl_No2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Sub;
        private System.Windows.Forms.Button btn_Div;
        private System.Windows.Forms.Button btn_Mode;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Mult;
        private System.Windows.Forms.Button btn_Clere;
    }
}

