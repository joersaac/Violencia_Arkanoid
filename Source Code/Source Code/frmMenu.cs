using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Source_Code
{
    public partial class frmMenu : Form
    {
        private frmLogin login;
        private frmTop top;
        public frmMenu()
        {
            login = new frmLogin();
            top = new frmTop();
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;

            pictureBox1.Left = Convert.ToInt32(this.ClientSize.Width / 2 - pictureBox1.Width / 2);
            pictureBox1.Top = 104;
            btnTop.Height = buttonPlay.Height = button2.Height = 64;
            btnTop.Width = button2.Width = buttonPlay.Width = 320;
            buttonPlay.Left = button2.Left = btnTop.Left = Convert.ToInt32(this.ClientSize.Width /2 - 161);
            btnTop.Top = buttonPlay.Top + 96;
            button2.Top = buttonPlay.Top + 192;

        }

        private void ButtonPlay_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas salir ?", "ARKANOID",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Cerrando..." + "\nHASTA PRONTO!", "ARKANOID", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Application.Exit();
               
            }
        }


        private void btnTop_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana del top jugadores
            Hide();
            top.ShowDialog();
            Show();
        }
    }
}
