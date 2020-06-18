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

        public void Load()
        {
            //se establece la posicion de la plataforma, pelota  y la barra que contendra las estdisticas
            picPlatform.Width = Convert.ToInt32(this.ClientSize.Width/ ControlJuego.col);
            reloadPosition();
            picLife.Left = 10;
            picLife.Top = 10;
            picStats.Width = this.ClientSize.Width;
            setBlocks();
            //Label que muestra el nombre del jugador
            lblName.Text = $"NAME: {ControlJuego.playerName}";
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
            for (int x = 0; x < ControlJuego.row; x++)
            {
                bool colision = false;
                for (int y = 0; y < ControlJuego.col; y++)
                {
                    if (ControlBall.colisiones(picBall, blocks[x, y]))
                    {
                        lblScore.Text = $"SCORE: {ControlJuego.score}";
                        colision = true;
                        break;
                    }
                }
                if (colision)
                    break;
            }

            //Se mueve a la pelota sumando su posicion Top con la velocidad vertival y su posicion Left con la velocidad horizontal 
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
                    timer2.Enabled = false;
                    ControlJuego.timer = 0;
                    
                    //Se manda el puntaje del jugador a la base de datos
                    try
                    {
                      ConectionDB.ExecuteNonQuery($"INSERT INTO PUNTAJE(puntaje, nickname) VALUES ('{(ControlJuego.score)}', '{ControlJuego.playerName}')");
                    }
                    catch
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }
                    
                    MessageBox.Show($"GAME OVER", "ARKANOID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //se detienen los timers 1 y 2 y se reinician las posiciones de la plataforma y la pelota
                timer2.Enabled = false;
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

            //Se miran las colisiones con la plataforma/jugador
            ControlBall.ColisionPlat(picBall, picPlatform);

            LevelFinished();
        }

        private void uscGame_MouseClick(object sender, MouseEventArgs e)
        {
            //cuando se le de click el juego se habra iniciado
            timer1.Enabled = true;
            timer2.Enabled = true;
            ControlJuego.started = true;
            lblMessage.Visible = false;
        }

        private void uscGame_MouseMove(object sender, MouseEventArgs e)
        {
            //la plataforma no se movera hasta que el juego inicie
            if (e.X > picPlatform.Width / 2 && e.X < (this.ClientSize.Width - (picPlatform.Width / 2)) && ControlJuego.started)
                picPlatform.Left = e.X - (picPlatform.Width / 2);
        }

        private void LevelFinished()
        {
            if (ControlJuego.score == ControlJuego.total)
            {
                //se paran los timers 1 y 2 y se reinician las pocisiones de la plataforma y la pelota
                timer1.Enabled = false;
                timer2.Enabled = false;
                reloadPosition();
                lblMessage.Visible = true;

                //se aumenta el nivel 
                ControlJuego.level++;
                lblLevel.Text = $"LEVEL {ControlJuego.level}";

                //se suma la bonificacion de tiempo tanto al puntaje como al puntaje total o maximo y
                //se reinicia el tiempo
                ControlJuego.score += Convert.ToInt32(ControlJuego.timer / 10);
                lblScore.Text = $"SCORE: {ControlJuego.score}";
                ControlJuego.total += Convert.ToInt32(ControlJuego.timer / 10);
                ControlJuego.timer = 6000;
                lblTime.Text = $"TIME: {ControlJuego.timer}";

                //Se coloca la velocidad horizontal en 0 y la vertical en -2 y se reinician las posiciones de
                //la plataforma y la pelota
                ControlBall.vSpeed = -2;
                ControlBall.hSpeed = 0;
                reloadPosition();

                //Se comprueban las condiciones aumento de dificultas y se vuelven a crear los bloques para el
                //siguiente nivel
                aumentoDeDificultad();
                setBlocks();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //se lleva el control del tiempo
            //el tiempo solo sera bonificacion por lo que si se acaba solo no se obtendra bonificacion
            if (ControlJuego.timer == 0)
                timer2.Stop();
            else
            {
                ControlJuego.timer--;
                lblTime.Text = $"TIME: {ControlJuego.timer}";
            }
        }

        private void aumentoDeDificultad()
        {
            //Esta funcion lleva control de la dificultad conforme avanzan los niveles
            //se reduce la plataforma en un 15% por cada aumento de dificultad
            if (ControlJuego.level == 3)
                picPlatform.Width = Convert.ToInt32(picPlatform.Width - (picPlatform.Width * 0.15));
            else if (ControlJuego.level == 5)
                picPlatform.Width = Convert.ToInt32(picPlatform.Width - (picPlatform.Width * 0.15));
            else if (ControlJuego.level == 7)
                picPlatform.Width = Convert.ToInt32(picPlatform.Width - (picPlatform.Width * 0.15));
            else if (ControlJuego.level == 9)
                picPlatform.Width = Convert.ToInt32(picPlatform.Width - (picPlatform.Width * 0.15));
            else if (ControlJuego.level == 11)
                picPlatform.Width = Convert.ToInt32(picPlatform.Width - (picPlatform.Width * 0.15));
        }
    }
}
