namespace Rpg;

public class Personagem
{
    private string nome;
    private int vida = 100;
    private List<int> potion = new List<int> { 1, 2 };

    public string Nome => nome;

    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public Personagem(string nome)
    {
        this.nome = nome;
    }

    public int ataqueLeve()
    {
        Random random = new Random();
        int acerto = random.Next(1, 11);
        Console.WriteLine($"{this.nome} usou ataque leve e causou {acerto} de dano.");
        return acerto;
    }

    public int ataqueMedio()
    {
        Random random = new Random();
        int porcentagem = random.Next(1, 100);
        int acerto = random.Next(10, 21);

        if (porcentagem <= 80)
        {
            Console.WriteLine($"{this.nome} usou ataque médio e causou {acerto} de dano.");
            return acerto;
        }
        else
        {
            Console.WriteLine($"{this.nome} errou o ataque médio.");
            return 0;
        }
    }

    public int ataqueForte()
    {
        Random random = new Random();
        int porcentagem = random.Next(1, 100);
        int acerto = random.Next(20, 31);

        if (porcentagem <= 50)
        {
            Console.WriteLine($"{this.nome} usou ataque forte e causou {acerto} de dano.");
            return acerto;
        }
        else
        {
            Console.WriteLine($"{this.nome} errou o ataque forte.");
            return 0;
        }
    }

    public void defesa(int dano)
    {
        int danoreduzido = dano / 2;
        this.Vida -= danoreduzido;
        Console.WriteLine($"{this.nome} defendeu e recebeu apenas {danoreduzido} de dano.");
    }

    public void pocaoCura()
    {
        try
        {
            potion.RemoveAt(0);
            this.vida += 20;
            Console.WriteLine($"{this.nome} usou uma poção e recuperou 20 de vida.");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"{this.nome} tentou usar uma poção, mas não havia mais! " + e.Message);
        }
    }
}
