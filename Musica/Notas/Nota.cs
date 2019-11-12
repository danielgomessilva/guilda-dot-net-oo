using System;
using System.Collections.Generic;
using System.Text;

namespace Musica.Notas
{
    public class Nota : INota
    {
        public Nota(int oitava, INota nota, Tempo tempo)
        {
            Frequencia = nota.Frequencia;
            for (int i = 2; i <= oitava; i++)
                Frequencia = Frequencia * 2;

            Tempo = tempo;
        }
        public int Frequencia { get; private set; }
        public Tempo Tempo { get; private set; }
    }
}
