using Musica.Utils;
using System;
using System.Collections.Generic;

namespace Musica
{
    public interface ILeitorSerialNotas : IDisposable
    {
        (string nota, string oitava, TempoEnum tempo) LerNota();

        void LerNota(out string nota, out int oitava, out TempoEnum tempo);

        List<Tuple<string, string, TempoEnum>> LerNotas();
    }
}
