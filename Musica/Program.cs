﻿using Musica.Partituras;
using Musica.Utils;
using System;

namespace Musica
{
    public class Program
    {
        static void Main(string[] args)
        {
            TocarPartitura1();
            TocarPartitura2();
            TocarPartitura3();
            Console.ReadLine();
        }

        private static void TocarPartitura1()
        {
            var partitura = new Partitura();

            using (var leitor = new LeitorNotas())
            {
                foreach (var nota in leitor.LerNotas())
                {
                    partitura.SetNota(nota.Item1, nota.Item2, nota.Item3);
                }

                leitor.Dispose();
            }

            partitura.Play(2);
        }

        private static void TocarPartitura2()
        {
            var partitura = new Partitura();

            var leitor = new LeitorNotas();

            var nota = leitor.LerNota();
            partitura.SetNota(nota.Item1, nota.Item2, nota.Item3);

            leitor.Dispose();


            partitura.Play(2);
        }

        private static void TocarPartitura3()
        {
            var partitura = new Partitura();

            using (var leitor = new LeitorNotas())
            {
                string nota;
                int oitava;
                TempoEnum tempo;

                leitor.LerNota(out nota, out oitava, out tempo);

                partitura.SetNota(nota, oitava, tempo);
            }

            partitura.Play(2);
        }
    }
}
