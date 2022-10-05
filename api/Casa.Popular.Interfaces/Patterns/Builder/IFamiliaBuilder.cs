using Casa.Popular.Dominio.Models;

namespace Casa.Popular.Interfaces.Patterns.Builder;

public interface IFamiliaBuilder
{
    void Limpar();
    IFamiliaBuilder MontarRenda(decimal renda);
    IFamiliaBuilder MontarDependente(Dependente dependente);
    IFamiliaBuilder MontarDependentes(IEnumerable<Dependente> dependentes);
}
