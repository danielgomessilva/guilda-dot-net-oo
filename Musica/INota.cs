﻿namespace Musica
{
    public interface INota
    {
        string Nome { get; }
        void TocarNota(int velocidade, TempoEnum tempo, int oitava);
        void TocarNota(int velocidade, TempoEnum tempo);
    }
}
