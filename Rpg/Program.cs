namespace Rpg;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seja bem-vindo ao RPG!");
        Console.Write("Digite o nome do seu personagem: ");
        string nomeJogador = Console.ReadLine();

        Personagem jogador = new Personagem(nomeJogador);
        Inimigo inimigo = new Inimigo("Goblin");

        bool fimDeJogo = false;

        while (!fimDeJogo)
        {
            Console.WriteLine($"\nVida de {jogador.Nome}: {jogador.Vida}");
            Console.WriteLine($"Vida de {inimigo.Nome}: {inimigo.Vida}");
            Console.WriteLine("\nEscolha uma ação:");
            Console.WriteLine("1 - Ataque Leve");
            Console.WriteLine("2 - Ataque Médio");
            Console.WriteLine("3 - Ataque Forte");
            Console.WriteLine("4 - Defender");
            Console.WriteLine("5 - Usar Poção");

            int escolhaJogador;
            int.TryParse(Console.ReadLine(), out escolhaJogador);

            int acaoInimigo = inimigo.inimigotr();
            bool jogadorDefendeu = escolhaJogador == 4;
            bool inimigoDefendeu = acaoInimigo == 4;

            Console.WriteLine();

            switch (escolhaJogador)
            {
                case 1:
                    int danoLeve = jogador.ataqueLeve();
                    if (inimigoDefendeu)
                        inimigo.defesa(danoLeve);
                    else
                        inimigo.Vida -= danoLeve;
                    break;

                case 2:
                    int danoMedio = jogador.ataqueMedio();
                    if (inimigoDefendeu)
                        inimigo.defesa(danoMedio);
                    else
                        inimigo.Vida -= danoMedio;
                    break;

                case 3:
                    int danoForte = jogador.ataqueForte();
                    if (inimigoDefendeu)
                        inimigo.defesa(danoForte);
                    else
                        inimigo.Vida -= danoForte;
                    break;

                case 4:
                    Console.WriteLine($"{jogador.Nome} se preparou para defender.");
                    break;

                case 5:
                    jogador.pocaoCura();
                    break;

                default:
                    Console.WriteLine("Escolha inválida!");
                    break;
            }

            if (inimigo.Vida <= 0)
            {
                Console.WriteLine($"\nParabéns {jogador.Nome}, você derrotou o {inimigo.Nome}!");
                break;
            }

            Console.WriteLine("\nTurno do inimigo:");
            switch (acaoInimigo)
            {
                case 1:
                    int danoInimigoLeve = inimigo.ataqueLeve();
                    if (jogadorDefendeu)
                        jogador.defesa(danoInimigoLeve);
                    else
                        jogador.Vida -= danoInimigoLeve;
                    break;

                case 2:
                    int danoInimigoMedio = inimigo.ataqueMedio();
                    if (jogadorDefendeu)
                        jogador.defesa(danoInimigoMedio);
                    else
                        jogador.Vida -= danoInimigoMedio;
                    break;

                case 3:
                    int danoInimigoForte = inimigo.ataqueForte();
                    if (jogadorDefendeu)
                        jogador.defesa(danoInimigoForte);
                    else
                        jogador.Vida -= danoInimigoForte;
                    break;

                case 4:
                    Console.WriteLine($"{inimigo.Nome} se preparou para defender.");
                    break;
            }

            if (jogador.Vida <= 0)
            {
                Console.WriteLine($"\n{jogador.Nome} foi derrotado pelo {inimigo.Nome}...");
                fimDeJogo = true;
            }
        }

        Console.WriteLine("\nFim de jogo!");
    }
}
