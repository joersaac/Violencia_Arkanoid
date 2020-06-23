namespace Source_Code
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnExit.Location = new System.Drawing.Point(315, 575);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(334, 77);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnTop
            // 
            this.btnTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTop.BackColor = System.Drawing.Color.Black;
            this.btnTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTop.FlatAppearance.BorderSize = 0;
            this.btnTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnTop.Location = new System.Drawing.Point(315, 462);
            this.btnTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(334, 77);
            this.btnTop.TabIndex = 2;
            this.btnTop.Text = "TOP 10";
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.BtnTop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnPlay.Location = new System.Drawing.Point(328, 349);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(334, 77);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "JUGAR";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // pictureBox1
            // 
            this.picMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMenu.BackColor = System.Drawing.Color.Transparent;
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.picMenu.Location = new System.Drawing.Point(105, 8);
            this.picMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMenu.Name = "pictureBox1";
            this.picMenu.Size = new System.Drawing.Size(765, 295);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 5;
            this.picMenu.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 734);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnPlay);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTop;

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picMenu;
    }
}

