using Musica.Partituras;
using Musica.Utils;

namespace Musica
{
    public class Program
    {
        static void Main(string[] args)
        {
            var partitura = new Partitura()
                .SetNota("sol", 4, TempoEnum.Seminima)
                .SetNota("sol", 4, TempoEnum.Seminima)
                .SetNota("re", 5, TempoEnum.Seminima)
                .SetNota("re", 5, TempoEnum.Seminima)
                .SetNota("mi", 5, TempoEnum.Seminima)
                .SetNota("mi", 5, TempoEnum.Seminima)
                .SetNota("re", 5, TempoEnum.Minima)
                .SetNota("do", 5, TempoEnum.Seminima)
                .SetNota("do", 5, TempoEnum.Seminima)
                .SetNota("si", 4, TempoEnum.Seminima)
                .SetNota("si", 4, TempoEnum.Seminima)
                .SetNota("la", 4, TempoEnum.Minima)
                .SetNota("sol", 4, TempoEnum.Minima)

                .SetNota("re", 5, TempoEnum.Seminima)
                .SetNota("re", 5, TempoEnum.Seminima)
                .SetNota("do", 5, TempoEnum.Seminima)
                .SetNota("do", 5, TempoEnum.Seminima)
                .SetNota("si", 4, TempoEnum.Seminima)
                .SetNota("si", 4, TempoEnum.Seminima)
                .SetNota("la", 4, TempoEnum.Minima)
                .SetNota("re", 5, TempoEnum.Seminima)
                .SetNota("re", 5, TempoEnum.Seminima)
                .SetNota("do", 5, TempoEnum.Seminima)
                .SetNota("do", 5, TempoEnum.Seminima)
                .SetNota("si", 4, TempoEnum.Seminima)
                .SetNota("si", 4, TempoEnum.Seminima)
                .SetNota("la", 4, TempoEnum.Minima)

                .SetNota("sol", 4, TempoEnum.Seminima)
                .SetNota("sol", 4, TempoEnum.Seminima)
                .SetNota("re", 5, TempoEnum.Seminima)
                .SetNota("re", 5, TempoEnum.Seminima)
                .SetNota("mi", 5, TempoEnum.Seminima)
                .SetNota("mi", 5, TempoEnum.Seminima)
                .SetNota("re", 5, TempoEnum.Minima)
                .SetNota("do", 5, TempoEnum.Seminima)
                .SetNota("do", 5, TempoEnum.Seminima)
                .SetNota("si", 4, TempoEnum.Seminima)
                .SetNota("si", 4, TempoEnum.Seminima)
                .SetNota("la", 4, TempoEnum.Minima)
                .SetNota("sol", 4, TempoEnum.Minima);


            partitura.Play(2);
        }
    }
}
