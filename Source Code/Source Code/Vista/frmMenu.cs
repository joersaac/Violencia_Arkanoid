﻿using System;
using System.Windows.Forms;

namespace Source_Code
{
    public partial class FrmMenu : Form
    {
        private FrmLogin login;
        private FrmTop top;

        public FrmMenu()
        {
            login = new FrmLogin();
            top = new FrmTop();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;

            pictureBox1.Left = Convert.ToInt32(this.ClientSize.Width / 2 - pictureBox1.Width / 2);
            pictureBox1.Top = 104;
            btnTop.Height = btnPlay.Height = btnExit.Height = 64;
            btnTop.Width = btnExit.Width = btnPlay.Width = 320;
            btnPlay.Left = btnExit.Left = btnTop.Left = Convert.ToInt32(this.ClientSize.Width /2 - 161);
            btnTop.Top = btnPlay.Top + 96;
            btnExit.Top = btnPlay.Top + 192;

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas salir ?", "ARKANOID",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Cerrando..." + "\nHASTA PRONTO!", "ARKANOID", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Application.Exit();
               
            }
        }


        private void BtnTop_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana del top jugadores
            Hide();
            top.ShowDialog();
            Show();
        }
    }
}
