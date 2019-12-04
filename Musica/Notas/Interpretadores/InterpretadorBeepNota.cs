using System;

namespace Musica.Notas.Interpretadores
{
    public class InterpretadorBeepNota : IInterpretadorNota
    {
        private const int TempoPadrao =2000;
        public void InterpretarNota(int frequencia, int tempo)
        {
            Console.Beep(frequencia, tempo);
        }

        public void InterpretarNota(int frequencia)
        {
            Console.Beep(frequencia,TempoPadrao);
        }
    }
}
