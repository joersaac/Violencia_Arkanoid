﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source_Code
{
    class ControlBall
    {
        //Velocidad horizontal y vertical
        private static int _vSpeed, _hSpeed;

        public static int vSpeed { get; set; }
        public static int hSpeed { get; set; }
        public static bool colisiones(PictureBox ball, Block block)
        {
            //Se observa si hay colisiones con los bloques
            if (ball.Bounds.IntersectsWith(block.Bounds) && block.Visible)
            {
                //se reduce la durabilidad del bloque en 1
                block.hitPoints = block.hitPoints - 1;

                //Si la velocidad horizontal es 0 se le da un valor de manera aleatoria entre -1 y 1
                if (hSpeed != 0)
                {
                    //caso contrario si golpea un lateral solo cambiara de direccion la velocidad
                    //horizontal si golpea arriba o abajo al bloque se cambiara de dirrecion la
                    //velocidad vertical
                    if (block.Left + 2 >= ball.Right || block.Right - 2 <= ball.Left)
                    {
                        hSpeed = -hSpeed;
                    }
                    if (block.Top + 2 >= ball.Bottom || block.Bottom - 2 <= ball.Top)
                    {
                        vSpeed = -vSpeed;
                    }
                }
                else
                {
                    Random ran = new Random();
                    vSpeed = -vSpeed;
                    hSpeed = ran.Next(-1, 2);
                }


                if (block.hitPoints == 0)
                {
                    //Si los hitpoints del bloque llegan a 0 se eliminara el bloque y sumaran los puntos al score
                    block.Visible = false;
                    ControlJuego.score += block.puntos;
                    block = null;
                }
                else
                    //en caso el bloque tenga mas hitpoints se cambiara la imagen del mismo
                    block.imageSetter();
                return true;
            }
            return false;
        }

        public static void ColisionPlat(PictureBox ball, PictureBox platform)
        {
            //Esta funcion es para comprobar la colision con la plataforma 
            if (ball.Bounds.IntersectsWith(platform.Bounds))
            {
                int tird = Convert.ToInt32(platform.Width * 0.33);
                int half = Convert.ToInt32(platform.Width * 0.5);
                //dependiendo de en que parte de la misma choque la pelota hay 5 formas distintas en las
                //que pude rebotar
                if ((ball.Left + (ball.Width / 2)) <= (platform.Left + tird))
                {
                    hSpeed = -2;
                    vSpeed = -1;
                }
                else if ((ball.Left + (ball.Width / 2)) > (platform.Left + tird) &&
                    (ball.Left + (ball.Width / 2)) < (platform.Left + half))
                {
                    hSpeed = -1;
                    vSpeed = -2;
                }
                else if ((ball.Left + (ball.Width / 2)) == (platform.Left + half))
                {
                    hSpeed = 0;
                    vSpeed = -2;
                }
                else if ((ball.Left + (ball.Width / 2)) > (platform.Left + half) &&
                    (ball.Left + (ball.Width / 2)) <= (platform.Left + half + (half - tird)))
                {
                    hSpeed = 1;
                    vSpeed = -2;
                }
                else
                {
                    hSpeed = 2;
                    vSpeed = -1;
                }

            }
        }
    }
}
