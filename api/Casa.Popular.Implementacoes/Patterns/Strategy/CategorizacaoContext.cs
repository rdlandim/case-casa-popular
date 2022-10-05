using Casa.Popular.Dominio.Models;
using Casa.Popular.Interfaces.Strategy;

namespace Casa.Popular.Implementacoes.Patterns.Strategy;

public class CategorizacaoContext
{
    private ICategorizacaoStrategy _strategy;

    public CategorizacaoContext() { }

    public void DefinirStrategy(ICategorizacaoStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Categorizar(Familia familia)
    {
        _strategy.Executar(familia);
    }
}