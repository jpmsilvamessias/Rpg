﻿namespace Rpg;

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
        int acerto= random.Next(1, 11);
        Console.WriteLine($"Seu ataque leve acerto e causou{acerto} de dano");
        return 0;
    }

    public int ataqueMedio()
    {
        
        Random random = new Random();
        int porcentagem = random.Next(1, 100);
        int acerto= random.Next(10, 21);
        if (porcentagem <= 80)
        {
            Console.WriteLine($"seu ataque acertou e causo{acerto} de dano");
            return acerto;
        }
        else
        {
            Console.WriteLine("seu ataque  medio errou");
        }
        return 0;
    }

    public int  ataqueForte()
    {
        Random random = new Random();
        int porcentagem = random.Next(1, 100);
        int acerto= random.Next(20, 31);

        if (porcentagem <= 50)
        {
            Console.WriteLine($"seu ataque forte acertou e causo{acerto} de dano");
        }
        else
        {
            Console.WriteLine("seu ataque forte errou");
        }

        return 0;
    }

    public void defesa(int dano)
    {
        int danoreduzido = dano / 2;
        this.Vida -= danoreduzido;
        Console.WriteLine($"Você defendeu e recebeu apenas {danoreduzido} de dano.");
    }

    public void pocaoCura()
    {
        try
        {
            potion.RemoveAt(0);
            this.vida += 20;
        }
        catch (ArgumentOutOfRangeException e )
        {
            Console.WriteLine("Erro lista esra vazia"+e.Message);
        }
    }
    
    
}