using System;
using System.Windows.Forms;
using Source_Code.Controlador;

namespace Source_Code
{
    public partial class uscGame : UserControl
    {
        public delegate void exitEvent(object sender, EventArgs e);
        public exitEvent exit;
        private Block[,] blocks;

        public uscGame()
        {
            InitializeComponent();
            ControlBall.vSpeed = -2;
            ControlBall.hSpeed = 0;
            ControlJuego.vidas = 3;
            ControlJuego.timer = 7000;
            ControlJuego.score = 0;
            ControlJuego.row = 6;
            ControlJuego.col = 7;
            ControlJuego.total = 0;
            ControlJuego.started = false;
            blocks = new Block[ControlJuego.row, ControlJuego.col];
        }

        public void LoadPosicion()
        {
            //se establece la posicion de la plataforma, pelota  y la barra que contendra las estdisticas
            lblMessage.Left = Convert.ToInt32((this.ClientSize.Width / 2)-(lblMessage.Width/2));
            picPlatform.Width = Convert.ToInt32(this.ClientSize.Width/ ControlJuego.col);
            ReloadPosition();
            picLife.Left = 10;
            picLife.Top = 10;
            picStats.Width = this.ClientSize.Width;
            SetBlocks();
            //Label que muestra el nombre del jugador
            lblName.Text = $"NAME: {ControlJuego.playerName}";
        }

        private void SetBlocks()
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
                    blocks[x, y].HitPointsSetter(x);
                    //se establecen las propiedades de la imagen
                    blocks[x, y].Height = blockHeight;
                    blocks[x, y].Width = blockWidth;
                    blocks[x, y].Top = (blockHeight * x) + picStats.Height;
                    blocks[x, y].Left = (blockWidth * y);
                    //se establece la imagen
                    blocks[x, y].ImageSetter();

                    ControlJuego.total += blocks[x, y].Puntos;
                    this.Controls.Add(blocks[x, y]);
                }
            }
        }

        private void ReloadPosition()
        {
            //Se coloca el valor de started en false y se recolocan a la plataforma y la bola
            ControlJuego.started = false;
            picPlatform.Left = Convert.ToInt32((this.ClientSize.Width / 2) - (picPlatform.Width / 2));
            picPlatform.Top = (this.ClientSize.Height - 100);
            picBall.Top = picPlatform.Top - picBall.Height;
            picBall.Left = Convert.ToInt32((this.ClientSize.Width / 2) - (picBall.Width / 2));
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
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
                    throw new OutOfBoundsException("");
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

                if (LevelFinished())
                    exit?.Invoke(this, e);
            }
            catch(OutOfBoundsException ex)
            {
                try
                {
                    LoseLife();
                }
                catch (NoRemainingLivesException exx)
                {
                    ControlBall.vSpeed = 0;
                    ControlBall.hSpeed = 0;
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    ControlJuego.timer = 0;

                    MessageBox.Show(exx.Message, "ARKANOID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    exit?.Invoke(this, e);
                }
            }
        }

        private void UscGame_MouseClick(object sender, MouseEventArgs e)
        {
            //cuando se le de click el juego se habra iniciado
            if (!ControlJuego.started)
            {
                try
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        timer1.Enabled = true;
                        timer2.Enabled = true;
                        ControlJuego.started = true;
                        lblMessage.Visible = false;
                    }
                    else
                        throw new WrongClickException("Apreta click izquierdo para empezar");
                }
                catch (WrongClickException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UscGame_MouseMove(object sender, MouseEventArgs e)
        {
            //la plataforma no se movera hasta que el juego inicie
            if (e.X > picPlatform.Width / 2 && e.X < (this.ClientSize.Width - (picPlatform.Width / 2)) && ControlJuego.started)
                picPlatform.Left = e.X - (picPlatform.Width / 2);
        }

        private bool LevelFinished()
        {
            if (ControlJuego.score == ControlJuego.total)
            {
                //se paran los timers 1 y 2
                timer1.Enabled = false;
                timer2.Enabled = false;

                //se suma la bonificacion de tiempo tanto al puntaje como al puntaje total o maximo y
                //se reinicia el tiempo
                ControlJuego.score += ControlJuego.timer;
                ControlJuego.score += ControlJuego.vidas * 1000;
                lblScore.Text = $"SCORE: {ControlJuego.score}";

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
                return true;
            }

            return false;
        }

        private void Timer2_Tick(object sender, EventArgs e)
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

        private void LoseLife()
        {


            //si la pelorta toca el fondo se resta una vida y la velocidad horizontal se vuelve 0
            ControlBall.hSpeed = 0;
            ControlBall.vSpeed = -2;
            ControlJuego.vidas = ControlJuego.vidas - 1;
            lblLives.Text = $"X {ControlJuego.vidas}";
            //Si ya no se cuentan con vidas el juego termina
            if (ControlJuego.vidas == 0)
            {
                throw new NoRemainingLivesException("YOU LOSE\nGAME OVER");
            }

            //se detienen los timers 1 y 2 y se reinician las posiciones de la plataforma y la pelota
            timer2.Enabled = false;
            timer1.Enabled = false;

            ReloadPosition();
        }
    }
}
