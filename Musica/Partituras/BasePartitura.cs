using Musica.NotaPartituras;
using Musica.Notas;
using Musica.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Musica.Partituras
{
    internal abstract class BasePartitura
    {
        protected readonly List<INota> _notas = new List<INota>();
        protected List<NotaPartitura> _notasPartituras = new List<NotaPartitura>();
        protected BasePartitura()
            : this(new List<INota>() { new Do(),
                                        new Re(),
                                        new Mi(),
                                        new Fa(),
                                        new Sol(),
                                        new La(),
                                        new Si()})
        {
        }

        protected BasePartitura(List<INota> notas)
        {
            _notas.Add(new ReSus());
            _notas.Add(new FaSus());
            _notas.Add(new SolSus());
            _notas.Add(new DoSus());
            _notas.Add(new LaSus());
            _notas.AddRange(notas);
        }

        public virtual BasePartitura SetNota(string nota, int oitava, TempoEnum tempo)
        {
            var notaObj = _notas.FirstOrDefault(x => x.GetNome() == nota);
            var notaPartitura = new NotaPartitura() { Nota = notaObj, Oitava = oitava, Tempo = tempo };
            _notasPartituras.Add(notaPartitura);

            return this;
        }

        public virtual void Tocar(int velocidade)
        {
            _notasPartituras.ForEach(x =>
            {
                x.TocarNotaPartitura(velocidade);
            });
        }

        internal class Partitura : BasePartitura
        {
            internal Partitura()
                : base()
            {
            }

            public override void Tocar(int velocidade)
            {
                Console.WriteLine(Constants.TocandoMusica);
                base.Tocar(velocidade);
                Console.WriteLine(Constants.FimDaMusica);
            }
        }
    }
}
