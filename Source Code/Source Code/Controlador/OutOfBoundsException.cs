using System;

namespace Source_Code.Controlador
{
    class OutOfBoundsException: Exception
    {
        public OutOfBoundsException(string message) : base(message) { }
    }
}
