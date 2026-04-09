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

        var filme1 = new Filme("Vingadores: Ultimato", 181, acao);
        var filme2 = new Filme("O Poderoso Chefão", 175, drama);
        var filme3 = new Filme("Mad Max: Estrada da Fúria", 120, acao);

        filme1.Exibir();
        filme2.Exibir();
        filme3.Exibir();
    }
}
