
namespace WindowsFormsApp5
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_Time = new System.Windows.Forms.Label();
            this.btn_EX = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.lab_Time);
            this.panel1.Controls.Add(this.btn_EX);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 354);
            this.panel1.TabIndex = 11;
            // 
            // lab_Time
            // 
            this.lab_Time.AutoSize = true;
            this.lab_Time.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lab_Time.ForeColor = System.Drawing.Color.CadetBlue;
            this.lab_Time.Location = new System.Drawing.Point(320, 151);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(149, 46);
            this.lab_Time.TabIndex = 16;
            this.lab_Time.Text = "Welcom";
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
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_EX;
        private System.Windows.Forms.Label lab_Time;
    }
}

