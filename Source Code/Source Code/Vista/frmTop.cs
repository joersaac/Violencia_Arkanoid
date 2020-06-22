using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Source_Code
{
    public partial class FrmTop : Form
    {

        private Label[,] players;
        private FrmMenu Menu;
        public FrmTop()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FrmTop_Load(object sender, EventArgs e)
        {
            //Variable que contendra al sonido
            SoundPlayer sonido;
            //Agregar el sonido que queremos reproducir
            sonido = new SoundPlayer("../../Resorces/Top.wav");
            //Reproducir el sonido
            sonido.Play();
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;

            players = new Label[11, 2];

            lblTop.Left = this.ClientSize.Width / 2 - lblTop.Width / 2;

            LoadPlayers();
        }

        private void LoadPlayers()
        {
            try
            {
                var playerList = TopController.Top();

                int SampleTop = lblTop.Bottom + 65,
                    SampleLeft = this.ClientSize.Width / 2;

                for (int i = 0; i < playerList.Count+1; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        players[i, j] = new Label();

                        switch (j)
                        {
                            case 0:
                                switch (i) {
                                    case 0:
                                        players[i, j].Text = "PLAYERS:";
                                        players[i, j].ForeColor = Color.PaleGreen;
                                        break;
                                    default:
                                        players[i, j].Text = playerList[i-1].Nickname;
                                        players[i, j].ForeColor = lblTop.ForeColor;
                                        break;
                                }
                                players[i, j].Left = SampleLeft - 300;
                                break;
                            default:
                                switch (i)
                                {
                                    case 0:
                                        players[i, j].Text = "SCORE:";
                                        players[i, j].ForeColor = Color.PaleGreen;
                                        break;
                                    default:
                                        players[i, j].Text = playerList[i-1].Score.ToString();
                                        players[i, j].ForeColor = lblTop.ForeColor;
                                        break;
                                }
                                players[i, j].Left = SampleLeft + 100;
                                break;
                        }

                        players[i, j].Top = SampleTop + (SampleTop / 3) * i;
                        players[i, j].BackColor = Color.Transparent;
                        //players[i, j].Dock = DockStyle.None;
                        players[i, j].AutoSize = true;
                        players[i, j].Height += 3;
                        players[i, j].Font = lblTop.Font;
                        players[i, j].TextAlign = ContentAlignment.MiddleCenter;

                        Controls.Add(players[i, j]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void FrmTop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            var playerList = TopController.Top();

            for (int i = 0; i < playerList.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Controls.Remove(players[i, j]);
                    players[i, j]=null;
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //Regresar a la pantalla del menú
            Menu = new FrmMenu();
            this.Close();
            Menu.ShowDialog();
        }
    }
    
}