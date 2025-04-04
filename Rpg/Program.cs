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
        int decisao = 0;
        Random aleatorio = new Random();
        int turnoinimigo = aleatorio.Next(1, 5);
        
        
        do
        {
                Console.WriteLine("Escolha as seguintes opções: 1 - Ataque Leve 2 - Ataque Médio 3 - Ataque Forte 4 - Defesa 5 - Poção");
                decisao = Convert.ToInt32(Console.ReadLine());
                switch (decisao)
                {
                    case 1:
                        Console.WriteLine("Ataque fofo");
                        inimigo.Vida -= personagem.ataqueLeve();
                        break;
                    case 2:
                        Random random = new Random();
                        int chance = random.Next(1, 80);
                        if (chance <= 80)
                        {
                            inimigo.Vida -= personagem.ataqueMedio();
                        }
                        else
                        {
                            Console.WriteLine("Errou o inimigo");
                        }

                        break;
                    case 3:
                        Random random2 = new Random();
                        int chance2 = random2.Next(1, 50);
                        if (chance2 <= 50)
                        {
                            inimigo.Vida -= personagem.ataqueForte();
                        }
                        else
                        {
                            Console.WriteLine("Errou o inimigo");
                        }

                        break;
                    case 4:
                        // continuar depois (jao faz) 
                        break;
                    case 5:
                        personagem.pocaoCura();
                        break;
                    default:
                        Console.WriteLine("Valor indevido, faça uma nova ação! ");
                        break;
                }


        } while (resultado != true);
    }
    
    
    
}

