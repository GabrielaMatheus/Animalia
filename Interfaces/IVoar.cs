using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais.Interfaces
{
    interface IVoar
    {
        int AltitudeMaximaEmMetros { get; set; }
        double VelocidadeDoVoo { get; set; }

        void Voar();
    }
}
