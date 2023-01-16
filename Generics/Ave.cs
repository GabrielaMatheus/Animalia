using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais.Generics
{
    public abstract class Ave : Animal
    {
        public abstract bool Rapina { get; set; }
        public abstract bool CorPena { get; set; }

        public abstract void Ciscar();

        


    }
}
