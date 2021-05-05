using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    public class Player
    {
        const int Paddle_speed = 4;
        Random rand = new Random();

        
       public PictureBox paddle;
        Label score_label;
        public bool isUpPressed, isDownPressed ;

        int _score;
        public int score                    //Hàm get và set của score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                score_label.Text = score.ToString();    //In điểm ra màn hình
            }
        }

        //Constructor
        public Player(PictureBox paddle,Label Score)
        {
            this.paddle = paddle;
            this.score_label = Score;
        }

        internal void ProcessMove()         //Hàm xét di chuyển của thanh trượt
        {
            
            bool? goingUp = null;
            if (isUpPressed)                //Di chuyển thanh lên trên 
            {
                goingUp = true;
            }
            else if (isDownPressed)         //Di chuyển thanh đi xuống 
            {
                if (goingUp.HasValue)
                {
                    goingUp = null;
                }
                else
                {
                    goingUp = false;
                }
            }

            DoMove(goingUp);        //Thực hiện di chuyển
        }

        private void DoMove(bool? goingUp)     //Hàm thực hiện di chuyển thanh
        {
            if (goingUp.HasValue)
            {
                var speed = Paddle_speed;
                if (goingUp.Value)      //Giúp thanh trượt đổi hướng mượt hơn
                {
                    speed *= -1;        //Đổi hướng thanh
                }
                //Vị trí mới của thanh khi di chuyển
                paddle.Location = new Point(paddle.Location.X, Math.Max(Limit.Top_Most, Math.Min(Limit.Bot_Most, paddle.Location.Y + speed)));  
            }
        }

        internal void ProcessMove2(Ball ball)   //Hàm để thanh trượt tự di chuyển theo bóng
        {
            paddle.Location = new Point(paddle.Location.X, Math.Max(Limit.Top_Most, Math.Min(Limit.Bot_Most, ball.location_y() + 8)));
        }

        //Destructor
        ~Player()
        {      
        }
    }
}
