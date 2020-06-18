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
