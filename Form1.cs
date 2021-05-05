using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class PingPong : Form
    {
        Player P1, P2;
        Ball ball;
        int Pause; //Biến được dùng để tạm dừng trò chơi


        public PingPong()
        {
            InitializeComponent();

            Multiplayer.Enabled = false;                                 //Chế độ trò chơi 2 người
            Single.Enabled = false;                                 //Chế độ chơi 1 người
            this.TopMost = true;                                //Đặt form lên phía trước
            Mode.Visible = Credit.Visible = true;               //Hiện thanh chào mừng

            //Ẩn sàn đấu và bảng control
            Paddle1.Visible = Paddle2.Visible = Ball.Visible
                = Score.Visible = P1_Score.Visible = P2_Score.Visible = Line.Visible
                = P1_win.Visible = P2_win.Visible = Wait.Visible = LineCenter.Visible = Control.Visible = false;


            P1 = new Player(Paddle1, P1_Score);
            P2 = new Player(Paddle2, P2_Score);
            ball = new Ball(Ball, P1, P2);
        }


        //Multiplayer Player
        private void timer1_Tick(object sender, EventArgs e)
        {
            P1.ProcessMove();       //Xét di chuyển cho thanh trượt 1
            P2.ProcessMove();       //Xét di chuyển cho thanh trượt 2
            ball.ProcessMove();         //Xét di chuyển cho bóng

            //Đặt điều kiện thắng
            if (P1.score == 5)
            {
                Multiplayer.Enabled = false;         //Dừng trò chơi
                P1_win.Visible = true;                          //Hiện kết quả
                Paddle1.Visible = Paddle2.Visible = Ball.Visible
                = Score.Visible = P1_Score.Visible = P2_Score.Visible = Line.Visible = LineCenter.Visible = false;       //Ẩn sàn đấu

            }
            else if (P2.score == 5)
            {
                Multiplayer.Enabled = false;
                P2_win.Visible = true;                          //Hiện kết quả
                Paddle1.Visible = Paddle2.Visible = Ball.Visible
                = Score.Visible = P1_Score.Visible = P2_Score.Visible = Line.Visible = LineCenter.Visible = false;   //Ẩn sàn đấu

            }
        }

        //Single Player
        private void timer2_Tick(object sender, EventArgs e)
        {
            P1.ProcessMove();       //Xét di chuyển cho thanh trượt 1
            P2.ProcessMove2(ball);       //Xét di chuyển cho máy
            ball.ProcessMove();         //Xét di chuyển cho bóng

            //Đặt điều kiện thắng
            if (P1.score == 5)
            {
                Single.Enabled = false;         //Dừng trò chơi
                P1_win.Visible = true;                          //Hiện kết quả
                Paddle1.Visible = Paddle2.Visible = Ball.Visible
                = Score.Visible = P1_Score.Visible = P2_Score.Visible = Line.Visible = LineCenter.Visible = false;   //Ẩn sàn đấu
                Pause = 0;
            }
            else if (P2.score == 5)
            {
                Single.Enabled = false;         //Dừng trò chơi
                P2_win.Visible = true;                          //Hiện kết quả
                Paddle1.Visible = Paddle2.Visible = Ball.Visible
                = Score.Visible = P1_Score.Visible = P2_Score.Visible = Line.Visible = LineCenter.Visible = false;   //Ẩn sàn đấu
                Pause = 0;
            }
        }

        //Cài đặt phím di chuyển
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Checkkey(e, true);

            if (e.KeyCode == Keys.P)
            {
                CheckPause();
            }

            if (e.KeyCode == Keys.B)
            {
                CheckBack();
            }

            if (e.KeyCode == Keys.F1 && Multiplayer.Enabled == false)
            {
                Pause = 1;
                Single.Enabled = true;  //Chạy single player
                P1.score = P2.score = 0;        //Đặt lại kết quả
                Mode.Visible = Credit.Visible = Control.Visible
                    = P1_win.Visible = P2_win.Visible
                    = Wait.Visible = false;        //Ẩn thanh chào mừng
                Paddle1.Visible = Paddle2.Visible = Ball.Visible
                    = Score.Visible = P1_Score.Visible = P2_Score.Visible = Line.Visible = LineCenter.Visible = true;    //Hiện sân chơi
            }

            if (e.KeyCode == Keys.F2 && Single.Enabled == false)
            {
                Pause = 2;
                Multiplayer.Enabled = true;             //Chạy multiplayer
                P1.score = P2.score = 0;        //Đặt lại kết quả
                Mode.Visible = Credit.Visible = Control.Visible
                     = P1_win.Visible = P2_win.Visible
                     = Wait.Visible = false;        //Ẩn thanh chào mừng
                Paddle1.Visible = Paddle2.Visible = Ball.Visible
                    = Score.Visible = P1_Score.Visible = P2_Score.Visible = Line.Visible = LineCenter.Visible = true;    //Hiện sân chơi
            }

            if (e.KeyCode == Keys.F3 && Single.Enabled == false && Multiplayer.Enabled == false && Pause == 0)
            {
                Mode.Visible = Credit.Visible //Ẩn thanh chào mừng
                       = P1_win.Visible = P2_win.Visible = false;
                Control.Visible = true;    //Hiện hướng dẫn chơi
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Checkkey(e, false);
        }

        private void CheckBack()
        {
            if (Multiplayer.Enabled == false && Single.Enabled == false) //nếu chưa vào lượt chơi
            {
                Control.Visible = P1_win.Visible = P2_win.Visible = false; //Ẩn hướng dẫn
                Mode.Visible = Credit.Visible = true; //Hiện lại thanh chào mừng (menu)
            }
            if (Wait.Visible == true) //nếu đang pause trong lượt chơi
            {
                Wait.Visible = false;
                Mode.Visible = Credit.Visible = true; //Hiện lại thanh chào mừng (menu)
                Paddle1.Visible = Paddle2.Visible = Ball.Visible
               = Score.Visible = P1_Score.Visible = P2_Score.Visible = Line.Visible = LineCenter.Visible = Control.Visible = false;   //Ẩn sàn đấu
                Pause = 0;
            }
        }

        //Hàm tạm dừng trò chơi
        private void CheckPause()
        {
            //Tạm dừng trò chơi ở chế độ Multiplayer
            if (Multiplayer.Enabled == true && Single.Enabled == false)
            {
                Wait.Visible = true;
                Multiplayer.Enabled = false;
            }
            //Tiếp tục trò chơi ở chế độ Multiplayer
            else if (Multiplayer.Enabled == false && Single.Enabled == false && Pause == 2)
            {
                Wait.Visible = false;
                Multiplayer.Enabled = true;
            }
            //Tạm dừng trò chơi ở chế độ Single Player
            else if (Single.Enabled == true && Multiplayer.Enabled == false)
            {
                Wait.Visible = true;
                Single.Enabled = false;
            }
            //Tiếp tục trò chơi ở chế độ Single Player
            else if (Single.Enabled == false && Multiplayer.Enabled == false && Pause == 1)
            {
                Wait.Visible = false;
                Single.Enabled = true;
            }
        }


        //Hàm kiểm tra nút di chuyển để di chuyển thanh trượt và phím bắt đầu trò chơi
        private void Checkkey(KeyEventArgs e, bool isDown)
        {
            switch (e.KeyCode)
            {
                //P1
                case Keys.W:
                    P1.isUpPressed = isDown;
                    break;
                case Keys.S:
                    P1.isDownPressed = isDown;
                    break;

                //P2
                case Keys.Up:
                    P2.isUpPressed = isDown;
                    break;
                case Keys.Down:
                    P2.isDownPressed = isDown;
                    break;

                //Nhấn ESC để thoát game
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }


    }
}
