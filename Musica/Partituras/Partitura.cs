using Musica.Utils;
using System;

namespace Musica.Partituras
{
    internal class Partitura : BasePartitura
    {
        internal Partitura()
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
