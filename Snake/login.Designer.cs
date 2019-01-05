namespace Snake
{
    partial class login
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
            this.uname = new System.Windows.Forms.TextBox();
            this.pword = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.title_game = new System.Windows.Forms.Label();
            this.login_unameInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.login_pwordInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(225, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "昵称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(225, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // uname
            // 
            this.uname.BackColor = System.Drawing.Color.Linen;
            this.uname.Location = new System.Drawing.Point(291, 170);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(158, 25);
            this.uname.TabIndex = 2;
            // 
            // pword
            // 
            this.pword.BackColor = System.Drawing.SystemColors.Info;
            this.pword.Location = new System.Drawing.Point(291, 247);
            this.pword.Name = "pword";
            this.pword.PasswordChar = '*';
            this.pword.Size = new System.Drawing.Size(158, 25);
            this.pword.TabIndex = 3;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_login.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_login.Location = new System.Drawing.Point(265, 352);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(102, 48);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_register.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_register.Location = new System.Drawing.Point(373, 352);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(102, 48);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "注册";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // title_game
            // 
            this.title_game.BackColor = System.Drawing.Color.Transparent;
            this.title_game.Font = new System.Drawing.Font("幼圆", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_game.ForeColor = System.Drawing.Color.Crimson;
            this.title_game.Location = new System.Drawing.Point(193, 24);
            this.title_game.Name = "title_game";
            this.title_game.Size = new System.Drawing.Size(335, 63);
            this.title_game.TabIndex = 6;
            this.title_game.Text = "贪❤的小蛇";
            // 
            // login_unameInfo
            // 
            this.login_unameInfo.BackColor = System.Drawing.Color.Transparent;
            this.login_unameInfo.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_unameInfo.ForeColor = System.Drawing.Color.Red;
            this.login_unameInfo.Location = new System.Drawing.Point(474, 174);
            this.login_unameInfo.Name = "login_unameInfo";
            this.login_unameInfo.Size = new System.Drawing.Size(166, 22);
            this.login_unameInfo.TabIndex = 7;
            this.login_unameInfo.Text = "login_unameInfo";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // login_pwordInfo
            // 
            this.login_pwordInfo.BackColor = System.Drawing.Color.Transparent;
            this.login_pwordInfo.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_pwordInfo.ForeColor = System.Drawing.Color.Red;
            this.login_pwordInfo.Location = new System.Drawing.Point(474, 250);
            this.login_pwordInfo.Name = "login_pwordInfo";
            this.login_pwordInfo.Size = new System.Drawing.Size(166, 22);
            this.login_pwordInfo.TabIndex = 8;
            this.login_pwordInfo.Text = "login_pwordInfo";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::Snake.Properties.Resources._4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 476);
            this.Controls.Add(this.login_pwordInfo);
            this.Controls.Add(this.login_unameInfo);
            this.Controls.Add(this.title_game);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.pword);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pword;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label title_game;
        private System.Windows.Forms.Label login_unameInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label login_pwordInfo;
    }
}