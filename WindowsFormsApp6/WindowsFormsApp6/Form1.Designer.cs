
namespace WindowsFormsApp6
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
            this.txt_n = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_num = new System.Windows.Forms.Label();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.txt_ph = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.pic_user = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(87, 27);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(100, 20);
            this.txt_n.TabIndex = 0;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.Location = new System.Drawing.Point(25, 30);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(55, 20);
            this.lab_name.TabIndex = 1;
            this.lab_name.Text = "Name";
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_num.Location = new System.Drawing.Point(25, 62);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(59, 20);
            this.lab_num.TabIndex = 2;
            this.lab_num.Text = "phone";
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_email.Location = new System.Drawing.Point(24, 103);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(59, 20);
            this.lab_email.TabIndex = 3;
            this.lab_email.Text = "E-mail";
            // 
            // txt_e
            // 
            this.txt_e.Location = new System.Drawing.Point(87, 103);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(100, 20);
            this.txt_e.TabIndex = 2;
            // 
            // txt_ph
            // 
            this.txt_ph.Location = new System.Drawing.Point(87, 62);
            this.txt_ph.Name = "txt_ph";
            this.txt_ph.Size = new System.Drawing.Size(100, 20);
            this.txt_ph.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(62, 149);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(229, 40);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pic_user
            // 
            this.pic_user.Image = global::WindowsFormsApp6.Properties.Resources.icons8_male_user_1001;
            this.pic_user.Location = new System.Drawing.Point(214, 27);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(103, 95);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_user.TabIndex = 6;
            this.pic_user.TabStop = false;
            this.pic_user.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 217);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pic_user);
            this.Controls.Add(this.txt_ph);
            this.Controls.Add(this.txt_e);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.lab_num);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.txt_n);
            this.Name = "Form1";
            this.Text = "Information User";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_num;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.TextBox txt_ph;
        private System.Windows.Forms.PictureBox pic_user;
        private System.Windows.Forms.Button btn_save;
    }
}

