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
        Inimigo inimigo = new Inimigo("goblin");
        
        bool resultado = false;
        int decisao = 0;
        
        do
        {        
              bool defesa=false;
                Console.WriteLine("Escolha as seguintes opções: 1 - Ataque Leve 2 - Ataque Médio 3 - Ataque Forte 4 - Defesa 5 - Poção");
                decisao = Convert.ToInt32(Console.ReadLine());

                switch (decisao)
                {
                    case 1:
                        if (inimigo.inimigotr() == 4)
                        {
                            Console.WriteLine("Dano reduzido inimigo se defendeu");
                            inimigo.defesa(personagem.ataqueLeve());
                        }
                         
                        personagem.ataqueLeve();
                        break;
                    
                    case 2:

                        if (inimigo.inimigotr() == 4)
                        {
                            Console.WriteLine("Dano reduzido inimigo se defendeu");
                            inimigo.defesa(personagem.ataqueMedio());
                        }
                        personagem.ataqueMedio();
                        break;
                    case 3:
                        if (inimigo.inimigotr() == 4)
                        {
                            Console.WriteLine("Dano reduzido inimigo se defendeu");
                            inimigo.defesa(personagem.ataqueForte());
                        }
                         personagem.ataqueForte();
                        break;
                    case 4:
                        Console
                        .WriteLine("se prepara para defender");
                        defesa = true;
                        break;
                }
                


        } while (resultado != true);
    }


   
    }


