using Musica.Utils;
using System;
using System.Collections.Generic;

namespace Musica
{
    namespace LeitorNotas
    {
        internal static class MusicaHelper
        {
            internal static List<Tuple<string, int, TempoEnum>> GetDarthVaderMusica()
            {

                var notas = new List<Tuple<string, int, TempoEnum>>
            {
                new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Seminima),
                Tuple.Create("la", 4, TempoEnum.Seminima),
                Tuple.Create("la", 4, TempoEnum.Seminima),
                Tuple.Create("fa", 4, TempoEnum.Colcheia),
                Tuple.Create("do", 5, TempoEnum.Semicocheia),
                Tuple.Create("la", 4, TempoEnum.Seminima),
                Tuple.Create("fa", 4, TempoEnum.Colcheia),
                Tuple.Create("do", 5, TempoEnum.Semicocheia),
                Tuple.Create("la", 4, TempoEnum.Minima),
                Tuple.Create("mi", 5, TempoEnum.Seminima),
                Tuple.Create("mi", 5, TempoEnum.Seminima),
                Tuple.Create("mi", 5, TempoEnum.Seminima),
                Tuple.Create("fa", 5, TempoEnum.Colcheia),
                Tuple.Create("do", 5, TempoEnum.Semicocheia),
                Tuple.Create("solSus", 4, TempoEnum.Seminima),
                Tuple.Create("fa", 4, TempoEnum.Colcheia),
                Tuple.Create("do", 5, TempoEnum.Semicocheia),
                Tuple.Create("la", 4, TempoEnum.Semibreve)
            };

                return notas;

            }

            internal static void AddBrilhaBrilhaEstrelinhaMusica(this List<Tuple<string, int, TempoEnum>> notas)
            {
                var notasMusica = new List<Tuple<string, int, TempoEnum>>
            {
                Tuple.Create("sol", 4, TempoEnum.Seminima),
                Tuple.Create("sol", 4, TempoEnum.Seminima),
                Tuple.Create("re", 5, TempoEnum.Seminima),
                Tuple.Create("re", 5, TempoEnum.Seminima),
                Tuple.Create("mi", 5, TempoEnum.Seminima),
                Tuple.Create("mi", 5, TempoEnum.Seminima),
                Tuple.Create("re", 5, TempoEnum.Minima),
                Tuple.Create("do", 5, TempoEnum.Seminima),
                Tuple.Create("do", 5, TempoEnum.Seminima),
                Tuple.Create("si", 4, TempoEnum.Seminima),
                Tuple.Create("si", 4, TempoEnum.Seminima),
                Tuple.Create("la", 4, TempoEnum.Minima),
                Tuple.Create("sol", 4, TempoEnum.Minima),

                Tuple.Create("re", 5, TempoEnum.Seminima),
                Tuple.Create("re", 5, TempoEnum.Seminima),
                Tuple.Create("do", 5, TempoEnum.Seminima),
                Tuple.Create("do", 5, TempoEnum.Seminima),
                Tuple.Create("si", 4, TempoEnum.Seminima),
                Tuple.Create("si", 4, TempoEnum.Seminima),
                Tuple.Create("la", 4, TempoEnum.Minima),
                Tuple.Create("re", 5, TempoEnum.Seminima),
                Tuple.Create("re", 5, TempoEnum.Seminima),
                Tuple.Create("do", 5, TempoEnum.Seminima),
                Tuple.Create("do", 5, TempoEnum.Seminima),
                Tuple.Create("si", 4, TempoEnum.Seminima),
                Tuple.Create("si", 4, TempoEnum.Seminima),
                Tuple.Create("la", 4, TempoEnum.Minima),

                Tuple.Create("sol", 4, TempoEnum.Seminima),
                Tuple.Create("sol", 4, TempoEnum.Seminima),
                Tuple.Create("re", 5, TempoEnum.Seminima),
                Tuple.Create("re", 5, TempoEnum.Seminima),
                Tuple.Create("mi", 5, TempoEnum.Seminima),
                Tuple.Create("mi", 5, TempoEnum.Seminima),
                Tuple.Create("re", 5, TempoEnum.Minima),
                Tuple.Create("do", 5, TempoEnum.Seminima),
                Tuple.Create("do", 5, TempoEnum.Seminima),
                Tuple.Create("si", 4, TempoEnum.Seminima),
                Tuple.Create("si", 4, TempoEnum.Seminima),
                Tuple.Create("la", 4, TempoEnum.Minima),
                Tuple.Create("sol", 4, TempoEnum.Minima)
            };

                notas.AddRange(notasMusica);
            }
        }
    }
}
