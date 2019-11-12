using Musica.Notas;
using System;
using System.Collections.Generic;

namespace Musica
{
    public class Partitura
    {
        Dictionary<string, INota> _notas = new Dictionary<string, INota>();
        private readonly List<Nota> _musica = new List<Nota>();
        public Partitura()
        {
            _notas.Add("Do", new Do());
            _notas.Add("Do#", new DoSus());
            _notas.Add("Re", new Re());
            _notas.Add("Re#", new DoSus());
            _notas.Add("Mi", new Mi());
            _notas.Add("Fa", new Fa());
            _notas.Add("Fa#", new FaSus());
            _notas.Add("Sol", new Sol());
            _notas.Add("Sol#", new SolSus());
            _notas.Add("La", new La());
            _notas.Add("La#", new LaSus());
            _notas.Add("Si", new Si());


        }
        public Partitura SetNota(string nota, int oitava, Tempo tempo)
        {
            var notaObj = _notas[nota];
            var novaNota = new Nota(oitava, notaObj, tempo);
            _musica.Add(novaNota);
            return this;
        }
        public void Play(int velocidade)
        {
            _musica.ForEach(x =>
            {
                var newVel = (int)x.Tempo / velocidade;
                Console.Beep(x.Frequencia, newVel);
            });
        }
    }
    public enum Tempo
    {
        Semicocheia = 250,
        Colcheia = 500,
        Seminima = 1000,
        Minima = 2000,
        Semibreve = 4000
    }
}
