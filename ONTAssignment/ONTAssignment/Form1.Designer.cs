namespace ONTAssignment
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnABC = new System.Windows.Forms.Button();
            this.btnDEF = new System.Windows.Forms.Button();
            this.btnGHI = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(47, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(47, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(183, 83);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnABC
            // 
            this.btnABC.Location = new System.Drawing.Point(47, 144);
            this.btnABC.Name = "btnABC";
            this.btnABC.Size = new System.Drawing.Size(75, 23);
            this.btnABC.TabIndex = 5;
            this.btnABC.Text = "ABC";
            this.btnABC.UseVisualStyleBackColor = true;
            this.btnABC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDEF
            // 
            this.btnDEF.Location = new System.Drawing.Point(149, 144);
            this.btnDEF.Name = "btnDEF";
            this.btnDEF.Size = new System.Drawing.Size(75, 23);
            this.btnDEF.TabIndex = 6;
            this.btnDEF.Text = "DEF";
            this.btnDEF.UseVisualStyleBackColor = true;
            this.btnDEF.Click += new System.EventHandler(this.btnDEF_Click);
            // 
            // btnGHI
            // 
            this.btnGHI.Location = new System.Drawing.Point(251, 144);
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(75, 23);
            this.btnGHI.TabIndex = 7;
            this.btnGHI.Text = "GHI";
            this.btnGHI.UseVisualStyleBackColor = true;
            this.btnGHI.Click += new System.EventHandler(this.btnGHI_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(47, 196);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(322, 200);
            this.rtbDisplay.TabIndex = 8;
            this.rtbDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnGHI);
            this.Controls.Add(this.btnDEF);
            this.Controls.Add(this.btnABC);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnABC;
        private System.Windows.Forms.Button btnDEF;
        private System.Windows.Forms.Button btnGHI;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

