namespace PeopleManager.Screens
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.lblWarning = new System.Windows.Forms.Label();
			this.lblForgetPassword = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.btnSignIn = new System.Windows.Forms.Button();
			this.pcbLogo = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblEmail.Location = new System.Drawing.Point(13, 183);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(58, 21);
			this.lblEmail.TabIndex = 2;
			this.lblEmail.Text = "E-mail:";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblSenha.Location = new System.Drawing.Point(13, 232);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(58, 21);
			this.lblSenha.TabIndex = 3;
			this.lblSenha.Text = "Senha:";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(77, 185);
			this.txtEmail.MaxLength = 80;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(254, 23);
			this.txtEmail.TabIndex = 4;
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(77, 230);
			this.txtSenha.MaxLength = 20;
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(254, 23);
			this.txtSenha.TabIndex = 5;
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.lblWarning.ForeColor = System.Drawing.Color.Red;
			this.lblWarning.Location = new System.Drawing.Point(144, 163);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(186, 19);
			this.lblWarning.TabIndex = 8;
			this.lblWarning.Text = "* E-mail ou senha incorretos";
			this.lblWarning.Visible = false;
			// 
			// lblForgetPassword
			// 
			this.lblForgetPassword.AutoSize = true;
			this.lblForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblForgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblForgetPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.lblForgetPassword.ForeColor = System.Drawing.Color.White;
			this.lblForgetPassword.Location = new System.Drawing.Point(187, 266);
			this.lblForgetPassword.Name = "lblForgetPassword";
			this.lblForgetPassword.Size = new System.Drawing.Size(143, 19);
			this.lblForgetPassword.TabIndex = 9;
			this.lblForgetPassword.Text = "Esqueci minha senha!";
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnExit.Image = global::PeopleManager.Properties.Resources.logout256_24927;
			this.btnExit.Location = new System.Drawing.Point(275, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(46, 41);
			this.btnExit.TabIndex = 10;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSignUp
			// 
			this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
			this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSignUp.FlatAppearance.BorderSize = 2;
			this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignUp.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnSignUp.Location = new System.Drawing.Point(16, 345);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(314, 41);
			this.btnSignUp.TabIndex = 7;
			this.btnSignUp.Text = "Criar Conta";
			this.btnSignUp.UseVisualStyleBackColor = false;
			// 
			// btnSignIn
			// 
			this.btnSignIn.BackColor = System.Drawing.Color.Teal;
			this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSignIn.FlatAppearance.BorderSize = 2;
			this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignIn.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnSignIn.Location = new System.Drawing.Point(16, 298);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(314, 41);
			this.btnSignIn.TabIndex = 6;
			this.btnSignIn.Text = "Entrar";
			this.btnSignIn.UseVisualStyleBackColor = false;
			this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
			// 
			// pcbLogo
			// 
			this.pcbLogo.Image = global::PeopleManager.Properties.Resources.Logo;
			this.pcbLogo.Location = new System.Drawing.Point(16, 12);
			this.pcbLogo.Name = "pcbLogo";
			this.pcbLogo.Size = new System.Drawing.Size(145, 135);
			this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbLogo.TabIndex = 0;
			this.pcbLogo.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblTitle.Location = new System.Drawing.Point(167, 56);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(155, 65);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Login";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(343, 394);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lblForgetPassword);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.btnSignUp);
			this.Controls.Add(this.btnSignIn);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pcbLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "::::: Login :::::";
			((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pcbLogo;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnSignIn;
		private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.Label lblWarning;
		private System.Windows.Forms.Label lblForgetPassword;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblTitle;
	}
}