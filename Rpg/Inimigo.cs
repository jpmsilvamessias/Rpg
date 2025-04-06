namespace Rpg;

public class Inimigo : Personagem
{
    public Inimigo(string nome) : base(nome) { }

    public int inimigotr()
    {
        Random random = new Random();
        int acao = random.Next(1, 5); // 1 a 4
        return acao;
    }
}