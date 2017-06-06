using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;

/**********************************************************************
/**Description:	Đề tài Memory Game                                    *
**********************************************************************/

namespace Memory_Game
{
    public partial class FrmMemory : Form
    {        
        public FrmMemory()
        {            
            bg.Play();
            InitializeComponent();             
            timer2.Start();
            mnuReplay.Enabled = false;
            mnuSaveCurrent.Enabled = false;
            btnPause.Enabled = false;
            lblHScore.Text = "0";
            lblYScore.Text = "0";
            btnPause.Enabled = false;
            btnStart.Enabled = false;
            label2.Visible = false;
            progressBar2.Visible = false;
            groupBox1.Visible = false;
            readFile();
        }

        Button[] b;
        Random r = new Random();
        int n = 2;
        int flag = 0;
        private bool playing = true;
        SoundPlayer bg = new SoundPlayer("BG.wav");
        //Phát sinh các button động với số lượng theo các mức độ do người chơi chọn
        public void Step()
        {     
            b = new Button[n * n];
            int k = 0, j = 1;
            label4.Visible = false;
            lblYourtime.Visible = false;
            if (n == 2) BackgroundImage = Image.FromFile("BG_1.png");
            else
            {
                if (n==4) BackgroundImage = Image.FromFile("BG_2.png");
                else
                {
                    if (n == 6) BackgroundImage = Image.FromFile("BG_3.png");
                    else
                    {
                        if (n == 8) BackgroundImage = Image.FromFile("BG_4.png");
                        else if (n == 10) BackgroundImage = Image.FromFile("BG_5.png");
                    }
                }
            }
            for (int i = 0; i < n * n; i++)
            {
                b[i] = new Button();
                b[i].Size = new Size(400 / n, 280 / n);
                b[i].Image = Image.FromFile("Default.jpg");
                var bm = new Bitmap(b[i].Image, new Size(400 / n, 280 / n));
                b[i].Image = bm;                
                b[i].Location = new Point(115 + k * 400 / n, n * 15 + j * 280 / n);
                b[i].Enabled = false;
                b[i].Click += new EventHandler(b_Click);
                this.Controls.Add(b[i]);
                k++;
                if (k == n)
                {
                    k = 0; j++;
                }
            }

        }
        public void Time()
        {
            b = new Button[n * n];
            int k = 0, j = 1;
            label5.Visible = false;
            lblClicks.Visible = false;
            progressBar2.Visible = true;
            if (n == 2) BackgroundImage = Image.FromFile("BG_1.png");
            else
            {
                if (n == 4) BackgroundImage = Image.FromFile("BG_2.png");
                else
                {
                    if (n == 6) BackgroundImage = Image.FromFile("BG_3.png");
                    else
                    {
                        if (n == 8) BackgroundImage = Image.FromFile("BG_4.png");
                        else if (n == 10) BackgroundImage = Image.FromFile("BG_5.png");
                    }
                }
            }
            for (int i = 0; i < n * n; i++)
            {
                b[i] = new Button();
                b[i].Size = new Size(400 / n, 280 / n);
                b[i].Image = Image.FromFile("Default.jpg");
                var bm = new Bitmap(b[i].Image, new Size(400 / n, 280 / n));
                b[i].Image = bm;
                b[i].Location = new Point(115 + k * 400 / n, n * 15 + j * 280 / n);
                b[i].Enabled = false;
                b[i].Click += new EventHandler(b_Click);
                this.Controls.Add(b[i]);
                k++;
                if (k == n)
                {
                    k = 0; j++;
                }
            }
        }
        public void Normal()
        {
            b = new Button[n * n];
            int k = 0, j = 1;
            label5.Visible = false;
            lblClicks.Visible = false;
            progressBar2.Visible = false;
            if (n == 2) BackgroundImage = Image.FromFile("BG_1.png");
            else
            {
                if (n == 4) BackgroundImage = Image.FromFile("BG_2.png");
                else
                {
                    if (n == 6) BackgroundImage = Image.FromFile("BG_3.png");
                    else
                    {
                        if (n == 8) BackgroundImage = Image.FromFile("BG_4.png");
                        else if (n == 10) BackgroundImage = Image.FromFile("BG_5.png");
                    }
                }
            }
            for (int i = 0; i < n * n; i++)
            {
                b[i] = new Button();
                b[i].Size = new Size(400 / n, 280 / n);
                b[i].Image = Image.FromFile("Default.jpg");
                var bm = new Bitmap(b[i].Image, new Size(400 / n, 280 / n));
                b[i].Image = bm;
                b[i].Location = new Point(115 + k * 400 / n, n * 15 + j * 280 / n);
                b[i].Enabled = false;
                b[i].Click += new EventHandler(b_Click);
                this.Controls.Add(b[i]);
                k++;
                if (k == n)
                {
                    k = 0; j++;
                }
            }
        }

        public void random()
        {
            //Nửa mảng button cho random các giá trị từ 0 đến 9
            ArrayList list = new ArrayList();
            for (int i = 0; i < b.Length / 2; i++)
            {
                int j = r.Next(0, 12);
                b[i].Tag = j;
                list.Add(j);//Lưu các giá trị đã random vào trong list.
            }
            for (int i = b.Length / 2; i < b.Length; i++)
            {
                int x = r.Next(0, list.Count - 1); // Lấy ngẫu nhiên 1 index trong list.
                b[i].Tag = list[x];//random phần tử có index x trong list.
                list.RemoveAt(x);//Xóa phần tử đã được random trong list.
            }
            int lucky = r.Next(0, b.Length / 2);
            for (int i = 0; i < b.Length / 2; i++)
            {
                if (i == lucky) b[i].Name = "Lucky";
            }
        }
        int tmp = 0;//Lưu giá trị số lần Clicks 
        int max = 2;
        int t = 2;
        public void b_Click(object sender, EventArgs e)
        {
            if (lblYourtime.Visible == false)
            {
                max -= 1;
            }
            Button k = (Button)sender;
            k.Image = Image.FromFile(k.Tag.ToString() + ".jpg");
            var bm = new Bitmap(k.Image, new Size(400 / n, 280 / n));
            k.Image = bm;
            tmp++;//Sau mỗi lần nhấn chuột tmp tăng lên 1 để tính số lần Clicks                
            lblClicks.Text = max.ToString();
            k.Enabled = false;
            Checkpair();
            CheckLength();
        }
        int dem = 0;
        int Score = 0;
        //Kiểm tra sự giống nhau của 2 cặp hình ảnh
        public void Checkpair()
        {

            for (int i = 0; i < b.Length - 1; i++)
            {
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[i].Enabled == false && b[j].Enabled == false)
                    {
                        //Nếu 2 button đều đã mở thì kiểm tra tiếp xem tag của 2 button có bằng nhau không, nếu bằng nhau thì xóa button.
                        if (b[i].Tag.ToString() == b[j].Tag.ToString())
                        {
                            if (playing)
                            {
                                var correct = new WMPLib.WindowsMediaPlayer();
                                correct.URL = @"tada.wav";
                            }
                            System.Threading.Thread.Sleep(500);
                            b[i].Enabled = true;
                            b[j].Enabled = true;
                            System.Threading.Thread.Sleep(500);
                            b[i].Visible = false;
                            b[j].Visible = false;
                            if (b[i].Name == "Lucky")
                            {
                                if (lblYourtime.Visible == false) max += 2;
                                if (label2.Visible == true) t += 5;
                                    for (int k = 0; k < b.Length; k++)
                                    {
                                        b[k].Image = Image.FromFile(b[k].Tag.ToString() + ".jpg");
                                        var bm = new Bitmap(b[k].Image, new Size(400 / n, 280 / n));
                                        b[k].Image = bm;
                                        b[k].Enabled = false;
                                    }
                                System.Threading.Thread.Sleep(2000);
                                for (int k = 0; k < b.Length; k++)
                                {
                                    b[k].Enabled = true;
                                    b[k].Image = Image.FromFile("Default.jpg");
                                    var bm = new Bitmap(b[k].Image, new Size(400 / n, 280 / n));
                                    b[k].Image = bm;
                                }
                            }
                            if (lblYourtime.Visible == true)
                            {
                                Score = Score + 10;
                            }
                            lblYScore.Text = Score.ToString();
                            dem++;
                        }
                        else
                        {
                            if (playing)
                            {
                                var wrong = new WMPLib.WindowsMediaPlayer();
                                wrong.URL = @"chimes.wav";
                            }
                            if (max <= 0)
                            {
                                timer1.Stop();
                                if (playing)
                                {
                                    var lose = new WMPLib.WindowsMediaPlayer();
                                    lose.URL = @"lose.wav";
                                }
                                dem = 0;
                                btnPause.Enabled = false;
                                DialogResult result = MessageBox.Show("Click hết số lần cho phép mà vẫn thua, gà quá, có muốn thử lại không?", "Sợ gì, chơi luôn!", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    Replay();
                                }
                                else
                                    for (int a = 0; a < b.Length; a++)
                                    {
                                        b[a].Visible = false;
                                    }
                            }
                            System.Threading.Thread.Sleep(500);
                            b[i].Enabled = true;
                            b[j].Enabled = true;
                            if (Score > 0)
                            {
                                if (lblYourtime.Visible == false)
                                    Score = Score - 15;
                                else Score = Score - 5;
                                if (Score < 0) Score = 0;
                            }
                            lblYScore.Text = Score.ToString();
                            b[i].Image = Image.FromFile("Default.jpg");
                            var bi = new Bitmap(b[i].Image, new Size(400 / n, 280 / n));
                            b[i].Image = bi;
                            b[j].Image = Image.FromFile("Default.jpg");
                            var bj = new Bitmap(b[j].Image, new Size(400 / n, 280 / n));
                            b[j].Image = bj;
                        }
                    }
                }

            }

        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //Thông tin về game
            MessageBox.Show("Đây là Trò chơi Memory được viết theo đề tài môn Lập trình trực quan."
            + "\nGiảng viên hướng dẫn: Huỳnh Tuấn Anh.\nĐề tài : Thực hiện project Memory game.\nNhóm thực hiện:\n1. Phan Văn Tùng - 13521007\n"
             + "2. Trần Văn Thiệt - 13520826\n"
             + "3. Nguyễn Hoài Phú - 14520683\n"
             + "4. Bùi Xuân Bông - 13520060\n"
            + "Trường Đại học Công nghệ thông tin - ĐHQG TP.HCM.\n10-05-2017");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thực sự muốn thoát trò chơi này?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);            
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void mnuInstructions_Click(object sender, EventArgs e)
        {
            //Hướng dẫn chơi game
            MessageBox.Show("                               Hướng dẫn chơi game\n"

        + "   Để bắt đầu trò chơi hãy nhấn nút Bắt đầu, nhấn Tạm dừng nếu muốn dừng trò chơi trong 1 khoảng thời gian \n"
        + "Nhấn vào mỗi ô hình sẽ xuất hiện một hình ảnh và hãy nhớ hình ảnh này\n"
        + "   Lật tiếp hình thứ 2 nếu hình ảnh trong hình này giống hình ảnh của hình mở lần 1 thì 2 hình sẽ biến mất "
        + "ngược lại thì 2 hình này sẽ ẩn giá trị hình ảnh.\n"
        + "   Hãy thực hiện liên tục cho đến khi không còn hình nào.\n"
        + "   Nếu may mắn lật được cặp hình Lucky sẽ có thể xem toàn bộ các hình trong vòng 2 giây và được cộng thời gian/số clicks tương ứng.\n"
        + "   Để lựa chọn nhanh bạn có thể dùng các phím tắt sau:\n"
        + "- Thoát : Ctrl+F4\n- Cơ bản : F2\n- Giới hạn thời gian : F3\n- Giới hạn số click : F4\n- Chơi lại : F12\n"
        + "- Lưu trạng thái đang chơi : Ctrl+S\n- Mở lại lần chơi gần đây : Ctrl+L\n- Hướng dẫn : F1\n- Thông tin : Ctrl + F12", "Hướng dẫn",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int ans = 0;

        private void mnuNormal_Click(object sender, EventArgs e)
        {
            Sound.Visible = true;
            if (playing) bg.Play();
            CurTime = new DateTime(2017, 7, 6, 0, 0, 0, 0);
            lblYourtime.Text = "";
            if (CurTime.Minute > 0)
                lblYourtime.Text = CurTime.Minute.ToString() + " phút " + CurTime.Second.ToString() + " giây";
            else lblYourtime.Text = CurTime.Second.ToString() + " giây";
            Normal();
            tmp = 0;
            lblClicks.Text = tmp.ToString();
            mnuStep.Enabled = false;
            mnuTime.Enabled = false;
            mnuNormal.Enabled = false;
            mnuReplay.Enabled = true;
            groupBox2.Visible = false;
            btnStart.Enabled = true;
            label2.Visible = false;
            progressBar2.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            if (ans == 0)
            {
                InputName();
            }
            ans = 1;
        }
        private void mnuTime_Click(object sender, EventArgs e)
        {
            Sound.Visible = true;
            if (playing) bg.Play();
            for (int i = 0; i < n; i++)
            {
                t *= 2;
            }
            CurTime = new DateTime(2017, 7, 6, 0, t / 60, t % 60, 0);
            if (CurTime.Minute > 0)
                lblYourtime.Text = CurTime.Minute.ToString() + " phút " + CurTime.Second.ToString() + " giây";
            else lblYourtime.Text = CurTime.Second.ToString() + " giây";
            Time();
            tmp = 0;
            lblClicks.Text = tmp.ToString();
            mnuStep.Enabled = false;
            mnuNormal.Enabled = false;
            mnuTime.Enabled = false;
            mnuReplay.Enabled = true;
            groupBox2.Visible = false;
            btnStart.Enabled = true;
            label2.Visible = true;
            progressBar2.Visible = true;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            if (ans == 0)
            {
                InputName();
            }
            ans = 1;
        }
        
        private void mnuStep_Click(object sender, EventArgs e)
        {
            Sound.Visible = true;
            if (playing) bg.Play();
            Step();
            for (int i = 0; i < n; i++)
            {
                max *= 2;
            }
            lblClicks.Text = max.ToString();
            Score = 5*max/2;
            lblYScore.Text = Score.ToString();
            mnuNormal.Enabled = false;
            mnuTime.Enabled = false;
            mnuStep.Enabled = false;
            mnuReplay.Enabled = true;
            groupBox2.Visible = false;
            btnStart.Enabled = true;
            label2.Visible = false;
            progressBar2.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            if (ans == 0)
            {
                InputName();
            }
            ans = 1;
        }
        //Chơi lại 
        public void Replay()
        {           
            if (playing) bg.Play();
            timer1.Stop();
            // timer2.Stop();
            progressBar2.Maximum = 0;
            btnStart.Enabled = true;
            for (int i = 0; i < b.Length; i++)
            {
                b[i].Visible = false;//Xóa tất cả các button đã được tạo ra
            }
            mnuNormal.Enabled = true;
            mnuTime.Enabled = true;
            mnuStep.Enabled = true;
            mnuReplay.Enabled = false;
            btnPause.BackColor = Color.Blue;
            readFile();
            if (dem != b.Length / 2) Score = 0;
            dem = 0;
            max = 2;
            t = 2;
            lblClicks.Text = max.ToString();
            lblYScore.Text = Score.ToString();
            lblYourtime.Text = "";
            if (lblClicks.Visible == false)
            {
                if (label2.Visible == false)
                    mnuNormal.PerformClick();
                else mnuTime.PerformClick();
            }
            else mnuStep.PerformClick();
            btnPause.Enabled = false;
            tmp = 0;
        }
        private void mnuReplay_Click(object sender, EventArgs e)
        {
            //Hỏi người chơi có chắc chắn muốn chơi lại không.
            MessageBox.Show("Bạn chắc chắn muốn chơi lại màn này chứ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            Replay();
            flag = 1;
        }
                     

        //Button Start đề kích hoạt form
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i < b.Length; i++)
            {
                b[i].Enabled = true;
            }
            random();

            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnPause.BackColor = Color.LightPink;
            mnuSaveCurrent.Enabled = true;
        }
        //Button tạm dừng trò chơi
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "Tạm &dừng")
            {
                timer1.Stop();

                btnPause.Text = "&Tiếp tục";
                for (int i = 0; i < b.Length; i++)
                {
                    b[i].Image = Image.FromFile("Default.jpg");
                    var bm = new Bitmap(b[i].Image, new Size(400 / n, 280 / n));
                    b[i].Image = bm;
                    b[i].Enabled = false;
                }
            }
            else
            {
                timer1.Start();
                btnPause.Text = "Tạm &dừng";
                for (int i = 0; i < b.Length; i++)
                {
                    b[i].Enabled = true;
                }
            }
        }
        private DateTime CurTime;
        public int i = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Minimum = 0;
            progressBar2.Maximum = t - 1;
            progressBar2.Step = 1;
            progressBar2.PerformStep();
            //Thời gian đếm ngược
            TimeSpan dt = new TimeSpan(0, 0, 0, 1, 0);
            if (label2.Visible == true) CurTime = CurTime.Subtract(dt);
            else CurTime = CurTime.Add(dt);
            if (CurTime.Minute >= 0)
                lblYourtime.Text = CurTime.Minute.ToString() + " phút " + CurTime.Second.ToString() + " giây";
            else lblYourtime.Text = CurTime.Second.ToString() + " giây";
            if (CurTime.Minute == 0 && CurTime.Second == 0)//Hết thời gian thì thông báo thua cuộc
            {
                timer1.Enabled = false;
                MessageBox.Show("Hết thời gian!\nRất tiếc bạn đã thua, hãy cố gắng ở lần sau nhé.", "Thua rồi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Replay();//Chơi lại
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //Tạo dòng chữ chạy qua lại
            lblTen.Left += i;
            if (lblTen.Left >= this.Width - lblTen.Width || lblTen.Left <= 0)
            {
                i = -i;
                lblTen.ForeColor = Color.Red;
            }
        }

        int[] intHighScores = new int[3];
        string[] strUser = new string[3];
        string[] strName = new string[3];
        public void InputName()
        {
            if (flag != 1)
            {
                //Hiển thị form để người dùng nhập tên
                strName[0] = Interaction.InputBox("Chào mừng bạn đã tham gia trò chơi!", "Nhập tên", "Bạn chưa nhập tên!", 400, 300);

                while (strName[0].Length > 20)
                {
                    MessageBox.Show("Chỉ được phép nhập dưới 20 kí tự !", "Chú ý",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    strName[0] = Interaction.InputBox("Tên của bạn dài quá, nhập lại đi!\nÍt hơn 20 kí tự nhé!!", "Nhập tên", "Hãy nhập tên!", 400, 300);

                }
                StreamWriter NameStreamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"/Data/Name.txt", false);

                for (int c = 0; c < 3; c++)
                {
                    NameStreamWriter.WriteLine(strName[c]);
                }
                NameStreamWriter.Close();
            }
            try
            {
                //Đọc file lưu tên người chơi lên label Name
                StreamReader NameStreamReader = new StreamReader(Directory.GetCurrentDirectory() + @"/Data/Name.txt");
                while (NameStreamReader.Peek() != -1)
                {
                    for (int a = 0; a < 3; a++)
                        strName[a] = NameStreamReader.ReadLine();
                }
                NameStreamReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi khi đọc tên của người chơi!");
            }
            lblName.Text = strName[0];
        }
        public void CheckLength()
        {
            if (dem == b.Length / 2)
            {
                timer1.Stop();
                if (playing)
                {
                    var win = new WMPLib.WindowsMediaPlayer();
                    win.URL = @"win.wav";
                }
                dem = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Trò chơi đã kết thúc! Bạn đã làm rất tốt!\nĐiểm của bạn : " + lblYScore.Text + "\nSố lần Click : " + tmp.ToString() + "\nThời gian chơi: " + progressBar2.Value.ToString(), "Chúc mừng");
                if (n <= 10)
                {
                    DialogResult result = MessageBox.Show("Bạn đã thắng màn này, có muốn chơi khó hơn không?", "WIN", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        n += 2;
                        Replay();
                    }
                    else
                    {
                        if (Score > intHighScores[0])
                        {
                            intHighScores[0] = Score;
                            //Hiển thị form để người dùng nhập tên
                            strUser[0] = Interaction.InputBox("Chúc mừng " + lblName.Text + " đã có số điểm cao nhất tính đến thời điểm hiện tại!"
                            + "\nHãy nhập tên bạn muốn công khai với mọi người", "Điểm cao", "Hãy nhập tên để mọi người biết!", 400, 300);
                            while (strUser[0].Length > 7)
                            {
                                MessageBox.Show("Chỉ được phép nhập dưới 7 kí tự!\nTên này là tên ngắn gọn của bạn hoặc biệt danh!", "Chú ý",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                strUser[0] = Interaction.InputBox("Tên của bạn dài quá, nhập lại đi!\nÍt hơn 7 kí tự nhé!", "Điểm cao", "Hãy nhập tên để mọi người biết!", 400, 300);
                            }
                        }
                        //ghi điểm cao vào file highscore trong thư mục bin
                        StreamWriter HighScoreStreamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"/Data/HighScores.txt", false);
                        for (int g = 0; g < 3; g++)
                        {
                            HighScoreStreamWriter.WriteLine(intHighScores[g]);
                        }
                        HighScoreStreamWriter.Close();
                        //Ghi lại tên của người đạt điểm cao
                        StreamWriter strUserStreamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"/Data/User.txt", false);
                        for (int h = 0; h < 3; h++)
                        {
                            strUserStreamWriter.WriteLine(strUser[h]);
                        }
                        strUserStreamWriter.Close();
                        //Reset lại điểm của người chơi
                        Score = 0;
                        lblYScore.Text = Score.ToString();
                        Replay();//Chơi lại
                    }
                }
                else
                    MessageBox.Show("Chúc mừng bạn đã hoàn thành tất cả màn chơi, hãy quay trở lại sau khi chúng tôi cập nhật thêm các màn chơi khó hơn nhé!! Cảm ơn!!");
            }
        }

        public void readFile()
        {
            try
            {
                //Đọc file lưu điểm cao để hiển thị lên label Highscore
                StreamReader highScoresStreamReader = new StreamReader(Directory.GetCurrentDirectory() + @"/Data/HighScores.txt");
                while (highScoresStreamReader.Peek() != -1)
                {
                    for (int a = 0; a < 3; a++)
                        intHighScores[a] = int.Parse(highScoresStreamReader.ReadLine());
                }
                highScoresStreamReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu chơi lần cuối!");
            }

            //Đọc file user.txt để lấy tên của người đạt điểm cao
            try
            {
                StreamReader userStreamReader = new StreamReader(Directory.GetCurrentDirectory() + @"/Data/User.txt");
                while (userStreamReader.Peek() != -1)
                {
                    for (int a = 0; a < 3; a++)
                        strUser[a] = userStreamReader.ReadLine();
                }
                userStreamReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu chơi lần cuối!");
            }
            lblHScore.Text = strUser[0] + "     " + intHighScores[0] + "\n" + strUser[1] + "     " + intHighScores[1] + "\n" + strUser[2] + "     " + intHighScores[2];

        }
        private void mnuSaveCurrent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này tạm thời chưa sử dụng được!");
        }

        private void mnuLoadgame_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Chức năng này tạm thời chưa sử dụng được!");
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Nếu trở về trang chủ bây giờ, bạn sẽ phải chơi lại từ đầu, bạn chắc chắn chứ?", "Xác nhận",
                MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                FrmMemory f = new FrmMemory();
                f.Show();
                this.Hide();
            }
        }       

        private void FrmMemory_Load(object sender, EventArgs e)
        {
            
        }
        
        private void Sound_Click(object sender, EventArgs e)
        {
            if (bg.IsLoadCompleted)
            {
                if (playing)
                {
                    bg.Stop();
                    Sound.Image = Image.FromFile("Mute.jpg");
                    var bm = new Bitmap(Sound.Image, new Size(48, 48));
                    Sound.Image = bm;
                    playing = false;
                }
                else
                {
                    bg.Play();
                    Sound.Image = Image.FromFile("Sound_.png");
                    var bm = new Bitmap(Sound.Image, new Size(48, 48));
                    Sound.Image = bm;
                    playing = true;
                }
            }
        }
        
    }

}
