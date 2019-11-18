namespace Musica
{
    public abstract class BaseNota<T> : INota
        where T : IInterpretadorNota, new()
    {
        private readonly int _frequencia;
        private readonly T _interpretador;
        public string Nome { get; }

        protected BaseNota(int frequencia, string nome)
        {
            _interpretador = new T();
            _frequencia = frequencia;
            Nome = nome;
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
