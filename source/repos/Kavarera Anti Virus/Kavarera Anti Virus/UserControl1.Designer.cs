namespace Kavarera_Anti_Virus
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwdtb = new System.Windows.Forms.TextBox();
            this.pwdstatuslbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 22F);
            this.label1.Location = new System.Drawing.Point(230, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Strength Checker";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-15, -15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // passwdtb
            // 
            this.passwdtb.Font = new System.Drawing.Font("Century", 18F);
            this.passwdtb.Location = new System.Drawing.Point(236, 193);
            this.passwdtb.Multiline = true;
            this.passwdtb.Name = "passwdtb";
            this.passwdtb.Size = new System.Drawing.Size(367, 37);
            this.passwdtb.TabIndex = 2;
            this.passwdtb.TextChanged += new System.EventHandler(this.Passwdtb_TextChanged);
            this.passwdtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Passwdtb_KeyDown);
            this.passwdtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Passwdtb_KeyPress);
            this.passwdtb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Passwdtb_KeyUp);
            // 
            // pwdstatuslbl
            // 
            this.pwdstatuslbl.AutoSize = true;
            this.pwdstatuslbl.BackColor = System.Drawing.Color.Transparent;
            this.pwdstatuslbl.Font = new System.Drawing.Font("Century", 20F);
            this.pwdstatuslbl.Location = new System.Drawing.Point(365, 98);
            this.pwdstatuslbl.Name = "pwdstatuslbl";
            this.pwdstatuslbl.Size = new System.Drawing.Size(92, 33);
            this.pwdstatuslbl.TabIndex = 3;
            this.pwdstatuslbl.Text = "label2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(764, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pwdstatuslbl);
            this.Controls.Add(this.passwdtb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 350);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox passwdtb;
        private System.Windows.Forms.Label pwdstatuslbl;
        private System.Windows.Forms.Button button2;
    }
}
