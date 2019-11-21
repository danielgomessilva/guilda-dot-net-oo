using Musica.Utils;
using System;
using System.Collections.Generic;

namespace Musica.LeitorNotas
{
    public interface ILeitorNota : IDisposable
    {
        (string nota, int oitava, TempoEnum tempo) LerNota();

        void LerNota(out string nota, out int oitava, out TempoEnum tempo);

        List<Tuple<string, int, TempoEnum>> LerNotas();
    }
}
