using System;
using System.Drawing;
using System.Windows.Forms;

namespace Source_Code
{
    public partial class FrmTop : Form
    {

        private Label[,] players;
        public FrmTop()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FrmTop_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;

            players = new Label[10, 2];

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

                for (int i = 0; i < playerList.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        players[i, j] = new Label();

                        if (j == 0)
                        {
                            players[i, j].Text = playerList[i].Nickname;
                            players[i, j].Left = SampleLeft - 300;
                        }
                        else
                        {
                            players[i, j].Text = playerList[i].Score.ToString();
                            players[i, j].Left = SampleLeft +100;
                        }
                        players[i, j].Top = SampleTop + (SampleTop / 3) * i;
                        players[i, j].BackColor = Color.Transparent;
                        //players[i, j].Dock = DockStyle.None;
                        players[i, j].AutoSize = true;
                        players[i, j].Height += 3;
                        players[i, j].Font = lblTop.Font;
                        players[i, j].ForeColor = lblTop.ForeColor;
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
    }
    
}