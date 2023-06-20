using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersonApp.CustomExcepton
{
    internal class InvalidAgeException : Exception
    {
        public override string Message
        {
            get
            {
                return "Invalid age";
            }
        }
    }
}
