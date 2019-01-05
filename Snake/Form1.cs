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
using System.Windows.Forms.DataVisualization.Charting;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //定义成员变量
        /// <summary>
        /// 键盘状态，初始为start
        /// </summary>
        string Key_Name = "stop";
        /// <summary>
        /// 蛇身数组
        /// </summary>
        Label[] Snake_Boby=new Label[100] ;
        /// <summary>
        /// 随机数,用于生成food
        /// </summary>
        Random R = new Random();
        /// <summary>
        /// 记录位置
        /// </summary>
        int Snake_Boby_content_x = 0, Snake_Boby_content_y = 0;
        /// <summary>
        /// 分数
        /// </summary>
        int score = 0;
        /// <summary>
        /// 速度
        /// </summary>
        int speed = 1;
        /// <summary>
        /// 蛇的状态（是否已死）
        /// </summary>
        bool isalive = false;

        int year, month, day, hour, min, sec;//记录游戏结束时的时间


        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x, y;
            x = Snake_Boby[0].Left;
            y = Snake_Boby[0].Top;
            //获取键盘代码
            Key_Name = e.KeyCode.ToString();
            if (Key_Name == "Right")//向右
            {
                Snake_Boby[0].Left = x + 10;
                Snake_move(x, y);
            }
            if (Key_Name == "Up") //向上
            {
                Snake_Boby[0].Top = y - 10;
                Snake_move(x, y);
            }
            if (Key_Name == "Down")  //向下
            {
                Snake_Boby[0].Top = y + 10;
                Snake_move(x, y);
            }
            if (Key_Name == "Left") //向左
            {
                Snake_Boby[0].Left = x - 10;
                Snake_move(x, y);
            }
            //每按一次，判断是否与食物重合
            Eat_time();

        }
       
        
        public void Eat_time()
        {
            double x1 = 10, y1 = 10, x2 = 10, y2 = 10;
            //遍历Controls中所有label
            foreach (Label lb  in this.pictureBox1.Controls)
            {
                //如果lb为food，将label的位置记录
                if (lb.Tag.ToString() == "food".ToString())
                {
                    x2 = lb.Left;
                    y2 = lb.Top;
                }
                //如果label为snake，将label的位置记录
                if (lb.Tag.ToString() == "0".ToString())
                {
                    x1 = lb.Left;
                    y1 = lb.Top;
                }
            }
            if (x2 == x1 && y2 == y1)
            {
                Snake_eat();
                //将食物移位
                foreach (Label lb in this.pictureBox1.Controls)
                {
                    if (lb.Tag.ToString() == "food".ToString())
                    {
                        lb.Top = R.Next(1, 18) * 20;
                        lb.Left = R.Next(1, 19) * 20;
                        lb.Text = "❤";
                        lb.ForeColor = Color.Red;
                        lb.BackColor = Color.Red;
                    }
                }
            }
        }
        /// <summary>
        /// 蛇触碰到食物的事件
        /// </summary>
        private void Snake_eat()
        {
            int i = 0;
            //遍历到蛇尾
            for (; Snake_Boby[i] != null; i++) ;
            //蛇触碰到food蛇段加一，定义蛇段
            Label Snake_Boby_content = new Label();
            Snake_Boby_content.Width = 10;
            Snake_Boby_content.Height = 10;
            Snake_Boby_content.Top = Snake_Boby_content_y;
            Snake_Boby_content.Left = Snake_Boby_content_x;
            Snake_Boby_content.BackColor = Color.Red;
            Snake_Boby_content.Text = "❤";
            Snake_Boby_content.ForeColor = Color.Red;
            Snake_Boby_content.Tag = i;
            Snake_Boby[i] = Snake_Boby_content;
           
            //this.Controls.Add(Snake_Boby_content);
            this.pictureBox1.Controls.Add(Snake_Boby_content);
            this.score++;
            this.labelScore.Text = "得分：" + this.score.ToString();
            if (speed < 5)
            {
                Snake_changeSpeed(score);
            }
            
        }
        /// <summary>
        /// 判断是否该提高速度
        /// </summary>
        /// <param name="score"></param>
        public void Snake_changeSpeed(int score)
        {
            if (score % 5 == 0)
            {
                this.timer_game.Interval -= 50;
                this.speed++;
                this.labelSpeed.Text = "速度：" + this.speed.ToString();
            }
        }

        public void Snake_food()
        {

            Label Food = new Label();
            Food.Width = 10;
            Food.Height = 10;
            //生成一个随机位置的food
            Food.Top = R.Next(1, 18) * 20;
            Food.Left = R.Next(1, 19) * 20;
            Food.Text = "❤";
            Food.Tag = "food";
            Food.BackColor = Color.Red;
            Food.ForeColor = Color.Red;
            this.pictureBox1.Controls.Add(Food);
            
        }
        /// <summary>
        /// 蛇身移动事件
        /// </summary>
        ///<param name="x">
        ///<param name="y">
        public void Snake_move(int x, int y)
        {
            //记录xy的中间变量
            int temp_x = 0, temp_y = 0;

            //遍历蛇身进行移动
            for (int i = 1; Snake_Boby[i] != null; i++)
            {
                if (i >= 3)
                {
                    //将记录的前一个蛇段位置赋给中间变量
                    temp_x = Snake_Boby_content_x;
                    temp_y = Snake_Boby_content_y;
                }
                if (i == 1)
                {
                    //将记录蛇头的改变前的位置的x y赋给第一个蛇段，并记录蛇段的位置
                    temp_x = Snake_Boby[i].Left;
                    temp_y = Snake_Boby[i].Top;
                    Snake_Boby[i].Left = x;
                    Snake_Boby[i].Top = y;
                }
                else
                {
                    //将记录前一个个蛇段的改变前的位置temp_赋给第二个蛇段,并记录改前位置
                    Snake_Boby_content_x = Snake_Boby[i].Left;
                    Snake_Boby_content_y = Snake_Boby[i].Top;
                    Snake_Boby[i].Left = temp_x;
                    Snake_Boby[i].Top = temp_y;
                }
            }
        }
        /// <summary>
        /// snake的自动移动事件
        /// </summary>
        ///<param name="sender">
        ///<param name="e">
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //用来记录snake的head的xy坐标
            if (isalive)
            {
                int x, y;
                x = Snake_Boby[0].Left;
                y = Snake_Boby[0].Top;
                if (Key_Name == "start")  //键盘状态处于初始状态
                {
                    Snake_Boby[0].Left = x + 10;//Snake_Boby[0]右移10
                    Snake_move(x, y);//调用
                }
                if (Key_Name == "Right")//键盘状态处于  向右 状态
                {
                    Snake_Boby[0].Left = x + 10;
                    Snake_move(x, y);
                }
                if (Key_Name == "Up")  //键盘状态处于  向上  状态
                {
                    Snake_Boby[0].Top = y - 10;
                    Snake_move(x, y);
                }
                if (Key_Name == "Down")//键盘状态处于  向下  状态
                {
                    Snake_Boby[0].Top = y + 10;
                    Snake_move(x, y);
                }
                if (Key_Name == "Left") //键盘状态处于向左 状态
                {
                    Snake_Boby[0].Left = x - 10;
                    Snake_move(x, y);
                }
                //  穿墙设置
                /*if (x > pictureBox1.Location.X+pictureBox1.Width-10)
                {
                    Snake_Boby[0].Left = pictureBox1.Location.X; 
                }
                if (x < pictureBox1.Location.X)
                {
                    Snake_Boby[0].Left = pictureBox1.Location.X+pictureBox1.Width-10;
                }
                if (y > pictureBox1.Location.Y+pictureBox1.Height-10)
                {
                    Snake_Boby[0].Top = pictureBox1.Location.Y;
                }
                if (y < pictureBox1.Location.Y)
                {
                    Snake_Boby[0].Top = pictureBox1.Location.Y+pictureBox1.Height-10;
                }*/
                //每动一次，判断是否与食物重合
                Eat_time();
                Snake_dead(x, y);
            }
            

        }

        
        public void  Snake_dead(int x,int y)
        {
            if (x<pictureBox1.Location.X||x>pictureBox1.Location.X+pictureBox1.Width-20||y<pictureBox1.Location.Y||y>pictureBox1.Location.Y+pictureBox1.Height-20)
            {
                this.playAgain.Enabled = true;
                this.button2.Enabled = false;
                gameover.Visible = true;
                gameover.Text = "呜呜呜，游戏结束，得分："+score;
                timer_gameover.Enabled = false;
                timer_gameover.Interval = 2000;
                timer_gameover.Enabled = true;
                timer_game.Enabled = false;
                isalive = false;
                Array.Clear(Snake_Boby, 5, 5+score);
                Key_Name = "stop";
                //获取游戏结束时的时间
                System.DateTime currentTime = new System.DateTime();
                currentTime = System.DateTime.Now;
                year = currentTime.Year;
                month = currentTime.Month;
                day = currentTime.Day;
                hour = currentTime.Hour;
                min = currentTime.Minute;
                sec = currentTime.Second;
                string gameover_time = year + "年" + month + "月" + day + "日 " + hour + "时" + min + "分" + sec + "秒";


                //上传数据（玩家账号，本次游戏分数，游戏结束时间）
                string username = login.username;//获取游戏玩家的ID
                
                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=user.mdb");
                connection.Open();

                string insertScore = "insert into score_record ([username],[playtime],[score])values('"+username+"','"+gameover_time+"','"+score+"')";
                OleDbCommand insertScoreCommend = new OleDbCommand(insertScore, connection);
                insertScoreCommend.ExecuteNonQuery();

                //判断该分数是否刷新本人分数，若刷新，则更新本人最高分数
                int highscore;
                string gethighscore = "select highscore from game_user where [username]='" + username + "'";
                OleDbCommand getHighScoreCmd = new OleDbCommand(gethighscore, connection);
                OleDbDataReader oleDbDataReaderHighScore = getHighScoreCmd.ExecuteReader();
                oleDbDataReaderHighScore.Read();
                highscore = int.Parse(oleDbDataReaderHighScore["highscore"].ToString());
      
                if (highscore < score)
                {
                    string updateHighScore = "update game_user set [highscore]='" + score + "'where [username]='"+username+"'";
                    OleDbCommand updateHighScoreCmd = new OleDbCommand(updateHighScore, connection);
                    updateHighScoreCmd.ExecuteNonQuery();
                }




            }

        }

        private void btn_sheetView_Click(object sender, EventArgs e)
        {
            this.dataGridView_history.Visible = true;
            this.chart_history.Visible = false;
            this.button4.Visible = true;
        }

        private void btn_chartView_Click(object sender, EventArgs e)
        {
            this.dataGridView_history.Visible= false;
            this.chart_history.Visible = true;
            this.button4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=user.mdb");
            connection.Open();
            string selectRecord = this.dataGridView_history.SelectedCells[0].Value.ToString();
            string deleteRecord = "delete from score_record where [username]='" + login.username + "'and [playtime]='" + selectRecord + "'";
            OleDbCommand deleteRecordCmd = new OleDbCommand(deleteRecord, connection);
            deleteRecordCmd.ExecuteNonQuery();
            dataGridView_history.Rows.Remove(dataGridView_history.CurrentRow);

            //更新折线图
            string select_history = "select playtime as 游戏时间,score as 分数 from score_record where [username]='" + login.username + "'";
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(select_history, connection);
            DataSet history_dataSet = new DataSet();
            oleDbDataAdapter.Fill(history_dataSet, "score_record");
            dataGridView_history.DataSource = history_dataSet.Tables["score_record"];
            DataView dataView = new DataView(history_dataSet.Tables[0]);
            chart_history.Series["时间"].Points.DataBindXY(dataView, "游戏时间", dataView, "分数");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "SnakeGame.chm";
            process.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化历史记录表中的数据
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=user.mdb");
            connection.Open();
            string select_history = "select playtime as 游戏时间,score as 分数 from score_record where [username]='"+login.username+"'";
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(select_history, connection);
            DataSet history_dataSet = new DataSet();
            oleDbDataAdapter.Fill(history_dataSet, "score_record");
            dataGridView_history.DataSource = history_dataSet.Tables["score_record"];
            
            

            //初始化历史记录中其他信息
            //玩家昵称显示
            this.user.Text = "昵称：" + login.username;
            //玩家历史最高分
            int highscore;
            
            string gethighscore = "select highscore from game_user where [username]='" + login.username + "'";
            OleDbCommand getHighScoreCmd = new OleDbCommand(gethighscore, connection);
            OleDbDataReader oleDbDataReaderHighScore = getHighScoreCmd.ExecuteReader();
            oleDbDataReaderHighScore.Read();
            highscore = int.Parse(oleDbDataReaderHighScore["highscore"].ToString());
            this.highscore.Text = "最高分：" + highscore;
           


            //获得玩家总的游戏次数
            
            string getGameTimes = "select count(*) as cou from score_record where [username]='" + login.username + "'";
            OleDbCommand getGameTimesCmd = new OleDbCommand(getGameTimes, connection);
            OleDbDataReader oleDbDataReaderGameTimes = getGameTimesCmd.ExecuteReader();
            oleDbDataReaderGameTimes.Read();
            int counts = int.Parse(oleDbDataReaderGameTimes["cou"].ToString());
            this.count_times.Text = "游戏次数：" + counts;

            //初始化玩家排名
            string pai_ming = "select username as 昵称,highscore as 最高分 from game_user order by highscore desc";
            OleDbDataAdapter oleDbDataAdapter_paiMing = new OleDbDataAdapter(pai_ming, connection);
            DataSet paiMing_dataSet = new DataSet();
            oleDbDataAdapter_paiMing.Fill(paiMing_dataSet, "game_user");
            dataGridView_paiMing.DataSource = paiMing_dataSet.Tables["game_user"];
            this.label1.Text =(String)paiMing_dataSet.Tables[0].Rows[0]["昵称"];
            this.label2.Text = (String)paiMing_dataSet.Tables[0].Rows[1]["昵称"];
            this.label3.Text = (String)paiMing_dataSet.Tables[0].Rows[2]["昵称"];


            //初始化玩家游戏分数走势
            //设置网格的颜色
            chart_history.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart_history.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.LightGray;
            //设置坐标轴的名称
            chart_history.ChartAreas["ChartArea1"].AxisX.Title = "时间";
            chart_history.ChartAreas["ChartArea1"].AxisY.Title = "分数";

            chart_history.Series["时间"].ChartType = SeriesChartType.Line;
            chart_history.Series["时间"].XValueType = ChartValueType.String;
            chart_history.Series["时间"].IsValueShownAsLabel = true;

            chart_history.Series["时间"].MarkerStyle = MarkerStyle.Cross;
            chart_history.Series["时间"].Color = Color.Green;
            chart_history.Series["时间"].BorderWidth = 3;


            DataView dataView = new DataView(history_dataSet.Tables[0]);
            chart_history.Series["时间"].Points.DataBindXY(dataView,"游戏时间",dataView,"分数");
            
            this.chart_history.Visible = false;
            this.button2.Enabled = false;
            
            


            this.Top = 100;
            this.Left = 300;

            this.groupBox1.Text = "玩家："+login.username;
          
            gameover.Visible = false;
            this.BackColor = Color.White;
            //初始化一个label蛇体，长度为5个label，一个label height= width = 10
            for (int i = 0; i < 5; i++)
            {
                //蛇段
                Label Snake_Boby_content = new Label();
                Snake_Boby_content.Height = 10;
                Snake_Boby_content.Width = 10;
                //蛇段的位置
                Snake_Boby_content.Top = 200;
                Snake_Boby_content.Left = 200 - i * 10;
                //背景色
                //this.BackColor = Color.White;        //游戏背景颜色
                //this.pictureBox1.BackColor = Color.;
                Snake_Boby_content.BackColor = Color.White;
                Snake_Boby_content.Text = "0❤";
                Snake_Boby_content.ForeColor = Color.Black;
                //获取或设置包含有关控件的数据的对象。
                Snake_Boby_content.Tag = i;
                //加入蛇体
                Snake_Boby[i] = Snake_Boby_content;
                this.pictureBox1.Controls.Add(Snake_Boby_content);
                //this.panControls.Add(Snake_Boby_content);
            }
            //每隔一段时间发生一次右移
           // timer_game.Tick += new EventHandler(timer1_Tick_1);
            //按键时发生的事件监控
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            Snake_food();       //food 生成
            timer_game.Start(); //Timer 开始计时
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("暂停"))
            {
                //Key_Name = "stop";
                timer_game.Enabled = false;
                
                
                button2.Text = "继续";
            }else if (button2.Text.Equals("继续"))
            {
                //Key_Name = "start";
                timer_game.Enabled = true;
                button2.Text = "暂停";
                this.pictureBox1.Focus();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            this.Hide();
            login mylogin = new login();
            mylogin.Show();
        }

        private void timer_gameover_Tick(object sender, EventArgs e)
        {
            gameover.Visible = false;
            gameover.Enabled = false;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Key_Name = "start";
            isalive = true;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.pictureBox1.Focus();
        }

        
    



        

        

        

    }
}
