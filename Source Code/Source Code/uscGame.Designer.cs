namespace Source_Code
{
    partial class uscGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscGame));
            this.lblMessage = new System.Windows.Forms.Label();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picPlatform = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.picLife = new System.Windows.Forms.PictureBox();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.picStats = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(288, 419);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(240, 26);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Has click para empezar";
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(392, 380);
            this.picBall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(35, 35);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 8;
            this.picBall.TabStop = false;
            // 
            // picPlatform
            // 
            this.picPlatform.BackColor = System.Drawing.Color.Transparent;
            this.picPlatform.Image = ((System.Drawing.Image)(resources.GetObject("picPlatform.Image")));
            this.picPlatform.Location = new System.Drawing.Point(332, 514);
            this.picPlatform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlatform.Name = "picPlatform";
            this.picPlatform.Size = new System.Drawing.Size(140, 35);
            this.picPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlatform.TabIndex = 7;
            this.picPlatform.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTime.Font = new System.Drawing.Font("Niagara Solid", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(352, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 43);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "TIME: 6000";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblLevel.Font = new System.Drawing.Font("Niagara Solid", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(200, 7);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(90, 43);
            this.lblLevel.TabIndex = 16;
            this.lblLevel.Text = "LEVEL 1";
            // 
            // picLife
            // 
            this.picLife.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLife.BackColor = System.Drawing.Color.DarkSlateGray;
            this.picLife.Image = ((System.Drawing.Image)(resources.GetObject("picLife.Image")));
            this.picLife.Location = new System.Drawing.Point(22, 7);
            this.picLife.Name = "picLife";
            this.picLife.Size = new System.Drawing.Size(61, 37);
            this.picLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLife.TabIndex = 15;
            this.picLife.TabStop = false;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblLives.Font = new System.Drawing.Font("Niagara Solid", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(89, 7);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(46, 43);
            this.lblLives.TabIndex = 14;
            this.lblLives.Text = "X 3";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblScore.Font = new System.Drawing.Font("Niagara Solid", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(551, 7);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(99, 43);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "SCORE: 0";
            // 
            // picStats
            // 
            this.picStats.BackColor = System.Drawing.Color.DarkSlateGray;
            this.picStats.Location = new System.Drawing.Point(0, 0);
            this.picStats.Name = "picStats";
            this.picStats.Size = new System.Drawing.Size(802, 64);
            this.picStats.TabIndex = 12;
            this.picStats.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uscGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.picLife);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picStats);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picPlatform);
            this.Name = "uscGame";
            this.Size = new System.Drawing.Size(802, 660);
            this.Load += new System.EventHandler(this.uscGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picPlatform;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.PictureBox picLife;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picStats;
        private System.Windows.Forms.Timer timer1;
    }
}
