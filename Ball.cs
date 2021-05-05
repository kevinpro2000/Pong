using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    public class Ball
    {
        public PictureBox ball;
        Random rand = new Random();
        Player P1, P2;
        int x_ball_speed, y_ball_speed;

        //Constructor
        public Ball(PictureBox ball, Player P1, Player P2)
        {
            this.ball = ball;
            this.P1 = P1;
            this.P2 = P2;
            x_ball_speed = 2;
            y_ball_speed = 2;
            Reset();
        }

        internal void ProcessMove()
        {
            //Hàm di chuyển bóng
            DoMove();

            if (ball.Location.X <= Limit.Left_Most)     //P2 ghi điểm khi bóng chạm cạnh trái
            {
                Score(P2);  //P2 ghi điiểm
            }
            else if (ball.Location.X >= 800 - ball.Width)       //P1 ghi điểm khi bóng chạm cạnh phải
            {
                Score(P1);  //P1 ghi điểm
            }

            if (P1.paddle.Bounds.IntersectsWith(ball.Bounds) || P2.paddle.Bounds.IntersectsWith(ball.Bounds))   //Bóng đổi hướng khi chạm phải thanh trượt
            {
                x_ball_speed *= -1;         //Bóng đổi hướng
              
                //Tăng tốc độ ngang của bóng
                if (x_ball_speed < 0)           
                {
                    x_ball_speed--;     
                }
                else
                {
                    x_ball_speed++;
                }
               //Tăng tốc độ dọc của bóng
                if (y_ball_speed < 0)
                {
                    y_ball_speed--;
                }
                else
                {
                    y_ball_speed++;
                }
                while (P1.paddle.Bounds.IntersectsWith(ball.Bounds) || P2.paddle.Bounds.IntersectsWith(ball.Bounds)) //Fix bug
                {
                    DoMove();
                }
            }
        }

        private void DoMove()       
        {
            ball.Location = new Point(ball.Location.X + x_ball_speed, Math.Max(10, Math.Min(420, ball.Location.Y + y_ball_speed)));     //Thiết lập giới hạn của bóng
            if (ball.Location.Y == 420 || ball.Location.Y == 10)    //Bóng chạm cạnh trên hoặc cạnh dưới
            {
                y_ball_speed *= -1; //Bóng đổi hướng
            }
        }

        private void Score(Player winner)   //Cộng điểm cho người chơi và reset lại bóng
        {
            winner.score++;
            Reset();
        }

        private void Reset()        //Hàm tạo mới bóng về vị trí giữa
        {
            ball.Location = new Point((Limit.Right_Most-100) / 2, Limit.Bot_Most / 2);  //Vị trí giữa
            do
            {
                x_ball_speed = rand.Next(-2, 2);
                y_ball_speed = rand.Next(-2, 2);
            } while (Math.Abs(x_ball_speed) + Math.Abs(y_ball_speed) <= 2);             //Cài tốc độ ban đầu cho bóng
        }

        public int location_y()     //Lấy tọa độ y của bóng
        {
            return ball.Location.Y;
        }

        //Destructor
        ~Ball()
        {
        }
    }
}
