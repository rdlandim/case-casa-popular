using Casa.Popular.Dominio.Models;

namespace Casa.Popular.Interfaces.Strategy;

public interface ICategorizacaoStrategy
{
    void Executar(Familia familia);
}
