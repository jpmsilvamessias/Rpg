namespace Rpg;

public class Personagem
{
    private String nome;
    private int vida = 100;
    private List<int> potion = new List<int>{ 1, 2 };


    public String Nome => nome;
    
    

    public int Vida
    {
        get { return vida; }
        set{ vida=value;}
    }
    
  
    
    public Personagem(string nome)
    {
        this.nome = nome;
    }


    public int ataqueLeve()
    {
        Random random = new Random();
        int acerto= random.Next(1, 10);
        return acerto;
    }

    public int ataqueMedio()
    {
        Random random = new Random();
        int acerto= random.Next(10, 20);
        return acerto;
    }

    public int ataqueForte()
    {
        Random random = new Random();
        int acerto= random.Next(20, 30);
        return acerto;
    }
    
    

    public int defesa(int dano)
    {
        return dano / 2;
    }

    public void pocaoCura(List<int> a )
    {
        try
        {
            a.RemoveAt(0);
            this.vida += 20;
        }
        catch (ArgumentOutOfRangeException e )
        {
            Console.WriteLine("Erro lista esra vazia"+e.Message);
        }
    }
    
    
}