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
    }
}
