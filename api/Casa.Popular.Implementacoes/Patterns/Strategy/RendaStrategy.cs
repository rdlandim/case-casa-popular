using Casa.Popular.Dominio.Models;
using Casa.Popular.Interfaces.Strategy;

namespace Casa.Popular.Implementacoes.Patterns.Strategy;

public class RendaStrategy : ICategorizacaoStrategy
{
    public void Executar(Familia familia)
    {
        var pontuacao = familia.Renda <= 900 ? 5 : 0;
        
        if (pontuacao == 0)
            pontuacao = familia.Renda > 900 && familia.Renda <= 1500 ? 3 : 0;

        familia.Pontuacao += pontuacao;
    }
}