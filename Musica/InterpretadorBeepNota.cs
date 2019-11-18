using System;
using System.Collections.Generic;
using System.Text;

namespace Musica
{
    public class InterpretadorBeepNota : IInterpretadorNota
    {
        public void InterpretarNota(int frequencia, int tempo)
        {
            Console.Beep(frequencia, tempo);
        }
    }
}
