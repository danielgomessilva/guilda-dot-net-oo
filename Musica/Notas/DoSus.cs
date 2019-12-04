using Musica.Notas.Interpretadores;

namespace Musica.Notas
{
    sealed class DoSus :  BaseNota<InterpretadorBeepNota>
    {
        internal DoSus() : base(35,"doSus")
        {
        }
    }
}
