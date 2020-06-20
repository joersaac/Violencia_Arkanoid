namespace Source_Code
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.button2 = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(315, 575);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 77);
            this.button2.TabIndex = 4;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
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
            this.btnTop.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnTop.Location = new System.Drawing.Point(315, 462);
            this.btnTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(334, 77);
            this.btnTop.TabIndex = 2;
            this.btnTop.Text = "TOP 10";
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlay.BackColor = System.Drawing.Color.Black;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonPlay.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.PaleGreen;
            this.buttonPlay.Location = new System.Drawing.Point(315, 349);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(334, 77);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "JUGAR";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 734);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.buttonPlay);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}

