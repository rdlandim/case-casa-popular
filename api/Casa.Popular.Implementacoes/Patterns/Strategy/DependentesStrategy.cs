using Casa.Popular.Dominio.Models;
using Casa.Popular.Interfaces.Strategy;

namespace Casa.Popular.Implementacoes.Patterns.Strategy;

public class DependentesStrategy : ICategorizacaoStrategy
{
    public void Executar(Familia familia)
    {
        var dependentesPontuaveis = familia.Dependentes.Count(d => d.Idade < 18);
        var pontuacao = dependentesPontuaveis >= 3 ? 3 : 0;

        if (pontuacao == 0)
            pontuacao = dependentesPontuaveis >= 1 && dependentesPontuaveis <= 2 ? 2 : 0;

        familia.Pontuacao += pontuacao;
    }
}
