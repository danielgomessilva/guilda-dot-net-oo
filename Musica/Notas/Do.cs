using Musica.Notas.Interpretadores;
using System;

namespace Musica.Notas
{
    internal sealed class Do : BaseNota<InterpretadorBeepNota>
    {
        internal Do() : base(33,"do")
        {
        }
    }
}
