using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais.Generics
{
    public abstract class Mamifero : Animal
    {
        public abstract int QtdMamas { get; set; }
        public abstract bool Pelos { get; set; }
        public abstract string corPelo { get; set; }

        public abstract void Amamentar();

    }
}
