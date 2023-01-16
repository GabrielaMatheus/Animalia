using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais.Generics
{
    public abstract class Reptil : Animal
    {
        public abstract bool TemEscamas { get; set; }
        public abstract bool TemCasco { get; set; }
    }
}
