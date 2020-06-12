using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source_Code
{
    public partial class uscGame : UserControl
    {
        private Block[,] blocks;
        public uscGame()
        {
            InitializeComponent();
            ControlBall.vSpeed = -2;
            ControlBall.hSpeed = 0;
            ControlJuego.vidas = 3;
            ControlJuego.level = 1;
            ControlJuego.timer = 6000;
            ControlJuego.score = 0;
            ControlJuego.row = 6;
            ControlJuego.col = 5;
            ControlJuego.total = 0;
            ControlJuego.started = false;
            blocks = new Block[ControlJuego.row, ControlJuego.col];
        }

        private void uscGame_Load(object sender, EventArgs e)
        {
            //se establece la posicion de la plataforma, pelota  y la barra que contendra las estdisticas
            picPlatform.Width = Convert.ToInt32(this.ClientSize.Width/ ControlJuego.col);
            reloadPosition();
            picLife.Left = 10;
            picLife.Top = 10;
            picStats.Width = this.ClientSize.Width;
            setBlocks();
        }

        private void setBlocks()
        {
            //se establece el alto y ancho de llos bloques teniendo como alto el 17% del alto del
            //UserControl y como ancho se divide el ancho del UserControl entre el numero de columnas
            int blockHeight = Convert.ToInt32((this.Height) / 17);
            int blockWidth = Convert.ToInt32((this.Width) / ControlJuego.col);

            for (int x = 0; x < ControlJuego.row; x++)
            {
                for (int y = 0; y < ControlJuego.col; y++)
                {
                    //se inicializa un nuevo Block
                    blocks[x, y] = new Block();
                    //se establecen los hitpoints
                    blocks[x, y].hitPointsSetter(x);
                    //se establecen las propiedades de la imagen
                    blocks[x, y].Height = blockHeight;
                    blocks[x, y].Width = blockWidth;
                    blocks[x, y].Top = (blockHeight * x) + picStats.Height;
                    blocks[x, y].Left = (blockWidth * y);
                    //se establece la imagen
                    blocks[x, y].imageSetter();

                    ControlJuego.total += blocks[x, y].puntos;
                    this.Controls.Add(blocks[x, y]);
                }
            }
        }
        private void reloadPosition()
        {
            //Se coloca el valor de started en false y se recolocan a la plataforma y la bola
            ControlJuego.started = false;
            picPlatform.Left = Convert.ToInt32((this.ClientSize.Width / 2) - (picPlatform.Width / 2));
            picPlatform.Top = (this.ClientSize.Height - 100);
            picBall.Top = picPlatform.Top - picBall.Height;
            picBall.Left = Convert.ToInt32((this.ClientSize.Width / 2) - (picBall.Width / 2));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picBall.Top += ControlBall.vSpeed;
            picBall.Left += ControlBall.hSpeed;

            if (picBall.Bottom > this.ClientSize.Height)
            {
                //si la pelorta toca el fondo se resta una vida y la velocidad horizontal se vuelve 0
                ControlBall.hSpeed = 0;
                ControlJuego.vidas = ControlJuego.vidas - 1;
                lblLives.Text = $"X {ControlJuego.vidas}";
                //Si ya no se cuentan con vidas el juego termina
                if (ControlJuego.vidas == 0)
                {
                    ControlBall.vSpeed = 0;
                    ControlBall.hSpeed = 0;
                    timer1.Enabled = false;
                    //timer2.Enabled = false;
                    ControlJuego.timer = 0;
                    MessageBox.Show($"GAME OVER");
                }

                //se detienen los timers 1 y 2 y se reinician las posiciones de la plataforma y la pelota
                //timer2.Enabled = false;
                timer1.Enabled = false;

                reloadPosition();
            }

            if (picBall.Top < picStats.Height)
            {
                //si la pelota se choca con el limte superior se invertira el valor de velocidad vertical
                ControlBall.vSpeed *= -1;
            }

            if (picBall.Right >= this.ClientSize.Width)
            {
                //Si la pelota se choca con el limte derecho se invertira el valor de velocidad horizontal
                //Ademas para evitar bugs se procurar que la pelota siempre este adentro de los limites
                ControlBall.hSpeed *= -1;
                picBall.Left = this.ClientSize.Width - (picBall.Width + 1);
            }

            if (picBall.Left <= 0)
            {
                //Si la pelota se choca con el limte izquierdo se invertira el valor de velocidad horizontal
                //Ademas para evitar bugs se procurar que la pelota siempre este adentro de los limites
                ControlBall.hSpeed *= -1;
                picBall.Left = 1;
            }

        }
    }
}
