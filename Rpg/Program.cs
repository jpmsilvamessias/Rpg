namespace Rpg;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("seja bem vindo ao Rpg");
        Console.WriteLine("vamos criar seu personagem! insira um nome:");
        string nome = Console.ReadLine();
        Personagem personagem = new Personagem(nome);
        Console.WriteLine($"seja bem vindo jogador{nome} ");
        Personagem inimigo = new Personagem("goblin");
        bool resultado = false;
        do
        {
            if(personagem.vida = )
            Console.WriteLine("Escolha as seguintes opções: 1 - Ataque Leve 2 - Ataque Médio 3 - Ataque Forte 4 - Defesa 5 - Poção");
            
        } while (resultado != true);
    }
    
}