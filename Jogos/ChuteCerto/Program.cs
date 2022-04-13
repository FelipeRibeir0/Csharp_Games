bool jogar = true;
int pontos = 0, pontospc = 0;

while (jogar == true)
{
    Random gerador = new Random();
    int num = gerador.Next(1, 10);

    Console.WriteLine("Digite um número de 1 a 10:\nPara sair digite 0\nPara reiniciar digite 11.");
    int chute = Convert.ToInt16(Console.ReadLine());

    //Controle de Opções
    if (chute < 0 || chute > 12)
    {
        Console.Clear();
        Console.WriteLine("Escolha uma opção disponível.");
    }

    if (chute > 0 && chute < 11)
    {
 
        // Se acertar == ganha ponto
        if (chute == num)
        {
            pontos++;
            Console.Clear();
            Console.WriteLine("Parabéns!\nO número gerado foi " + num + "!\n\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n");
        }

        // Se errar == computador ganha ponto
        if (chute != num)
        {
            pontospc++;
            Console.Clear();
            Console.WriteLine("Que azar.\nO número gerado foi " + num + "!\n\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n");
        }

    }
    
    // Metodo de Saida
    if (chute == 0)
    {
        jogar = false;

        if (pontos > pontospc)
        {
            Console.Clear();
            Console.WriteLine("Parabéns!!\nVocê venceu esta partida.\n\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.");
        }
        else if (pontospc > pontos)
        {
            Console.Clear();
            Console.WriteLine("Infelizmente você perdeu esta partida.\n\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Houve um empate!\n\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.");
        }
    }

    // Metodo para Reiniciar
    if (chute == 11)
    {
        if (pontos > pontospc)
        {
            Console.Clear();
            Console.WriteLine("Parabéns!!\nVocê venceu esta partida.\n\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n\nNovo Jogo!!\n");
        }
        else if (pontospc > pontos)
        {
            Console.Clear();
            Console.WriteLine("Infelizmente você perdeu esta partida.\n\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n\nNovo Jogo!!\n");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Houve um empate!\n\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n\nNovo Jogo!!\n");
        }
        pontos = 0;
        pontospc = 0;
    }
}