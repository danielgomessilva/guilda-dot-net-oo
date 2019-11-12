using Musica.Notas;
using System;

namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            new Partitura()
                .SetNota("Sol", 4, Tempo.Seminima)
                .SetNota("Sol", 4, Tempo.Seminima)
                .SetNota("Re", 5, Tempo.Seminima)
                .SetNota("Re", 5, Tempo.Seminima)
                .SetNota("Mi", 5, Tempo.Seminima)
                .SetNota("Mi", 5, Tempo.Seminima)
                .SetNota("Re", 5, Tempo.Minima)
                .SetNota("Do", 5, Tempo.Seminima)
                .SetNota("Do", 5, Tempo.Seminima)
                .SetNota("Si", 4, Tempo.Seminima)
                .SetNota("Si", 4, Tempo.Seminima)
                .SetNota("La", 4, Tempo.Minima)
                .SetNota("Sol", 4, Tempo.Minima)

                .SetNota("Re", 5, Tempo.Seminima)
                .SetNota("Re", 5, Tempo.Seminima)
                .SetNota("Do", 5, Tempo.Seminima)
                .SetNota("Do", 5, Tempo.Seminima)
                .SetNota("Si", 4, Tempo.Seminima)
                .SetNota("Si", 4, Tempo.Seminima)
                .SetNota("La", 4, Tempo.Minima)
                .SetNota("Re", 5, Tempo.Seminima)
                .SetNota("Re", 5, Tempo.Seminima)
                .SetNota("Do", 5, Tempo.Seminima)
                .SetNota("Do", 5, Tempo.Seminima)
                .SetNota("Si", 4, Tempo.Seminima)
                .SetNota("Si", 4, Tempo.Seminima)
                .SetNota("La", 4, Tempo.Minima)

                .SetNota("Sol", 4, Tempo.Seminima)
                .SetNota("Sol", 4, Tempo.Seminima)
                .SetNota("Re", 5, Tempo.Seminima)
                .SetNota("Re", 5, Tempo.Seminima)
                .SetNota("Mi", 5, Tempo.Seminima)
                .SetNota("Mi", 5, Tempo.Seminima)
                .SetNota("Re", 5, Tempo.Minima)
                .SetNota("Do", 5, Tempo.Seminima)
                .SetNota("Do", 5, Tempo.Seminima)
                .SetNota("Si", 4, Tempo.Seminima)
                .SetNota("Si", 4, Tempo.Seminima)
                .SetNota("La", 4, Tempo.Minima)
                .SetNota("Sol", 4, Tempo.Minima)

                .Play(2);
        }
    }
}
