namespace Musica
{
    interface INotaPartitura
    {
        INota Nota { get; set; }
        TempoEnum Tempo { get; set; }
        int Oitava { get; set; }

        void TocarNotaPartitura(int velocidade);
    }
}
