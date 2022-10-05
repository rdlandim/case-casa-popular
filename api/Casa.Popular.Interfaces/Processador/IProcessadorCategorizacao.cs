using Casa.Popular.Dominio.Models;

namespace Casa.Popular.Interfaces.Processador;

public interface IProcessadorCategorizacao
{
    IEnumerable<Familia> Processar();
}