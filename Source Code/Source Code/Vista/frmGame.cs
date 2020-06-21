using System;
using System.Windows.Forms;

namespace Source_Code
{
    public partial class FrmGame : Form
    {
        private UscGame juego;
        public FrmGame()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            juego = new UscGame();
            juego.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(juego, 1, 0);
            juego.LoadPosicion();
            juego.exit += CloseWindow;
        }
        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(juego);
        }
    }
}
