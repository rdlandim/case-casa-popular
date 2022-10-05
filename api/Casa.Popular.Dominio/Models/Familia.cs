namespace Casa.Popular.Dominio.Models;

public class Familia
{
    public Familia()
    {
        Dependentes = new List<Dependente>();
    }

    public decimal Renda { get; set; }
    public IEnumerable<Dependente> Dependentes { get; set; }
    public int Pontuacao { get; set; }

    public void AdicionarDependente(Dependente dependente)
    {
        var dependentes = Dependentes.ToList();

        dependentes.Add(dependente);

        Dependentes = dependentes;
    }
}
