using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brave_Archer
{
    public partial class gameScreen : Form
    {
        Player P = new Player();
        Arrow A = new Arrow();
        Balloon B = new Balloon();
        Archer Ar = new Archer();

       //sreen borders
        const int x = 150, y = 700;
        const int limit = 800;

        //Variables
        bool moveUp;
        bool moveDown;
        int HighScore;

        //Constructor
        public gameScreen()
        {
            InitializeComponent();           
        }
       
        List<PictureBox> greenBalloons = new List<PictureBox>();
        List<PictureBox> yellowBalloons = new List<PictureBox>();
        List<PictureBox> redBalloons = new List<PictureBox>();

        //window_Load method
        private void gameSreen_Load(object sender, EventArgs e)
        {
            saveBtn.Visible = false;
            replayBtn.Visible = false;
            ouitBtn.Visible = false;
            pauseMenuLbl.Visible = false;
            gameOverlLbl.Visible = false;
            youWon.Visible = false;

            new Archer().load_archer(this);
            new Balloon().load_Balloon(this);
            new yellowBalloon().load_Balloon(this);
            new redBalloon().load_Balloon(this);

            InsertGballoon();
            InsertYballoon();
            InsertRballoon();

            Levels();
        }

        //Save game button
        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        //Replay game button
        private void replayBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            gameSreen_Load(e,e);
        }

        //Quit game button
        private void ouitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        //GamePaused
        private void GamePaused()
        {
            pauseMenuLbl.Visible = true;
            P.pause = true;
            saveBtn.Visible = true;
            replayBtn.Visible = true;
            ouitBtn.Visible = true;
            StopTimers();
        }

        //continue game
        private void GameContinue()
        {
            pauseMenuLbl.Visible = false;
            P.pause = false;
            saveBtn.Visible = false;
            replayBtn.Visible = false;
            ouitBtn.Visible = false;
            StartTimers();
        }
      
        //GameOver 
        private void GameOver()
        {
            gameOverlLbl.Visible = true;
            P.gameIsOver = true;
            P.pause = true;
            replayBtn.Visible = true;
            ouitBtn.Visible = true;
            StopTimers();
        }

        //Stop Timers
        private void StopTimers()
        {
            MoveRBalloonsTimer.Stop();
            MoveGBalloonsTimer.Stop();
            MoveYBalloonsTimer.Stop();
            MoveRBalloonsTimer.Stop();
            MoveArrowTimer.Stop();
        }

        //Start Timers
        private void StartTimers()
        {
            MoveRBalloonsTimer.Start();
            MoveGBalloonsTimer.Start();
            MoveYBalloonsTimer.Start();
            MoveRBalloonsTimer.Start();
            MoveArrowTimer.Start();
        }

        //key properties
        private void Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
            else if (e.KeyCode == Keys.Space && !P.gameIsOver && !A.fired)
            {
                A.load_arrow(this);
                A.fired = true;
            }
            else if (e.KeyCode == Keys.P)
            {
                GamePaused();
            }
        }

        private void Released(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                A.fired = false;
            }
            else if (e.KeyCode == Keys.P)
            {
                GameContinue();
            }
        }

        //game statements

        private void Levels()
        {
            if (P.Score < 300)
            {
                B.balloonSpeed += 1;
                new Balloon().CreateBalloons(this);

                InsertGballoon();
                if (P.Score < 200 && P.Score >= 100)
                {
                    P.Level += 1;
                    Level(P.Level);
                    B.balloonSpeed += 1;
                    new yellowBalloon().CreateBalloons(this);
                    InsertGballoon();
                    InsertYballoon();
                }
                else if (P.Score < 300 && P.Score >= 200)
                {
                    P.Level += 1;
                    Level(P.Level);
                    B.balloonSpeed += 1;
                    new redBalloon().CreateBalloons(this);
                    InsertGballoon();
                    InsertYballoon();
                }
            }
        }
        private void CheckForWinner()
        {
          
            if(P.Score > 300)
            {
                youWon.Visible = true;
            }
        }

        //Balloons Vertical Move Method
        //green
        private void InsertGballoon()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "greenBalloon")
                {         
                        PictureBox balloon = (PictureBox)c;
                        greenBalloons.Add(balloon);            
                }
            }
        }
     
        //yellow
        private void InsertYballoon()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "yellowBalloon")
                {
                    PictureBox balloon = (PictureBox)c;
                    yellowBalloons.Add(balloon);
                }
            }
        }

        //red
        private void InsertRballoon()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "redBalloon")
                {
                    PictureBox balloon = (PictureBox)c;
                    redBalloons.Add(balloon);
                }
            }
        }
        //move balloons
        private void MoveGBalloons(object sender, EventArgs e)
        {
            balloonMove(greenBalloons);
        }
        private void MoveYBalloons(object sender, EventArgs e)
        {
            balloonMove(yellowBalloons);
        }
        private void MoveRBalloons(object sender, EventArgs e)
        {
            balloonMove(redBalloons);
        }

        private void balloonMove(List<PictureBox> balloons)
        {
            foreach (PictureBox balloon in balloons)
            {
                {
                    balloon.Visible = true;
                    balloon.Top += 1;

                    if (balloon.Top > this.Height)
                    {
                        balloon.Location = new Point((+1) * 50, -200);
                    }
                }
            }
        }

            //move player
            private void PlayerMove(object sender, EventArgs e)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && c.Name == "Archer")
                    {
                        PictureBox archer = (PictureBox)c;
                        if (moveUp && Ar.Location.Y >= 0)
                        {
                            archer.Top--;
                            Ar.Location.Y--;
                        }
                        else if (moveDown)
                        {
                            archer.Top++;
                            Ar.Location.Y++;
                        }
                    }
                }
            }


        //fire Arrow
        private void FireArrow(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "Arrow")
                {
                    PictureBox arrow = (PictureBox)c;
                    arrow.Left += 5;

                    if (arrow.Location.X <= 0)
                    {
                        this.Controls.Remove(arrow);
                    }
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is PictureBox && ctrl.Name == "greenBalloon")
                        {
                            PictureBox greenBalloon = (PictureBox)ctrl;


                            if (Touched(greenBalloon))
                            { GameOver(); }
                            else if(arrow.Bounds.IntersectsWith(greenBalloon.Bounds) && !Touched(greenBalloon))
                            {                                
                                this.Controls.Remove(arrow);
                                this.Controls.Remove(greenBalloon);
                                
                                P.Score += 5;
                                Score(P.Score);
                                highScore(P.Score,HighScore);
                                CheckForWinner();
                            }                 
                        }
                        else if (ctrl is PictureBox && ctrl.Name == "yellowBalloon")
                        {
                            PictureBox yellowBalloon = (PictureBox)ctrl;

                            if (arrow.Bounds.IntersectsWith(yellowBalloon.Bounds))
                            {
                                P.Score += 15;
                                this.Controls.Remove(arrow);
                                this.Controls.Remove(yellowBalloon);
                                CheckForWinner();
                                Score(P.Score);
                                highScore(P.Score, HighScore);
                            }
                        }
                        else if (ctrl is PictureBox && ctrl.Name == "redBalloon")
                        {
                            PictureBox redBalloon = (PictureBox)ctrl;

                            if (arrow.Bounds.IntersectsWith(redBalloon.Bounds))
                            {
                                GameOver();
                            }
                        }
                    }

                }

            }

        }
        private void Level(int level)
        {
            levelNumberLbl.Text = level.ToString();
        }
        private void Score(int pts)
        {
            scoreNumberlbl.Text = pts.ToString();
        }
        private void highScore(int pts,int highScore)
        {
            if (pts > highScore)
            {
                highScoreLbl.Text = pts.ToString();
                highScore = pts;
            }   
            else
                highScoreLbl.Text = highScore.ToString();
        }

        //limits
        private bool Touched(PictureBox a)
        {
            return a.Location.Y <= 0 || a.Location.Y >= limit;
        }

        //Move Arrow Timer_Tick
        private void MoveArrowTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
