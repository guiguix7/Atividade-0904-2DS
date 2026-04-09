using System;

class Categoria
{
    public string Nome { get; }

    public Categoria(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("Nome da categoria não pode ser vazio.", nameof(nome));
        }

        Nome = nome;
    }
}

class Filme
{
    public string Titulo { get; }
    public int Duracao { get; }
    public Categoria Genero { get; }

    public Filme(string titulo, int duracao, Categoria genero)
    {
        if (string.IsNullOrWhiteSpace(titulo))
        {
            throw new ArgumentException("Título não pode ser vazio.", nameof(titulo));
        }

        if (duracao <= 0)
        {
            throw new ArgumentException("Duração deve ser maior que zero.", nameof(duracao));
        }

        Genero = genero ?? throw new ArgumentNullException(nameof(genero), "Categoria é obrigatória.");
        Titulo = titulo;
        Duracao = duracao;
    }

    public void Exibir()
    {
        Console.WriteLine($"Filme:{Titulo} | Duração:{Duracao} min | Gênero: {Genero.Nome}");
    }
}

class Program
{
    static void Main()
    {
        var acao = new Categoria("Ação");
        var drama = new Categoria("Drama");
        var comedia = new Categoria("Comédia");
        var aventura = new Categoria("Aventura");

        var filme1 = new Filme("A Baleia", 117, drama);
        var filme2 = new Filme("O Poderoso Chefão", 175, drama);
        var filme3 = new Filme("Montros SA", 92, comedia);
        var filme4 = new Filme("Shrek", 89, comedia);
        var filme5 = new Filme("Up: Altas Aventuras", 95, aventura);
        var filme6 = new Filme("Shrek", 89, comedia);
        var filme7 = new Filme("Homem-Aranha", 121, acao);
        var filme8 = new Filme("O Senhor dos Anéis", 178, comedia);
        var filme9 = new Filme("O Rei Leão", 118, comedia);

        filme1.Exibir();
        filme2.Exibir();
        filme3.Exibir();
        filme4.Exibir();
        filme5.Exibir();
        filme6.Exibir();
        filme7.Exibir();
        filme8.Exibir();
        filme9.Exibir();
    }
}
