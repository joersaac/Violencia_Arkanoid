using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source_Code.Controlador
{
    class WrongClickException : Exception
    {
        public WrongClickException(string message) : base(message) { }
    }
}
