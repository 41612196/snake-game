namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer_game = new System.Windows.Forms.Timer(this.components);
            this.timer_gameover = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.帮助 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pai_ming = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_paiMing = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.yaJun = new System.Windows.Forms.PictureBox();
            this.guanJun = new System.Windows.Forms.PictureBox();
            this.history = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.highscore = new System.Windows.Forms.Label();
            this.count_times = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.btn_chartView = new System.Windows.Forms.Button();
            this.btn_sheetView = new System.Windows.Forms.Button();
            this.dataGridView_history = new System.Windows.Forms.DataGridView();
            this.chart_history = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.game_page = new System.Windows.Forms.TabPage();
            this.gameover = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.playAgain = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_page = new System.Windows.Forms.TabControl();
            this.帮助.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pai_ming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_paiMing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaJun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guanJun)).BeginInit();
            this.history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_history)).BeginInit();
            this.game_page.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.main_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_game
            // 
            this.timer_game.Enabled = true;
            this.timer_game.Interval = 250;
            this.timer_game.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer_gameover
            // 
            this.timer_gameover.Tick += new System.EventHandler(this.timer_gameover_Tick);
            // 
            // 帮助
            // 
            this.帮助.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.帮助.Controls.Add(this.button5);
            this.帮助.Controls.Add(this.pictureBox5);
            this.帮助.Controls.Add(this.pictureBox4);
            this.帮助.Controls.Add(this.label7);
            this.帮助.Controls.Add(this.label6);
            this.帮助.Controls.Add(this.label5);
            this.帮助.Controls.Add(this.label4);
            this.帮助.Controls.Add(this.pictureBox3);
            this.帮助.ForeColor = System.Drawing.Color.Black;
            this.帮助.Location = new System.Drawing.Point(4, 37);
            this.帮助.Name = "帮助";
            this.帮助.Padding = new System.Windows.Forms.Padding(3);
            this.帮助.Size = new System.Drawing.Size(617, 430);
            this.帮助.TabIndex = 5;
            this.帮助.Text = "帮助";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(375, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "详细文档";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Snake.Properties.Resources.地址;
            this.pictureBox5.Location = new System.Drawing.Point(65, 278);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 65);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Snake.Properties.Resources.邮箱;
            this.pictureBox4.Location = new System.Drawing.Point(65, 198);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 66);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "陕西师范大学计算机科学学院";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "1185391863@qq.com";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "【联系我们】";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 126);
            this.label4.TabIndex = 1;
            this.label4.Text = "【游戏操作】用户通过上下左右方向键控住蛇的方向";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Snake.Properties.Resources.方向键;
            this.pictureBox3.Location = new System.Drawing.Point(363, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 82);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pai_ming
            // 
            this.pai_ming.Controls.Add(this.label3);
            this.pai_ming.Controls.Add(this.label2);
            this.pai_ming.Controls.Add(this.label1);
            this.pai_ming.Controls.Add(this.dataGridView_paiMing);
            this.pai_ming.Controls.Add(this.pictureBox2);
            this.pai_ming.Controls.Add(this.yaJun);
            this.pai_ming.Controls.Add(this.guanJun);
            this.pai_ming.Location = new System.Drawing.Point(4, 37);
            this.pai_ming.Name = "pai_ming";
            this.pai_ming.Padding = new System.Windows.Forms.Padding(3);
            this.pai_ming.Size = new System.Drawing.Size(617, 430);
            this.pai_ming.TabIndex = 3;
            this.pai_ming.Text = "玩家排名";
            this.pai_ming.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(529, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(529, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(523, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // dataGridView_paiMing
            // 
            this.dataGridView_paiMing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_paiMing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_paiMing.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_paiMing.Name = "dataGridView_paiMing";
            this.dataGridView_paiMing.RowTemplate.Height = 27;
            this.dataGridView_paiMing.Size = new System.Drawing.Size(467, 440);
            this.dataGridView_paiMing.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Snake.Properties.Resources.季军__1_;
            this.pictureBox2.Location = new System.Drawing.Point(473, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 52);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // yaJun
            // 
            this.yaJun.Image = global::Snake.Properties.Resources.亚军__1_;
            this.yaJun.Location = new System.Drawing.Point(473, 102);
            this.yaJun.Name = "yaJun";
            this.yaJun.Size = new System.Drawing.Size(50, 45);
            this.yaJun.TabIndex = 2;
            this.yaJun.TabStop = false;
            // 
            // guanJun
            // 
            this.guanJun.Image = global::Snake.Properties.Resources.冠军__1_;
            this.guanJun.InitialImage = ((System.Drawing.Image)(resources.GetObject("guanJun.InitialImage")));
            this.guanJun.Location = new System.Drawing.Point(473, 37);
            this.guanJun.Name = "guanJun";
            this.guanJun.Size = new System.Drawing.Size(50, 47);
            this.guanJun.TabIndex = 1;
            this.guanJun.TabStop = false;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.history.Controls.Add(this.button4);
            this.history.Controls.Add(this.highscore);
            this.history.Controls.Add(this.count_times);
            this.history.Controls.Add(this.user);
            this.history.Controls.Add(this.btn_chartView);
            this.history.Controls.Add(this.btn_sheetView);
            this.history.Controls.Add(this.dataGridView_history);
            this.history.Controls.Add(this.chart_history);
            this.history.Location = new System.Drawing.Point(4, 37);
            this.history.Name = "history";
            this.history.Padding = new System.Windows.Forms.Padding(3);
            this.history.Size = new System.Drawing.Size(617, 430);
            this.history.TabIndex = 2;
            this.history.Text = "历史记录";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(488, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highscore.ForeColor = System.Drawing.Color.Black;
            this.highscore.Location = new System.Drawing.Point(484, 90);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(89, 20);
            this.highscore.TabIndex = 5;
            this.highscore.Text = "最高分：";
            // 
            // count_times
            // 
            this.count_times.AutoSize = true;
            this.count_times.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.count_times.ForeColor = System.Drawing.Color.Black;
            this.count_times.Location = new System.Drawing.Point(484, 132);
            this.count_times.Name = "count_times";
            this.count_times.Size = new System.Drawing.Size(109, 20);
            this.count_times.TabIndex = 4;
            this.count_times.Text = "游戏次数：";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user.ForeColor = System.Drawing.Color.Black;
            this.user.Location = new System.Drawing.Point(484, 54);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(110, 23);
            this.user.TabIndex = 3;
            this.user.Text = "昵称：";
            // 
            // btn_chartView
            // 
            this.btn_chartView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_chartView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_chartView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chartView.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_chartView.ForeColor = System.Drawing.Color.Black;
            this.btn_chartView.Location = new System.Drawing.Point(488, 266);
            this.btn_chartView.Name = "btn_chartView";
            this.btn_chartView.Size = new System.Drawing.Size(116, 38);
            this.btn_chartView.TabIndex = 2;
            this.btn_chartView.Text = "记录分析";
            this.btn_chartView.UseVisualStyleBackColor = false;
            this.btn_chartView.Click += new System.EventHandler(this.btn_chartView_Click);
            // 
            // btn_sheetView
            // 
            this.btn_sheetView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_sheetView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sheetView.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sheetView.ForeColor = System.Drawing.Color.Black;
            this.btn_sheetView.Location = new System.Drawing.Point(488, 205);
            this.btn_sheetView.Name = "btn_sheetView";
            this.btn_sheetView.Size = new System.Drawing.Size(116, 36);
            this.btn_sheetView.TabIndex = 1;
            this.btn_sheetView.Text = "表格视图";
            this.btn_sheetView.UseVisualStyleBackColor = false;
            this.btn_sheetView.Click += new System.EventHandler(this.btn_sheetView_Click);
            // 
            // dataGridView_history
            // 
            this.dataGridView_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_history.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_history.Name = "dataGridView_history";
            this.dataGridView_history.RowTemplate.Height = 27;
            this.dataGridView_history.Size = new System.Drawing.Size(478, 435);
            this.dataGridView_history.TabIndex = 0;
            // 
            // chart_history
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_history.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.chart_history.Legends.Add(legend1);
            this.chart_history.Location = new System.Drawing.Point(-4, 0);
            this.chart_history.Name = "chart_history";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "时间";
            this.chart_history.Series.Add(series1);
            this.chart_history.Size = new System.Drawing.Size(482, 440);
            this.chart_history.TabIndex = 6;
            this.chart_history.Text = "historyChart";
            // 
            // game_page
            // 
            this.game_page.Controls.Add(this.gameover);
            this.game_page.Controls.Add(this.groupBox1);
            this.game_page.Controls.Add(this.pictureBox1);
            this.game_page.Location = new System.Drawing.Point(4, 37);
            this.game_page.Name = "game_page";
            this.game_page.Padding = new System.Windows.Forms.Padding(3);
            this.game_page.Size = new System.Drawing.Size(617, 430);
            this.game_page.TabIndex = 0;
            this.game_page.Text = "游戏界面";
            this.game_page.UseVisualStyleBackColor = true;
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.Color.Transparent;
            this.gameover.ForeColor = System.Drawing.Color.Red;
            this.gameover.Location = new System.Drawing.Point(34, 116);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(353, 36);
            this.gameover.TabIndex = 5;
            this.gameover.Text = "是否结束";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox1.Controls.Add(this.playAgain);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.labelSpeed);
            this.groupBox1.Controls.Add(this.labelScore);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(410, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 430);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "玩家：123";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(20, 371);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(161, 40);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playAgain.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playAgain.Location = new System.Drawing.Point(45, 260);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(112, 36);
            this.playAgain.TabIndex = 7;
            this.playAgain.Text = "再来一局";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(45, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSpeed.Location = new System.Drawing.Point(42, 120);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(83, 20);
            this.labelSpeed.TabIndex = 4;
            this.labelSpeed.Text = "速度：1";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScore.Location = new System.Drawing.Point(42, 67);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(83, 20);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "得分：0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(45, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(45, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "暂停";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.BackgroundImage = global::Snake.Properties.Resources.背景;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // main_page
            // 
            this.main_page.Controls.Add(this.game_page);
            this.main_page.Controls.Add(this.history);
            this.main_page.Controls.Add(this.pai_ming);
            this.main_page.Controls.Add(this.帮助);
            this.main_page.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.main_page.Location = new System.Drawing.Point(-5, 0);
            this.main_page.Name = "main_page";
            this.main_page.SelectedIndex = 0;
            this.main_page.Size = new System.Drawing.Size(625, 471);
            this.main_page.TabIndex = 6;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 469);
            this.Controls.Add(this.main_page);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "贪❤的小蛇";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.帮助.ResumeLayout(false);
            this.帮助.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pai_ming.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_paiMing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaJun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guanJun)).EndInit();
            this.history.ResumeLayout(false);
            this.history.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_history)).EndInit();
            this.game_page.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.main_page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_game;
        private System.Windows.Forms.Timer timer_gameover;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage 帮助;
        private System.Windows.Forms.TabPage pai_ming;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox yaJun;
        private System.Windows.Forms.PictureBox guanJun;
        private System.Windows.Forms.DataGridView dataGridView_paiMing;
        private System.Windows.Forms.TabPage history;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Label count_times;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button btn_chartView;
        private System.Windows.Forms.Button btn_sheetView;
        private System.Windows.Forms.DataGridView dataGridView_history;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_history;
        private System.Windows.Forms.TabPage game_page;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl main_page;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button5;
    }
}

