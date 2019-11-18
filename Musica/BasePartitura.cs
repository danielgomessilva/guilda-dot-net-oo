using Musica.Notas;
using System.Collections.Generic;
using System.Linq;

namespace Musica
{
    public abstract class BasePartitura
    {
        protected readonly List<INota> _notas = new List<INota>();
        protected List<NotaPartitura> _notasPartituras = new List<NotaPartitura>();
        protected BasePartitura()
        {
            _notas.Add(new Do());
            _notas.Add(new DoSus());
            _notas.Add(new Re());
            _notas.Add(new DoSus());
            _notas.Add(new Mi());
            _notas.Add(new Fa());
            _notas.Add(new FaSus());
            _notas.Add(new Sol());
            _notas.Add(new SolSus());
            _notas.Add(new La());
            _notas.Add(new LaSus());
            _notas.Add(new Si());
        }


        public virtual BasePartitura SetNota(string nota, int oitava, TempoEnum tempo)
        {
            var notaObj = _notas.FirstOrDefault(x => x.Nome == nota);
            var notaPartitura = new NotaPartitura() { Nota = notaObj,Oitava = oitava, Tempo = tempo};
            _notasPartituras.Add(notaPartitura);

            return this;
        }

        public virtual void Play(int velocidade)
        {
            _notasPartituras.ForEach(x =>
            {
                x.TocarNotaPartitura(velocidade);
            });
        }
    }
}
