namespace Rpg;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("seja bem vindo ao Rpg");
        Console.WriteLine("vamos criar seu personagem responda insira um nome");
        string nome = Console.ReadLine();
        Personagem personagem = new Personagem(nome);
        Console.WriteLine($"seja bem vindo jogador{nome}  ");
        Personagem inimigo = new Personagem("goblin");
       Console.WriteLine($"{inimigo.Nome}");
        
        
    }
}