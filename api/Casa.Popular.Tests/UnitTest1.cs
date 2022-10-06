using Casa.Popular.Dominio.Models;
using Casa.Popular.Implementacoes.Patterns.Builder;
using Casa.Popular.Implementacoes.Patterns.Strategy;

namespace Casa.Popular.Tests;

public class Tests
{
    private FamiliaBuilder _builder;
    private CategorizacaoContext _context;

    [SetUp]
    public void Setup()
    {
        _builder = new FamiliaBuilder();
        _context = new CategorizacaoContext();
    }

    [Test]
    public void RendaBaixaDeveSerIgualACinco()
    {
        _builder.MontarDependente(new Dependente(32)).MontarRenda(850);
        var familia = _builder.ObterFamilia();

        var rendaStrategy = new RendaStrategy();

        _context.DefinirStrategy(rendaStrategy);
        _context.Categorizar(familia);

        Assert.That(familia.Pontuacao, Is.EqualTo(5));
    }

    [Test]
    public void RendaMediaDeveSerIgualATres()
    {
        _builder.MontarDependente(new Dependente(32)).MontarRenda(950);

        var familia = _builder.ObterFamilia();

        var rendaStrategy = new RendaStrategy();

        _context.DefinirStrategy(rendaStrategy);
        _context.Categorizar(familia);

        Assert.That(familia.Pontuacao, Is.EqualTo(3));
    }

    [Test]
    public void FamiliaComTresDependentesAbaixoDeDezoitoAnosDeveSerIgualATres()
    {
        var dependentes = new List<Dependente> {
            new Dependente(17),
            new Dependente(17),
            new Dependente(17)
        };

        _builder.MontarDependentes(dependentes).MontarRenda(1600);

        var familia = _builder.ObterFamilia();

        var dependentesStrategy = new DependentesStrategy();

        _context.DefinirStrategy(dependentesStrategy);
        _context.Categorizar(familia);

        Assert.That(familia.Pontuacao, Is.EqualTo(3));
    }

    [Test]
    public void FamiliaComUmOuDoisDependentesAbaixoDeDezoitoAnosDeveSerIgualADois()
    {
        var dependentes = new List<Dependente> {
            new Dependente(17),
            new Dependente(17),
        };

        _builder.MontarDependentes(dependentes).MontarRenda(1600);
        var familia = _builder.ObterFamilia();

        var dependentesStrategy = new DependentesStrategy();

        _context.DefinirStrategy(dependentesStrategy);
        _context.Categorizar(familia);

        Assert.That(familia.Pontuacao, Is.EqualTo(2));
    }

    [Test]
    public void FamiliaComTresDependentesAbaixoDeDezoitoAnosERendaBaixaDeveSerIgualAOito()
    {
        var dependentes = new List<Dependente> {
            new Dependente(17),
            new Dependente(17),
            new Dependente(17),
        };
        _builder.MontarDependentes(dependentes).MontarRenda(850);
        var familia = _builder.ObterFamilia();

        var rendaStrategy = new RendaStrategy();
        var dependentesStrategy = new DependentesStrategy();

        _context.DefinirStrategy(rendaStrategy);
        _context.Categorizar(familia);

        _context.DefinirStrategy(dependentesStrategy);
        _context.Categorizar(familia);

        Assert.That(familia.Pontuacao, Is.EqualTo(8));
    }

    [Test]
    public void FamiliaComUmOuDoisDependentesAbaixoDeDezoitoAnosERendaBaixaDeveSerIgualASete()
    {
        var dependentes = new List<Dependente> {
            new Dependente(17),
            new Dependente(17),
        };
        _builder.MontarDependentes(dependentes).MontarRenda(850);
        var familia = _builder.ObterFamilia();

        var rendaStrategy = new RendaStrategy();
        var dependentesStrategy = new DependentesStrategy();

        _context.DefinirStrategy(rendaStrategy);
        _context.Categorizar(familia);
        
        _context.DefinirStrategy(dependentesStrategy);
        _context.Categorizar(familia);

        Assert.That(familia.Pontuacao, Is.EqualTo(7));
    }

    [Test]
    public void FamiliaComTresDependentesAbaixoDeDezoitoAnosERendaMediaDeveSerIgualASeis()
    {
        var dependentes = new List<Dependente> {
            new Dependente(17),
            new Dependente(17),
            new Dependente(17),
        };

        _builder.MontarDependentes(dependentes).MontarRenda(1100);
        var familia = _builder.ObterFamilia();

        var rendaStrategy = new RendaStrategy();
        var dependentesStrategy = new DependentesStrategy();

        _context.DefinirStrategy(rendaStrategy);
        _context.Categorizar(familia);

        _context.DefinirStrategy(dependentesStrategy);
        _context.Categorizar(familia);

        Assert.That(familia.Pontuacao, Is.EqualTo(6));
    }

     [Test]
    public void FamiliaComUmOuDoisDependentesAbaixoDeDezoitoAnosERendaMediaDeveSerIgualA5()
    {
        var dependentes = new List<Dependente> {
            new Dependente(17),
            new Dependente(17),
        };
        _builder.MontarDependentes(dependentes).MontarRenda(1100);
        var familia = _builder.ObterFamilia();

        var rendaStrategy = new RendaStrategy();
        var dependentesStrategy = new DependentesStrategy();

        _context.DefinirStrategy(rendaStrategy);
        _context.Categorizar(familia);
        
        _context.DefinirStrategy(dependentesStrategy);
        _context.Categorizar(familia);

        Assert.That(familia.Pontuacao, Is.EqualTo(5));
    }
}