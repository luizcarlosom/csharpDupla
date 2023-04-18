using carSupermarket.Models;

namespace carSupermarket.Services;

public static class CarrinhoService
{
    static List<Carrinho> Produtos { get; }
    static int nextId = 16;
    static CarrinhoService()
    {
        Produtos = new List<Carrinho>
        {
            new Carrinho { 
              Id = 1,
              Nome = "1KG Arroz", 
              Valor = "R$ 4,00" },
            new Carrinho {
              Id = 2, 
              Nome = "1KG Feijão", 
              Valor ="R$ 8,00" },
            new Carrinho {
              Id = 3, 
              Nome = "1KG Açucar", 
              Valor ="R$ 3,00" },
            new Carrinho {
              Id = 4, 
              Nome = "Salgadinho Doritos", 
              Valor ="R$ 5,00" },
            new Carrinho {
              Id = 5, 
              Nome = "Salgadinho Pipos", 
              Valor ="R$ 3,00" },
            new Carrinho {
              Id = 6, 
              Nome = "Pipoca Caruaru", 
              Valor ="R$ 2,00" },
            new Carrinho {
              Id = 7, 
              Nome = "Biscoito Treloso", 
              Valor ="R 2,50" },
            new Carrinho {
              Id = 8, 
              Nome = "Biscoito Bono", 
              Valor ="R$ 3,50" },
            new Carrinho {
              Id = 9, 
              Nome = "Pacote Bolacha Maria", 
              Valor ="R$ 4,00" },
            new Carrinho {
              Id = 10, 
              Nome = " Pacote Bolacha CreamCracker", 
              Valor ="R$ 3,00" },
      };
    }

    public static List<Carrinho> GetAll() => Produtos;

    public static Carrinho? Get(int id) => Produtos.FirstOrDefault(p => p.Id == id);

    public static void Add(Carrinho Carrinho)
    {
        Carrinho.Id = nextId++;
        Produtos.Add(Carrinho);
    }

    public static void Delete(int id)
    {
        var Carrinho = Get(id);
        if(Carrinho is null)
            return;

        Produtos.Remove(Carrinho);
    }

    public static void Update(Carrinho Carrinho)
    {
        var index = Produtos.FindIndex(p => p.Id == Carrinho.Id);
        if(index == -1)
            return;

        Produtos[index] = Carrinho;
    }
}