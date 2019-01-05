using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Snake
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            reg_Info.Visible = false;
            timer_reg.Start();
        }

        private void btnRegister_OK_Click(object sender, EventArgs e)
        {

            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=user.mdb");
            connection.Open();
           
            
            String name = username.Text;
            String pwd = password.Text;
            String pwd1 = password1.Text;
            if (this.username.Text.Equals("") || this.password.Text.Equals("") || this.username.Text.Equals(" "))
            {
                reg_Info.Visible = true;
                reg_Info.Text = "用户名和密码不能为空！";
                timer_reg.Enabled = false;
                timer_reg.Interval = 1000;
                timer_reg.Enabled = true;
                

            }
            else if (!pwd.Equals(pwd1))
            {
                reg_Info.Visible = true;
                pwdInfo.Text = "两次密码不一致！";
                timer_reg.Enabled = false;
                timer_reg.Interval = 1000;
                timer_reg.Enabled = true;
               
            }
            else
            {
                string sql = "select * from game_user where [username]='" + name + "'";
                OleDbCommand command = new OleDbCommand(sql, connection);
                if (command.ExecuteScalar() != null) {


                    reg_Info.Visible = true;
                    reg_Info.Text = "该昵称已被占用，请换一个";
                    timer_reg.Enabled = false;
                    timer_reg.Interval = 1000;
                    timer_reg.Enabled = true;
                   
                }
                else
                {
                    int initscore = 0;
                    string insertUser = "insert into game_user([username],[password],[highscore])values('" + name + "','" + pwd + "','" + initscore + "')";
                    OleDbCommand insertUserCmd = new OleDbCommand(insertUser, connection);
                    insertUserCmd.ExecuteNonQuery();

                    reg_Info.Visible = true;
                    regOK.Text = "注册成功";
                    timer_reg.Enabled = false;
                    timer_reg.Interval = 1000;
                    timer_reg.Enabled = true;
                   
                }
                connection.Close();

            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login mylogin = new login();
            mylogin.Show();
        }

        private void timer_reg_Tick(object sender, EventArgs e)
        {
            reg_Info.Text = "";
            pwdInfo.Text = "";
            regOK.Text = "";
            timer_reg.Enabled = false;
        }

    
       

 
    }
}
