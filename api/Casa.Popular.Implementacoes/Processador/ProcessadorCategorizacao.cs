using Casa.Popular.Dominio.Models;
using Casa.Popular.Implementacoes.Patterns.Builder;
using Casa.Popular.Implementacoes.Patterns.Strategy;
using Casa.Popular.Interfaces.Processador;

namespace Casa.Popular.Implementacoes.Processador;

public class ProcessadorCategorizacao : IProcessadorCategorizacao
{
    public IEnumerable<Familia> Processar()
    {
        var builder = new FamiliaBuilder();
        var director = new FamiliaDirector(builder);
        var familias = new List<Familia>();

        director.MontarComPontuacaoDeRendaBaixa();
        familias.Add(builder.ObterFamilia());
        director.MontarComPontuacaoDeRendaMedia();
        familias.Add(builder.ObterFamilia());
        director.MontarComPontuacaoMaxima();
        familias.Add(builder.ObterFamilia());
        director.MontarComPontuacaoMaximaDeDependentes();
        familias.Add(builder.ObterFamilia());
        director.MontarComPontuacaoMinima();
        familias.Add(builder.ObterFamilia());
        director.MontarComPontuacaoMinimaDeDependentes();
        familias.Add(builder.ObterFamilia());

        var context = new CategorizacaoContext();

        foreach (var familia in familias)
        {
            var rendaStrategy = new RendaStrategy();
            var dependetesStrategy = new DependentesStrategy();

            context.DefinirStrategy(rendaStrategy);
            context.Categorizar(familia);

            context.DefinirStrategy(dependetesStrategy);
            context.Categorizar(familia);
        }

        return familias.OrderByDescending(f => f.Pontuacao).ToList();
    }
}