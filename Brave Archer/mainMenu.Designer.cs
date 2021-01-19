namespace Brave_Archer
{
    partial class mainMenu
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
            this.newGamebtn = new System.Windows.Forms.Button();
            this.continuebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreBoardbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGamebtn
            // 
            this.newGamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newGamebtn.Location = new System.Drawing.Point(113, 110);
            this.newGamebtn.Name = "newGamebtn";
            this.newGamebtn.Size = new System.Drawing.Size(200, 75);
            this.newGamebtn.TabIndex = 0;
            this.newGamebtn.Text = "NEW GAME";
            this.newGamebtn.UseVisualStyleBackColor = true;
            this.newGamebtn.Click += new System.EventHandler(this.newGamebtn_Click);
            // 
            // continuebtn
            // 
            this.continuebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.continuebtn.Location = new System.Drawing.Point(113, 217);
            this.continuebtn.Name = "continuebtn";
            this.continuebtn.Size = new System.Drawing.Size(200, 75);
            this.continuebtn.TabIndex = 2;
            this.continuebtn.Text = "CONTINUE";
            this.continuebtn.UseVisualStyleBackColor = true;
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitbtn.Location = new System.Drawing.Point(113, 419);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(200, 75);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "MAIN MENU";
            // 
            // scoreBoardbtn
            // 
            this.scoreBoardbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreBoardbtn.Location = new System.Drawing.Point(113, 318);
            this.scoreBoardbtn.Name = "scoreBoardbtn";
            this.scoreBoardbtn.Size = new System.Drawing.Size(200, 75);
            this.scoreBoardbtn.TabIndex = 4;
            this.scoreBoardbtn.Text = "SETTINGS";
            this.scoreBoardbtn.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.scoreBoardbtn);
            this.Controls.Add(this.continuebtn);
            this.Controls.Add(this.newGamebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGamebtn;
        private System.Windows.Forms.Button continuebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scoreBoardbtn;
    }
}

