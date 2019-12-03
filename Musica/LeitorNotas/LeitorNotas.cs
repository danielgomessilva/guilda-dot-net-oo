using Microsoft.Win32.SafeHandles;
using Musica.Utils;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Musica.LeitorNotas
{
    public class LeitorNota : ILeitorNota
    {
        readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        bool disposed = false;

        public (string nota, int oitava, TempoEnum tempo) LerNota()
        {
            return ("sol", 4, TempoEnum.Semibreve);
        }

        public void LerNota(out string nota, out int oitava, out TempoEnum tempo)
        {
            nota = "sol";
            oitava = 4;
            tempo = TempoEnum.Semibreve;
        }

        public List<Tuple<string, int, TempoEnum>> LerNotas()
        {
            var notas = DarthVader();
            notas.AddRange(BrilhaEstrelinha());

            return notas;
        }

        private List<Tuple<string, int, TempoEnum>> DarthVader()
        {
            var notas = new List<Tuple<string, int, TempoEnum>>();

            notas.Add(new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("fa", 4, TempoEnum.Colcheia));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Semicocheia));
            notas.Add(new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("fa", 4, TempoEnum.Colcheia));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Semicocheia));
            notas.Add(new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Minima));
            notas.Add(new Tuple<string, int, TempoEnum>("mi", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("mi", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("mi", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("fa", 5, TempoEnum.Colcheia));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Semicocheia));
            notas.Add(new Tuple<string, int, TempoEnum>("solSus", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("fa", 4, TempoEnum.Colcheia));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Semicocheia));
            notas.Add(new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Semibreve));

            return notas;
        }

        private List<Tuple<string, int, TempoEnum>> BrilhaEstrelinha()
        {
            var notas = new List<Tuple<string, int, TempoEnum>>();

            notas.Add(new Tuple<string, int, TempoEnum>("sol", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("sol", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("re", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("re", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("mi", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("mi", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("re", 5, TempoEnum.Minima));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("si", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("si", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Minima));
            notas.Add(new Tuple<string, int, TempoEnum>("sol", 4, TempoEnum.Minima));

            notas.Add(new Tuple<string, int, TempoEnum>("re", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("re", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("si", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("si", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Minima));
            notas.Add(new Tuple<string, int, TempoEnum>("re", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("re", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("si", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("si", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Minima));

            notas.Add(new Tuple<string, int, TempoEnum>("sol", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("sol", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("re", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("re", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("mi", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("mi", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("re", 5, TempoEnum.Minima));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("do", 5, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("si", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("si", 4, TempoEnum.Seminima));
            notas.Add(new Tuple<string, int, TempoEnum>("la", 4, TempoEnum.Minima));
            notas.Add(new Tuple<string, int, TempoEnum>("sol", 4, TempoEnum.Minima));

            return notas;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                Console.WriteLine("Dispose Leitor Nota");
            }

            disposed = true;
        }

        ~LeitorNota()
        {
            Dispose(false);
            Console.WriteLine("Destructor Leitor Nota");
        }
    }
}
