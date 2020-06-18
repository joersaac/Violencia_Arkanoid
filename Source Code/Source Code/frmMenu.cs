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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;

            pictureBox1.Left = Convert.ToInt32(this.ClientSize.Width / 2 - pictureBox1.Width / 2);
            pictureBox1.Top = 104;
            button1.Height = buttonPlay.Height = button2.Height = 64;
            button1.Width = button2.Width = buttonPlay.Width = 320;
            buttonPlay.Left = button2.Left = button1.Left = Convert.ToInt32(this.ClientSize.Width /2 - 161);
            button1.Top = buttonPlay.Top + 96;
            button2.Top = buttonPlay.Top + 192;

        }

        private void ButtonPlay_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            Hide();
            login.Show();
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
            else
            {
                
            }

        }
        
        
        
    }
}
