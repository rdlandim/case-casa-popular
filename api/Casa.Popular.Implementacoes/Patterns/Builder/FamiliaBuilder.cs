using Casa.Popular.Dominio.Models;
using Casa.Popular.Interfaces.Patterns.Builder;

namespace Casa.Popular.Implementacoes.Patterns.Builder;

public class FamiliaBuilder : IFamiliaBuilder
{
    private Familia _familia;

    public FamiliaBuilder()
    {
        _familia = new Familia();
    }

    public void Limpar()
    {
        _familia = new Familia();
    }

    public IFamiliaBuilder MontarDependente(Dependente dependente)
    {
        _familia.AdicionarDependente(dependente);

        return this;
    }

    public IFamiliaBuilder MontarDependentes(IEnumerable<Dependente> dependentes)
    {
        foreach (var dependente in dependentes)
            MontarDependente(dependente);

        return this;
    }

    public IFamiliaBuilder MontarRenda(decimal renda)
    {
        _familia.Renda = renda;

        return this;
    }

    public Familia ObterFamilia()
    {
        if (!_familia.Dependentes.Any())
            MontarDependente(new Dependente(18));

        var result = _familia;

        Limpar();

        return result;
    }
}