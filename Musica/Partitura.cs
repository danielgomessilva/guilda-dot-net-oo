using System;

namespace Musica
{
    public class Partitura : BasePartitura
    {
        public Partitura()
            : base()
        {
        }

        public override void Play(int velocidade)
        {
            Console.WriteLine("tocando musica");
            base.Play(velocidade);
            Console.WriteLine("fim da musica");
        }
    }
}
