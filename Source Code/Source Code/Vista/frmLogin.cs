using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using Source_Code.Controlador;
using System.Media;

namespace Source_Code
{
    public partial class FrmLogin : Form
    {
        private FrmGame Game = new FrmGame();
        public FrmLogin()
        {
            Game = new FrmGame();
            InitializeComponent(); 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var playerNickname = new List<string>();
            try
            {
                switch (txtLogin.Text)
                {
                    case string aux when aux.Trim().Length == 0:
                        throw new EmptyNicknameException("no puede dejar el campo vacio");
                    case string aux when aux.Length > 15:
                        throw new ExceededMaxCharactersException("no puede poner un nickname de mas de 15 chars");
                    default:
                        var dt = ConectionDB.ExecuteQuery("SELECT nickname FROM PLAYER");
                        bool found = false;
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr[0].ToString().Equals(txtLogin.Text))
                            {
                                found = true;

                                //Hacer que la variable playerName sea igual que el nombre
                                ControlJuego.playerName = txtLogin.Text;

                                break;
                            }
                        }

                        if (!found)
                        {
                            ConectionDB.ExecuteNonQuery($"INSERT INTO PLAYER(nickname) VALUES ('{txtLogin.Text}')");

                            //Hacer que la variable playerName sea igual que el nombre
                            ControlJuego.playerName = txtLogin.Text;
                        }

                        this.Hide();
                        Game.ShowDialog();
                        this.Close();
                        break;
                }
            }
            catch (EmptyNicknameException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExceededMaxCharactersException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Variable que contendra al sonido
            SoundPlayer sonido;
            //Agregar el sonido que queremos reproducir
            sonido = new SoundPlayer("../../Resorces/Start.wav");
            //Reproducir el sonido
            sonido.Play();
            
            picLogin.Image = Image.FromFile("../../Resorces/Buttons layaout.png");
            picLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogin.Width = 512;
            picLogin.Height = 192;
            picLogin.Left = Convert.ToInt32((this.ClientSize.Width / 2) - (picLogin.Width / 2));
            picLogin.Top = 224;
            picLogin.SendToBack();

            btnLogin.Width = 256;
            btnLogin.Height = 64;
            btnLogin.Left = picLogin.Left;
            btnLogin.Top = 480;

            label1.Top = 270;
            txtLogin.Top = 330;

            btnReturn.Width = 256;
            btnReturn.Height = 64;
            btnReturn.Left = picLogin.Right - btnReturn.Width;
            btnReturn.Top = 480;

        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}