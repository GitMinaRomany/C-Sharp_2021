
namespace WindowsFormsApp5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SEt = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.lab_Time = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pass = new Guna.UI.WinForms.GunaTextBox();
            this.txt_user = new Guna.UI.WinForms.GunaTextBox();
            this.btn_EX = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_SEt);
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.lab_Time);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Pass);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.btn_EX);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 354);
            this.panel1.TabIndex = 11;
            // 
            // btn_SEt
            // 
            this.btn_SEt.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_SEt.Location = new System.Drawing.Point(725, 3);
            this.btn_SEt.Name = "btn_SEt";
            this.btn_SEt.Size = new System.Drawing.Size(30, 30);
            this.btn_SEt.TabIndex = 18;
            this.btn_SEt.Text = "-";
            this.btn_SEt.UseVisualStyleBackColor = false;
            this.btn_SEt.Click += new System.EventHandler(this.btn_SEt_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_min.Location = new System.Drawing.Point(689, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(30, 30);
            this.btn_min.TabIndex = 17;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // lab_Time
            // 
            this.lab_Time.AutoSize = true;
            this.lab_Time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lab_Time.ForeColor = System.Drawing.Color.CadetBlue;
            this.lab_Time.Location = new System.Drawing.Point(9, 327);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(90, 21);
            this.lab_Time.TabIndex = 16;
            this.lab_Time.Text = "Password :";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_Login.Location = new System.Drawing.Point(511, 231);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(192, 45);
            this.btn_Login.TabIndex = 15;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(155, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(150, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username :";
            // 
            // txt_Pass
            // 
            this.txt_Pass.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_Pass.BorderColor = System.Drawing.Color.CadetBlue;
            this.txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pass.FocusedBaseColor = System.Drawing.Color.CadetBlue;
            this.txt_Pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Pass.ForeColor = System.Drawing.Color.CadetBlue;
            this.txt_Pass.Location = new System.Drawing.Point(269, 139);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '\0';
            this.txt_Pass.Size = new System.Drawing.Size(319, 32);
            this.txt_Pass.TabIndex = 12;
            // 
            // txt_user
            // 
            this.txt_user.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_user.BorderColor = System.Drawing.Color.CadetBlue;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.FocusedBaseColor = System.Drawing.Color.CadetBlue;
            this.txt_user.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txt_user.ForeColor = System.Drawing.Color.CadetBlue;
            this.txt_user.Location = new System.Drawing.Point(269, 91);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.Size = new System.Drawing.Size(319, 32);
            this.txt_user.TabIndex = 11;
            // 
            // btn_EX
            // 
            this.btn_EX.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_EX.Location = new System.Drawing.Point(761, 3);
            this.btn_EX.Name = "btn_EX";
            this.btn_EX.Size = new System.Drawing.Size(30, 30);
            this.btn_EX.TabIndex = 10;
            this.btn_EX.Text = "X";
            this.btn_EX.UseVisualStyleBackColor = false;
            this.btn_EX.Click += new System.EventHandler(this.btn_EX_Click);
            // 
            // t
            // 
            this.t.Enabled = true;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.Location = new System.Drawing.Point(296, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_EX;
        private System.Windows.Forms.Label lab_Time;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_Pass;
        private Guna.UI.WinForms.GunaTextBox txt_user;
        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.Button btn_min;
        public System.Windows.Forms.Button btn_SEt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

