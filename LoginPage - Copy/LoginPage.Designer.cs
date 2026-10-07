namespace LoginPage
{
    partial class LoginPage
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
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UseridLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.InstructionLbl = new System.Windows.Forms.Label();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UseridTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordLbl.Location = new System.Drawing.Point(50, 251);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(74, 20);
            this.PasswordLbl.TabIndex = 15;
            this.PasswordLbl.Text = "Password";
            // 
            // UseridLbl
            // 
            this.UseridLbl.AutoSize = true;
            this.UseridLbl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseridLbl.ForeColor = System.Drawing.Color.DimGray;
            this.UseridLbl.Location = new System.Drawing.Point(50, 190);
            this.UseridLbl.Name = "UseridLbl";
            this.UseridLbl.Size = new System.Drawing.Size(61, 20);
            this.UseridLbl.TabIndex = 14;
            this.UseridLbl.Text = "UserID";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(54, 325);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(300, 32);
            this.LoginBtn.TabIndex = 13;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // InstructionLbl
            // 
            this.InstructionLbl.AutoSize = true;
            this.InstructionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLbl.Location = new System.Drawing.Point(84, 127);
            this.InstructionLbl.Name = "InstructionLbl";
            this.InstructionLbl.Size = new System.Drawing.Size(239, 15);
            this.InstructionLbl.TabIndex = 12;
            this.InstructionLbl.Text = "Sign in with your organizational id number.";
            // 
            // LoginLbl
            // 
            this.LoginLbl.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LoginLbl.Location = new System.Drawing.Point(74, 46);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(260, 85);
            this.LoginLbl.TabIndex = 11;
            this.LoginLbl.Text = "Sign In";
            this.LoginLbl.UseCompatibleTextRendering = true;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Dusha V5", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.ForeColor = System.Drawing.Color.LightGray;
            this.PasswordTxt.Location = new System.Drawing.Point(54, 274);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(300, 28);
            this.PasswordTxt.TabIndex = 10;
            this.PasswordTxt.TabStop = false;
            this.PasswordTxt.Text = "Enter Your Password";
            this.PasswordTxt.Enter += new System.EventHandler(this.PasswordTxt_Enter);
            this.PasswordTxt.Leave += new System.EventHandler(this.PasswordTxt_Leave);
            // 
            // UseridTxt
            // 
            this.UseridTxt.Font = new System.Drawing.Font("Dusha V5", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseridTxt.ForeColor = System.Drawing.Color.LightGray;
            this.UseridTxt.Location = new System.Drawing.Point(54, 213);
            this.UseridTxt.Name = "UseridTxt";
            this.UseridTxt.Size = new System.Drawing.Size(300, 28);
            this.UseridTxt.TabIndex = 9;
            this.UseridTxt.TabStop = false;
            this.UseridTxt.Text = "Enter Your UserID";
            this.UseridTxt.Enter += new System.EventHandler(this.UseridTxt_Enter);
            this.UseridTxt.Leave += new System.EventHandler(this.UseridTxt_Leave);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 441);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UseridLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.InstructionLbl);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UseridTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label UseridLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label InstructionLbl;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UseridTxt;
    }
}

