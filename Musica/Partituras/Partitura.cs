using Musica.Utils;
using System;

namespace Musica.Partituras
{
    public class Partitura : BasePartitura
    {
        public Partitura()
            : base()
        {
        }

        public override void Play(int velocidade)
        {
            Console.WriteLine(Constants.TocandoMusica);
            base.Play(velocidade);
            Console.WriteLine(Constants.FimDaMusica);
        }
    }
}
