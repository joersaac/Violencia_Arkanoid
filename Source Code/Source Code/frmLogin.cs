using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Source_Code
{
    public partial class frmLogin : Form
    {
        private frmGame Game = new frmGame();
        public frmLogin()
        {
            Game = new frmGame();
            InitializeComponent();
        }

        /*private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas salir?", "ARKANOID",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    e.Cancel = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha sucedido un error, intente dentro de un minuto!", "ARKANOID",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }


        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }*/

        private void Button1_Click(object sender, EventArgs e)
        {
            var playerNickname = new List<string>();
            try
            {
                var dt = ConectionDB.ExecuteQuery("SELECT nickname FROM PLAYER");
                bool found = false;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString().Equals(textBox1.Text))
                    {
                        found = true;
                        
                        //Hacer que la variable playerName sea igual que el nombre
                        ControlJuego.playerName = textBox1.Text;
                        
                        break;
                    }
                }
                if (!found)
                {
                    ConectionDB.ExecuteNonQuery($"INSERT INTO PLAYER(nickname) VALUES ('{textBox1.Text}')");
                    
                    //Hacer que la variable playerName sea igual que el nombre
                    ControlJuego.playerName = textBox1.Text;
                }
            }
            catch
            {
                MessageBox.Show("ha ocurrido un error");
            }

            
            this.Hide();
            Game.ShowDialog();
            this.Close();
        
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../Resorces/Buttons layaout.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Width = 512;
            pictureBox1.Height = 192;
            pictureBox1.Left = Convert.ToInt32((this.ClientSize.Width / 2) - (pictureBox1.Width / 2));
            pictureBox1.Top = 224;
            pictureBox1.SendToBack();

            btnLogin.Width = 256;
            btnLogin.Height = 64;
            btnLogin.Left = pictureBox1.Left;
            btnLogin.Top = 480;

            label1.Top = 270;
            textBox1.Top = 330;

            btnReturn.Width = 256;
            btnReturn.Height = 64;
            btnReturn.Left = pictureBox1.Right - btnReturn.Width;
            btnReturn.Top = 480;

        }
    }
}