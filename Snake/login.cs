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
    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();
        }
        public static string username;  //记录登录名
        public static string password;  //记录密码
        private void login_Load(object sender, EventArgs e)
        {
            login_unameInfo.Visible = false;
            login_pwordInfo.Visible = false;
            
            timer1.Start();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=user.mdb");
            connection.Open();

             username = uname.Text;
             password = pword.Text;

            string sql = "select * from game_user where [username]='" + username + "'";
            OleDbCommand oleDbCommand = new OleDbCommand(sql,connection);
            if (oleDbCommand.ExecuteScalar()==null)
            {
                
                login_unameInfo.Visible = true;
                timer1.Enabled = false;
                login_unameInfo.Text = "该用户不存在";
                timer1.Interval = 1000;
                timer1.Enabled = true;


            }
            else
            {
                string sql_pwd = "select password from game_user where [username]='" + username + "'";
                oleDbCommand = new OleDbCommand(sql_pwd, connection);
                if (!oleDbCommand.ExecuteScalar().Equals(password))
                {

                    login_pwordInfo.Visible = true;
                    timer1.Enabled = false;
                    login_pwordInfo.Text = "密码错误！";
                    timer1.Interval = 1000;
                    timer1.Enabled = true;
                    
                    pword.Text = "";
                }
                else
                {
                    this.Hide();
                    Form1 gameForm = new Form1();
                    gameForm.Show();

                }

            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            register myregister = new register();
            myregister.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            login_unameInfo.Text = "";
            login_pwordInfo.Text = "";
            timer1.Enabled = false;
        }

    }
}
