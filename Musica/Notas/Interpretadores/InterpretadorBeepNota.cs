using System;

namespace Musica.Notas.Interpretadores
{
    public class InterpretadorBeepNota : IInterpretadorNota
    {
        public void InterpretarNota(int frequencia, int tempo)
        {
            Console.Beep(frequencia, tempo);
        }
    }
}
