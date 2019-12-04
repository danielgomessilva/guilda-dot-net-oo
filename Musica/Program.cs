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
            TocarMusica();
            TocarMusica(tempoMusica: 2, musica: 2);
            TocarMusica(musica: 3);
            Console.ReadLine();
        }

        private static void TocarMusica(int musica = 1, int tempoMusica = 2)
        {
            switch (musica)
            {

                case 1:
                    TocarMusica1(tempoMusica);
                    break;

                case 2:
                    TocarMusica2(tempoMusica);
                    break;

                case 3:
                    TocarMusica3(tempoMusica);
                    break;

                default:
                    break;
            }

        }
        private static void TocarMusica1(int tempoMusica = 2)
        {

            var partitura = new BasePartitura.Partitura();

            using (var leitor = new LeitorNota())
            {
                foreach (var nota in leitor.LerNotas())
                {
                    partitura.SetNota(nota.Item1, nota.Item2, nota.Item3);
                }
            }

            partitura.Tocar(tempoMusica);
        }

        private static void TocarMusica2(int tempoMusica = 2)
        {
            var partitura = new BasePartitura.Partitura();

            using (var leitor = new LeitorNota())
            {
                leitor.LerNota(out string nota, out int oitava, out TempoEnum tempo);

                partitura.SetNota(nota, oitava, tempo);
            }

            partitura.Tocar(tempoMusica);
        }

        private static void TocarMusica3(int tempoMusica = 2)
        {
            var partitura = new BasePartitura.Partitura();

            var leitor = new LeitorNota();

            var nota = leitor.LerNota();
            partitura.SetNota(nota.nota, nota.oitava, nota.tempo);

            leitor.Dispose();


            partitura.Tocar(tempoMusica);
        }
    }
}
