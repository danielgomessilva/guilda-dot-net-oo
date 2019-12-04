using Musica.Notas.Interpretadores;
using Musica.Utils;
using System;

namespace Musica.Notas
{
    public abstract class BaseNota<T> : INota
        where T : IInterpretadorNota, new()
    {
        private readonly int _frequencia;
        private readonly T _interpretador;
        private string _nome;

        public string GetNome()
        { return _nome; }
        public void SetNome(string value)
        { _nome = value; }

        public string Nome => _nome;

        protected BaseNota(int frequencia, string nome)
        {
            _interpretador = new T();
            _frequencia = frequencia;
            _nome = nome;

            Console.WriteLine(this[0]);
        }

        private char this[int i]
        {
            get { return _nome[i]; }
        }

        public void TocarNota(int velocidade, TempoEnum tempo, int oitava)
        {
            _interpretador.InterpretarNota(CalcularFrequenciaOitavada(oitava), CalcularVelocidade(tempo, velocidade));
        }

        public void TocarNota(int velocidade, TempoEnum tempo)
        {
            _interpretador.InterpretarNota(_frequencia, CalcularVelocidade(tempo, velocidade));
        }

        private int CalcularFrequenciaOitavada(int oitava)
        {
            var frequencia = _frequencia;
            for (int i = 2; i <= oitava; i++)
                frequencia = frequencia * 2;

            return frequencia;
        }

        private int CalcularVelocidade(TempoEnum tempo, int velocidade) => (int)tempo / velocidade;
    }
}
