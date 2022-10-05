using Casa.Popular.Dominio.Models;
using Casa.Popular.Interfaces.Patterns.Builder;

namespace Casa.Popular.Implementacoes.Patterns.Builder;

public class FamiliaDirector
{
    private readonly IFamiliaBuilder _builder;

    public FamiliaDirector(IFamiliaBuilder builder)
    {
        _builder = builder;
    }

    public void MontarComPontuacaoMaxima()
    {
        var dependentes = new List<Dependente> {
            new Dependente(17),
            new Dependente(10),
            new Dependente(8),
            new Dependente(33),
            new Dependente(30),
        };

        _builder.MontarDependentes(dependentes).MontarRenda(860);
    }

    public void MontarComPontuacaoMinima()
    {
        var dependentes = new List<Dependente> {
            new Dependente(8),
            new Dependente(33),
            new Dependente(30),
        };

        _builder.MontarDependentes(dependentes).MontarRenda(1433);
    }

    public void MontarComPontuacaoDeRendaBaixa()
    {
        _builder.MontarRenda(899);
    }

    public void MontarComPontuacaoDeRendaMedia()
    {
        _builder.MontarRenda(1350);
    }

    public void MontarComPontuacaoMaximaDeDependentes()
    {
        var dependentes = new List<Dependente> {
            new Dependente(17),
            new Dependente(10),
            new Dependente(8),
            new Dependente(33),
            new Dependente(30),
        };

        _builder.MontarDependentes(dependentes).MontarRenda(1501);
    }

    public void MontarComPontuacaoMinimaDeDependentes()
    {
        var dependentes = new List<Dependente> {
            new Dependente(17),
            new Dependente(33),
            new Dependente(30),
        };

        _builder.MontarDependentes(dependentes).MontarRenda(1501);
    }
}
