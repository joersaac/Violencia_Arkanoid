using System;
using System.Drawing;
using System.Windows.Forms;

namespace Source_Code
{
    public partial class frmTop : Form
    {

        private Label[,] players;
        public frmTop()
        {
            InitializeComponent();
        }

        private void frmTop_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            var playerList = TopController.Top();
            players = new Label[10,2];

            int SampleTop = lblTop.Bottom + 25, SampleLeft = 65;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    players[i,j] = new Label();

                    if (j == 0){
                        players[i, j].Text = playerList[i].Nickname;
                        players[i, j].Left = SampleLeft;
                    }
                    else{
                        players[i, j].Text = playerList[i].Score.ToString();
                        players[i, j].Left = Width / 2 + SampleLeft;
                    }

                    players[i, j].Top = SampleTop + (SampleTop/2) * i;                    
                    players[i,j].BackColor = Color.Transparent;                    
                    players[i,j].Dock = DockStyle.None;
                    players[i, j].AutoSize = true;
                    players[i, j].Height += 5;                    
                    players[i, j].Font = lblTop.Font;
                    players[i,j].ForeColor = lblTop.ForeColor;
                    players[i,j].TextAlign = ContentAlignment.MiddleCenter;
                    
                    Controls.Add(players[i, j]);

                }
            }
            
        }
        
        
    }
}