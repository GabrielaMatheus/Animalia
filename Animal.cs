using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais
{
    public abstract class Animal
    {
        public abstract string Nome { get; set; }
        public abstract DateTime DataNascimento { get; set; }
        public abstract Char Sexo { get; set; }
        public abstract int Idade { get; set; }
        public abstract bool Carnivoro { get; set; }
        public abstract bool Peconhento { get; set; }

        public abstract void Movimentar();
       
        public abstract void Comunicar();

        public abstract void Alimentar();

      


    }
}
