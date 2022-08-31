using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter.Exceptions
{
    class StoneHitException : Exception
    {
        public StoneHitException()
        {
        }

        public StoneHitException(string message)
            : base(message)
        {
        }

        public StoneHitException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
