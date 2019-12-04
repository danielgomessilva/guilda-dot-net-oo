using Musica.Notas;
using Musica.Utils;

namespace Musica.NotaPartituras
{
   internal interface INotaPartitura
    {
        INota Nota { get; set; }
        TempoEnum Tempo { get; set; }
        int Oitava { get; set; }

        void TocarNotaPartitura(int velocidade);
    }
}
