using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source_Code
{
    public partial class frmGame : Form
    {
        private uscGame juego;
        public frmGame()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            juego = new uscGame();
            juego.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(juego, 1, 0);
            juego.LoadPosicion();
            juego.exit += closeWindow;
        }
        private void closeWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(juego);
        }
    }
}
