using System.Runtime.Serialization;

namespace _15_CSharpVersions
{
    [Serializable]
    internal class MyException : Exception
    {
        public MyException()
        {
        }

        public MyException(string? message) : base(message)
        {
        }

        public MyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}