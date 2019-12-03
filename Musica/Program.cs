using Musica.LeitorNotas;
using Musica.Partituras;
using Musica.Utils;
using System;

namespace Musica
{
    public static class Program
    {
        static void Main(string[] args)
        {
            TocarMusica1();
            TocarMusica2();
            TocarMusica3();
            Console.ReadLine();
        }
        private static void TocarMusica1()
        {
            var partitura = new Partitura();

            using (var leitor = new LeitorNota())
            {
                foreach (var nota in leitor.LerNotas())
                {
                    partitura.SetNota(nota.Item1, nota.Item2, nota.Item3);
                }
            }

            partitura.Play(2);
        }

        private static void TocarMusica2()
        {
            var partitura = new Partitura();

            using (var leitor = new LeitorNota())
            {
                leitor.LerNota(out string nota, out int oitava, out TempoEnum tempo);

                partitura.SetNota(nota, oitava, tempo);
            }

            partitura.Play(2);
        }

        private static void TocarMusica3()
        {
            var partitura = new Partitura();

            var leitor = new LeitorNota();

            var nota = leitor.LerNota();
            partitura.SetNota(nota.nota, nota.oitava, nota.tempo);

            leitor.Dispose();


            partitura.Play(2);
        }
    }
}
