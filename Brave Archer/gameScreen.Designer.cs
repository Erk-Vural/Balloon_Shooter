namespace Brave_Archer
{
    partial class gameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameScreen));
            this.scorelbl = new System.Windows.Forms.Label();
            this.scoreNumberlbl = new System.Windows.Forms.Label();
            this.levelLbl = new System.Windows.Forms.Label();
            this.arrowLbl = new System.Windows.Forms.Label();
            this.gameOverlLbl = new System.Windows.Forms.Label();
            this.pauseMenuLbl = new System.Windows.Forms.Label();
            this.levelNumberLbl = new System.Windows.Forms.Label();
            this.arrowNumberLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.replayBtn = new System.Windows.Forms.Button();
            this.ouitBtn = new System.Windows.Forms.Button();
            this.MoveGBalloonsTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveArrowTimer = new System.Windows.Forms.Timer(this.components);
            this.highScoreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MoveRBalloonsTimer = new System.Windows.Forms.Timer(this.components);
            this.youWon = new System.Windows.Forms.Label();
            this.MoveYBalloonsTimer = new System.Windows.Forms.Timer(this.components);
            this.playerMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scorelbl.Location = new System.Drawing.Point(1055, 66);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(86, 24);
            this.scorelbl.TabIndex = 0;
            this.scorelbl.Text = "SCORE: ";
            // 
            // scoreNumberlbl
            // 
            this.scoreNumberlbl.AutoSize = true;
            this.scoreNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreNumberlbl.Location = new System.Drawing.Point(1147, 66);
            this.scoreNumberlbl.Name = "scoreNumberlbl";
            this.scoreNumberlbl.Size = new System.Drawing.Size(20, 24);
            this.scoreNumberlbl.TabIndex = 1;
            this.scoreNumberlbl.Text = "0";
            // 
            // levelLbl
            // 
            this.levelLbl.AutoSize = true;
            this.levelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.levelLbl.Location = new System.Drawing.Point(1055, 114);
            this.levelLbl.Name = "levelLbl";
            this.levelLbl.Size = new System.Drawing.Size(79, 24);
            this.levelLbl.TabIndex = 4;
            this.levelLbl.Text = "LEVEL: ";
            // 
            // arrowLbl
            // 
            this.arrowLbl.AutoSize = true;
            this.arrowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arrowLbl.Location = new System.Drawing.Point(1055, 165);
            this.arrowLbl.Name = "arrowLbl";
            this.arrowLbl.Size = new System.Drawing.Size(92, 24);
            this.arrowLbl.TabIndex = 6;
            this.arrowLbl.Text = "ARROW: ";
            // 
            // gameOverlLbl
            // 
            this.gameOverlLbl.AutoSize = true;
            this.gameOverlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOverlLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.gameOverlLbl.Location = new System.Drawing.Point(431, 165);
            this.gameOverlLbl.Name = "gameOverlLbl";
            this.gameOverlLbl.Size = new System.Drawing.Size(314, 55);
            this.gameOverlLbl.TabIndex = 2;
            this.gameOverlLbl.Text = "GAME OVER";
            // 
            // pauseMenuLbl
            // 
            this.pauseMenuLbl.AutoSize = true;
            this.pauseMenuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pauseMenuLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pauseMenuLbl.Location = new System.Drawing.Point(516, 220);
            this.pauseMenuLbl.Name = "pauseMenuLbl";
            this.pauseMenuLbl.Size = new System.Drawing.Size(148, 37);
            this.pauseMenuLbl.TabIndex = 3;
            this.pauseMenuLbl.Text = "PAUSED";
            // 
            // levelNumberLbl
            // 
            this.levelNumberLbl.AutoSize = true;
            this.levelNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.levelNumberLbl.Location = new System.Drawing.Point(1147, 114);
            this.levelNumberLbl.Name = "levelNumberLbl";
            this.levelNumberLbl.Size = new System.Drawing.Size(20, 24);
            this.levelNumberLbl.TabIndex = 7;
            this.levelNumberLbl.Text = "1";
            // 
            // arrowNumberLbl
            // 
            this.arrowNumberLbl.AutoSize = true;
            this.arrowNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arrowNumberLbl.Location = new System.Drawing.Point(1147, 165);
            this.arrowNumberLbl.Name = "arrowNumberLbl";
            this.arrowNumberLbl.Size = new System.Drawing.Size(30, 24);
            this.arrowNumberLbl.TabIndex = 8;
            this.arrowNumberLbl.Text = "50";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveBtn.Location = new System.Drawing.Point(441, 271);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(292, 74);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "SAVE GAME";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // replayBtn
            // 
            this.replayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.replayBtn.Location = new System.Drawing.Point(441, 385);
            this.replayBtn.Name = "replayBtn";
            this.replayBtn.Size = new System.Drawing.Size(292, 74);
            this.replayBtn.TabIndex = 10;
            this.replayBtn.Text = "REPLAY";
            this.replayBtn.UseVisualStyleBackColor = true;
            this.replayBtn.Click += new System.EventHandler(this.replayBtn_Click);
            // 
            // ouitBtn
            // 
            this.ouitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ouitBtn.Location = new System.Drawing.Point(441, 509);
            this.ouitBtn.Name = "ouitBtn";
            this.ouitBtn.Size = new System.Drawing.Size(292, 74);
            this.ouitBtn.TabIndex = 11;
            this.ouitBtn.Text = "QUIT GAME";
            this.ouitBtn.UseVisualStyleBackColor = true;
            this.ouitBtn.Click += new System.EventHandler(this.ouitBtn_Click);
            // 
            // MoveGBalloonsTimer
            // 
            this.MoveGBalloonsTimer.Enabled = true;
            this.MoveGBalloonsTimer.Interval = 10;
            this.MoveGBalloonsTimer.Tick += new System.EventHandler(this.MoveGBalloons);
            // 
            // MoveArrowTimer
            // 
            this.MoveArrowTimer.Enabled = true;
            this.MoveArrowTimer.Interval = 10;
            this.MoveArrowTimer.Tick += new System.EventHandler(this.FireArrow);
            // 
            // highScoreLbl
            // 
            this.highScoreLbl.AutoSize = true;
            this.highScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highScoreLbl.Location = new System.Drawing.Point(1146, 23);
            this.highScoreLbl.Name = "highScoreLbl";
            this.highScoreLbl.Size = new System.Drawing.Size(20, 24);
            this.highScoreLbl.TabIndex = 14;
            this.highScoreLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1009, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "HIGH-SCORE: ";
            // 
            // MoveRBalloonsTimer
            // 
            this.MoveRBalloonsTimer.Enabled = true;
            this.MoveRBalloonsTimer.Interval = 10;
            this.MoveRBalloonsTimer.Tick += new System.EventHandler(this.MoveRBalloons);
            // 
            // youWon
            // 
            this.youWon.AutoSize = true;
            this.youWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.youWon.ForeColor = System.Drawing.Color.Green;
            this.youWon.Location = new System.Drawing.Point(369, 338);
            this.youWon.Name = "youWon";
            this.youWon.Size = new System.Drawing.Size(408, 73);
            this.youWon.TabIndex = 15;
            this.youWon.Text = "YOU WON!!!";
            // 
            // MoveYBalloonsTimer
            // 
            this.MoveYBalloonsTimer.Enabled = true;
            this.MoveYBalloonsTimer.Interval = 10;
            this.MoveYBalloonsTimer.Tick += new System.EventHandler(this.MoveYBalloons);
            // 
            // playerMoveTimer
            // 
            this.playerMoveTimer.Enabled = true;
            this.playerMoveTimer.Interval = 10;
            this.playerMoveTimer.Tick += new System.EventHandler(this.PlayerMove);
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 781);
            this.Controls.Add(this.youWon);
            this.Controls.Add(this.highScoreLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ouitBtn);
            this.Controls.Add(this.replayBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.arrowNumberLbl);
            this.Controls.Add(this.levelNumberLbl);
            this.Controls.Add(this.arrowLbl);
            this.Controls.Add(this.levelLbl);
            this.Controls.Add(this.pauseMenuLbl);
            this.Controls.Add(this.gameOverlLbl);
            this.Controls.Add(this.scoreNumberlbl);
            this.Controls.Add(this.scorelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gameScreen";
            this.Load += new System.EventHandler(this.gameSreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Released);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label scoreNumberlbl;
        private System.Windows.Forms.Label levelLbl;
        private System.Windows.Forms.Label arrowLbl;
        private System.Windows.Forms.Label gameOverlLbl;
        private System.Windows.Forms.Label pauseMenuLbl;
        private System.Windows.Forms.Label levelNumberLbl;
        private System.Windows.Forms.Label arrowNumberLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button replayBtn;
        private System.Windows.Forms.Button ouitBtn;
        private System.Windows.Forms.Timer MoveGBalloonsTimer;
        private System.Windows.Forms.Timer MoveArrowTimer;
        private System.Windows.Forms.Label highScoreLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer MoveRBalloonsTimer;
        private System.Windows.Forms.Label youWon;
        private System.Windows.Forms.Timer MoveYBalloonsTimer;
        private System.Windows.Forms.Timer playerMoveTimer;
    }
}