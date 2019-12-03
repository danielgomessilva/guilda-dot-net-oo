using Musica.Utils;

namespace Musica.Notas
{
    internal interface INota
    {
        string Nome { get; }
        void TocarNota(int velocidade, TempoEnum tempo, int oitava);
        void TocarNota(int velocidade, TempoEnum tempo);
    }
}
