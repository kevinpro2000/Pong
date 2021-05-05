namespace Pong
{
    partial class PingPong
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
            this.Paddle1 = new System.Windows.Forms.PictureBox();
            this.Paddle2 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Multiplayer = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.P1_Score = new System.Windows.Forms.Label();
            this.P2_Score = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.Label();
            this.Single = new System.Windows.Forms.Timer(this.components);
            this.Mode = new System.Windows.Forms.Label();
            this.Credit = new System.Windows.Forms.Label();
            this.P1_win = new System.Windows.Forms.Label();
            this.P2_win = new System.Windows.Forms.Label();
            this.Control = new System.Windows.Forms.Label();
            this.Wait = new System.Windows.Forms.Label();
            this.LineCenter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Paddle1
            // 
            this.Paddle1.BackColor = System.Drawing.Color.Thistle;
            this.Paddle1.Location = new System.Drawing.Point(32, 163);
            this.Paddle1.Name = "Paddle1";
            this.Paddle1.Size = new System.Drawing.Size(15, 100);
            this.Paddle1.TabIndex = 0;
            this.Paddle1.TabStop = false;
            // 
            // Paddle2
            // 
            this.Paddle2.BackColor = System.Drawing.Color.Coral;
            this.Paddle2.Location = new System.Drawing.Point(751, 163);
            this.Paddle2.Name = "Paddle2";
            this.Paddle2.Size = new System.Drawing.Size(15, 100);
            this.Paddle2.TabIndex = 1;
            this.Paddle2.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.MidnightBlue;
            this.Ball.Image = global::Pong.Properties.Resources.pixil_frame_0__1_;
            this.Ball.Location = new System.Drawing.Point(408, 201);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // Multiplayer
            // 
            this.Multiplayer.Interval = 10;
            this.Multiplayer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Score.Location = new System.Drawing.Point(375, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(72, 31);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score";
            // 
            // P1_Score
            // 
            this.P1_Score.AutoSize = true;
            this.P1_Score.Font = new System.Drawing.Font("MV Boli", 14F);
            this.P1_Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P1_Score.Location = new System.Drawing.Point(376, 40);
            this.P1_Score.Name = "P1_Score";
            this.P1_Score.Size = new System.Drawing.Size(25, 25);
            this.P1_Score.TabIndex = 5;
            this.P1_Score.Text = "0";
            // 
            // P2_Score
            // 
            this.P2_Score.AutoSize = true;
            this.P2_Score.Font = new System.Drawing.Font("MV Boli", 14F);
            this.P2_Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P2_Score.Location = new System.Drawing.Point(424, 40);
            this.P2_Score.Name = "P2_Score";
            this.P2_Score.Size = new System.Drawing.Size(25, 25);
            this.P2_Score.TabIndex = 6;
            this.P2_Score.Text = "0";
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Font = new System.Drawing.Font("MV Boli", 14F);
            this.Line.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Line.Location = new System.Drawing.Point(403, 40);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(20, 25);
            this.Line.TabIndex = 7;
            this.Line.Text = "|";
            this.Line.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Single
            // 
            this.Single.Interval = 10;
            this.Single.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Font = new System.Drawing.Font("Tempus Sans ITC", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mode.Location = new System.Drawing.Point(206, 111);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(415, 234);
            this.Mode.TabIndex = 8;
            this.Mode.Text = "Welcome to PingPong Game\r\n\r\nF1 - Single Player\r\nF2 - Multiplayer\r\nF3 - How to pla" +
    "y\r\nEsc - Exit";
            this.Mode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Credit.Location = new System.Drawing.Point(12, 417);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(276, 25);
            this.Credit.TabIndex = 9;
            this.Credit.Text = "Made by 18120175_18120178";
            // 
            // P1_win
            // 
            this.P1_win.AutoSize = true;
            this.P1_win.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1_win.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P1_win.Location = new System.Drawing.Point(300, 150);
            this.P1_win.Name = "P1_win";
            this.P1_win.Size = new System.Drawing.Size(226, 175);
            this.P1_win.TabIndex = 10;
            this.P1_win.Text = "Player1 Win\r\n\r\nF1 - Single Player\r\nF2 - Multiplayer\r\nEsc - Exit";
            this.P1_win.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // P2_win
            // 
            this.P2_win.AutoSize = true;
            this.P2_win.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2_win.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P2_win.Location = new System.Drawing.Point(300, 150);
            this.P2_win.Name = "P2_win";
            this.P2_win.Size = new System.Drawing.Size(226, 175);
            this.P2_win.TabIndex = 11;
            this.P2_win.Text = "Player2 Win\r\n\r\nF1 - Single Player\r\nF2 - Multiplayer\r\nEsc - Exit";
            this.P2_win.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Control
            // 
            this.Control.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Control.AutoSize = true;
            this.Control.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Control.Location = new System.Drawing.Point(306, 116);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(230, 217);
            this.Control.TabIndex = 12;
            this.Control.Text = "How to play:\r\n\r\nPlayer1 - W, S\r\nPlayer2 - Up, Down\r\nPause - P\r\nBack to menu - B\r\n" +
    "5 Points = Win";
            this.Control.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Wait
            // 
            this.Wait.AutoSize = true;
            this.Wait.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wait.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Wait.Location = new System.Drawing.Point(26, 14);
            this.Wait.Name = "Wait";
            this.Wait.Size = new System.Drawing.Size(238, 78);
            this.Wait.TabIndex = 13;
            this.Wait.Text = "Pause\r\nChange Mode - F1 or F2\r\nBack to menu - B";
            // 
            // LineCenter
            // 
            this.LineCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LineCenter.BackColor = System.Drawing.Color.PowderBlue;
            this.LineCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LineCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.LineCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineCenter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LineCenter.Location = new System.Drawing.Point(408, 80);
            this.LineCenter.Margin = new System.Windows.Forms.Padding(3);
            this.LineCenter.Name = "LineCenter";
            this.LineCenter.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LineCenter.Size = new System.Drawing.Size(5, 351);
            this.LineCenter.TabIndex = 14;
            // 
            // PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(794, 452);
            this.Controls.Add(this.LineCenter);
            this.Controls.Add(this.Wait);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.P2_win);
            this.Controls.Add(this.P1_win);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.P2_Score);
            this.Controls.Add(this.P1_Score);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Paddle2);
            this.Controls.Add(this.Paddle1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 490);
            this.MinimumSize = new System.Drawing.Size(810, 490);
            this.Name = "PingPong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingPong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.PictureBox Paddle1;
        private System.Windows.Forms.PictureBox Paddle2;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer Multiplayer;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label P1_Score;
        private System.Windows.Forms.Label P2_Score;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Timer Single;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Label Credit;
        private System.Windows.Forms.Label P1_win;
        private System.Windows.Forms.Label P2_win;
        private System.Windows.Forms.Label Control;
        private System.Windows.Forms.Label Wait;
        private System.Windows.Forms.Label LineCenter;
    }
}

