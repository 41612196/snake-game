namespace Snake
{
    partial class register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.btnRegister_OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.reg_Info = new System.Windows.Forms.Label();
            this.pwdInfo = new System.Windows.Forms.Label();
            this.timer_reg = new System.Windows.Forms.Timer(this.components);
            this.regOK = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(222, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "输入昵称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(222, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "输入密码：";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.username.Location = new System.Drawing.Point(339, 159);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(174, 30);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.password.Location = new System.Drawing.Point(339, 230);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(174, 30);
            this.password.TabIndex = 2;
            // 
            // btnRegister_OK
            // 
            this.btnRegister_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegister_OK.Location = new System.Drawing.Point(246, 377);
            this.btnRegister_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister_OK.Name = "btnRegister_OK";
            this.btnRegister_OK.Size = new System.Drawing.Size(114, 41);
            this.btnRegister_OK.TabIndex = 7;
            this.btnRegister_OK.Text = "确定注册";
            this.btnRegister_OK.UseVisualStyleBackColor = false;
            this.btnRegister_OK.Click += new System.EventHandler(this.btnRegister_OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(222, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码：";
            // 
            // password1
            // 
            this.password1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.password1.Location = new System.Drawing.Point(339, 299);
            this.password1.Margin = new System.Windows.Forms.Padding(4);
            this.password1.Name = "password1";
            this.password1.PasswordChar = '*';
            this.password1.Size = new System.Drawing.Size(174, 30);
            this.password1.TabIndex = 3;
            // 
            // reg_Info
            // 
            this.reg_Info.BackColor = System.Drawing.Color.Transparent;
            this.reg_Info.ForeColor = System.Drawing.Color.Red;
            this.reg_Info.Location = new System.Drawing.Point(345, 195);
            this.reg_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reg_Info.Name = "reg_Info";
            this.reg_Info.Size = new System.Drawing.Size(243, 31);
            this.reg_Info.TabIndex = 9;
            this.reg_Info.Text = "reg_Info";
            // 
            // pwdInfo
            // 
            this.pwdInfo.BackColor = System.Drawing.Color.Transparent;
            this.pwdInfo.ForeColor = System.Drawing.Color.Red;
            this.pwdInfo.Location = new System.Drawing.Point(335, 333);
            this.pwdInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwdInfo.Name = "pwdInfo";
            this.pwdInfo.Size = new System.Drawing.Size(157, 31);
            this.pwdInfo.TabIndex = 10;
            this.pwdInfo.Text = "is same?";
            // 
            // timer_reg
            // 
            this.timer_reg.Tick += new System.EventHandler(this.timer_reg_Tick);
            // 
            // regOK
            // 
            this.regOK.BackColor = System.Drawing.Color.Transparent;
            this.regOK.Font = new System.Drawing.Font("幼圆", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.regOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.regOK.Location = new System.Drawing.Point(296, 66);
            this.regOK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regOK.Name = "regOK";
            this.regOK.Size = new System.Drawing.Size(228, 31);
            this.regOK.TabIndex = 11;
            this.regOK.Text = "regOK";
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBackToLogin.Location = new System.Drawing.Point(398, 377);
            this.btnBackToLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(115, 41);
            this.btnBackToLogin.TabIndex = 8;
            this.btnBackToLogin.Text = "返回登录";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources._4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(638, 476);
            this.Controls.Add(this.regOK);
            this.Controls.Add(this.pwdInfo);
            this.Controls.Add(this.reg_Info);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnRegister_OK);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "register";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btnRegister_OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label reg_Info;
        private System.Windows.Forms.Label pwdInfo;
        private System.Windows.Forms.Timer timer_reg;
        private System.Windows.Forms.Label regOK;
        private System.Windows.Forms.Button btnBackToLogin;
    }
}