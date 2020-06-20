using System.Windows.Forms;
using System.Drawing;

namespace Source_Code
{
    class Block : PictureBox
    {
        public Block()
            : base()
        {
            HitPoints = 1;
            Puntos = 10;
        }

        //Setter y getters de hitpoints y puntos
        public int HitPoints { get; set; }

        public int Puntos { get; set; }

        public void HitPointsSetter(int x)
        {
            //Se le van dado los valores de resistencia o hitpoints al bloque dependiendo  en 
            //la posicion en el que se encuentra bloque
            switch (x)
            {
                case 0:
                case 1:
                    HitPoints = 3;
                    Puntos = 50;
                    break;
                case 2:
                case 3:
                    HitPoints = 2;
                    Puntos = 30;
                    break;
                default:
                    HitPoints = 1;
                    Puntos = 10;
                    break;
            }
        }

        public void ImageSetter()
        {
            //Se establece la imagen que usara el bloque depedendiendo de sus hitpoints
            if (HitPoints == 1)
            {
                this.Image = Image.FromFile("../../Resorces/Block 1.png");
                this.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (HitPoints == 2)
            {
                this.Image = Image.FromFile("../../Resorces/Block 2.png");
                this.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (HitPoints == 3)
            {
                this.Image = Image.FromFile("../../Resorces/Block 3.png");
                this.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
