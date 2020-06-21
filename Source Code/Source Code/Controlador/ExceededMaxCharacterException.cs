using System;

namespace Source_Code.Controlador
{
    public class ExceededMaxCharactersException : Exception
    {
        public ExceededMaxCharactersException(string Message) : base(Message) {}
    }
}