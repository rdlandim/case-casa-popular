namespace Casa.Popular.Dominio.Models;

public class Dependente
{
    public Dependente(int idade)
    {
        Idade = idade;
    }
    
    public int Idade { get; set; }
}
