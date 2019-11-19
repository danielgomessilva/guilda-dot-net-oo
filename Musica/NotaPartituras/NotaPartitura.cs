using Musica.Notas;
using Musica.Utils;

namespace Musica.NotaPartituras
{
    public class NotaPartitura : INotaPartitura
    {
        public TempoEnum Tempo { get; set; }
        public int Oitava { get; set; }
        public INota Nota { get; set; }

        public void TocarNotaPartitura(int velocidade)
        {
            if (Oitava == 0)
                Nota.TocarNota(velocidade, Tempo);
            else
                Nota.TocarNota(velocidade, Tempo, Oitava);
        }
    }
}
