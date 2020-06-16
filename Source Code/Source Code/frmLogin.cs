﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Source_Code
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas salir?", "ARKANOID",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    e.Cancel = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha sucedido un error, intente dentro de un minuto!", "ARKANOID",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }


        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var playerNickname = new List<string>();
            try
            {
                var dt = ConectionDB.ExecuteQuery("SELECT nickname FROM PLAYER");
                bool found = false;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString().Equals(textBox1.Text))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {

                    ConectionDB.ExecuteNonQuery($"INSERT INTO PLAYER(nickname) VALUES ('{textBox1.Text}')");
                }
            }
            catch
            {
                MessageBox.Show("ha ocurrido un error");
            }

            frmGame Game = new frmGame();
            Hide();
            Game.Show();
        
        }
    }
}