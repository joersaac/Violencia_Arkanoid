using System;

namespace Source_Code.Controlador
{
    public class EmptyNicknameException : Exception
    {
        public EmptyNicknameException(string Message) : base(Message) { }   
    }
}