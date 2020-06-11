using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public int hitPoints { get; set; }

        public int puntos { get; set; }
    }
}
