using System;

namespace Source_Code.Controlador
{
    class NoRemainingLivesException: Exception
    {
        public NoRemainingLivesException(string message) : base(message) { }
    }
}
