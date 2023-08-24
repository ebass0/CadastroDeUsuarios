using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Exceptions
{
    [Serializable]
    public class AppExceptions : Exception
    {
        public AppExceptions() { }
        public AppExceptions(string message) : base($"Aconteu uma exceção -> {message}") { }
        public AppExceptions(string message, Exception inner) : base(message, inner) { }
        protected AppExceptions(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
