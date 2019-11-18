using System;
using System.Collections.Generic;
using System.Text;

namespace Musica
{
    public interface IInterpretadorNota
    {
        void InterpretarNota(int frequencia, int tempo);
    }
}
