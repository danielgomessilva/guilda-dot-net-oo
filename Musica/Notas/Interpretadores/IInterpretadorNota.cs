
namespace Musica.Notas.Interpretadores
{
    public interface IInterpretadorNota
    {
        void InterpretarNota(int frequencia, int tempo);

        void InterpretarNota(int frequencia);
    }
}
