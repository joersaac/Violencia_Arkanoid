using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Source_Code
{
    class Block : PictureBox
    {
        private int _hitPoints;
        private int _puntos;

        public Block()
            : base()
        {
            hitPoints = 1;
            puntos = 10;
        }

        //Setter y getters de hitpoints y puntos
        public int hitPoints { get; set; }

        public int puntos { get; }

        public void hitPointsSetter(int x)
        {
            //Se le van dado los valores de resistencia o hitpoints al bloque dependiendo del nivel y la fila en
            //el que se encuentra bloque
            if (ControlJuego.level == 1)
                hitPoints = 1;
            else if (ControlJuego.level == 2)
            {
                if (x == 0 || x == 1)
                    hitPoints = 2;
                else
                    hitPoints = 1;
            }
            else if (ControlJuego.level == 3)
            {
                if (x == 0 || x == 1)
                    hitPoints = 3;
                else if (x == 2 || x == 3)
                    hitPoints = 2;
                else
                    hitPoints = 1;
            }
            else if (ControlJuego.level == 4)
            {
                if (x == 0 || x == 1)
                    hitPoints = 3;
                else
                    hitPoints = 2;
            }
            else
                hitPoints = 3;
            //Dependiendo de sus hitpoints se establece los puntos que dara al destruirlo
            if (_hitPoints == 3)
                _puntos = 50;
            else if (_hitPoints == 2)
                _puntos = 30;
            else
                _puntos = 10;
        }

        public void imageSetter()
        {
            //Se establece la imagen que usara el bloque depedendiendo de sus hitpoints
            if (hitPoints == 1)
            {
                this.Image = Image.FromFile("../../Resorces/Block 1.png");
                this.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (hitPoints == 2)
            {
                this.Image = Image.FromFile("../../Resorces/Block 2.png");
                this.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (hitPoints == 3)
            {
                this.Image = Image.FromFile("../../Resorces/Block 3.png");
                this.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
