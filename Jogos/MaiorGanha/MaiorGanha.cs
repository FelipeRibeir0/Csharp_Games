int jogadas = 0, pontos = 0, pontospc = 0;
int limite = 2;
bool aceitar = true;
do
{
    Random gerador = new Random();
    int numjogador = gerador.Next(1, 100);
    int aposta = gerador.Next(1, 100);

    Console.WriteLine("Seu número é " + numjogador + ". Apostar? [S/N]\n\nDigite 0 para Sair.\nDigite 1 para Reiniciar.");
    string escolha = Console.ReadLine();

    // Aceita Aposta.
    if (escolha == "S" || escolha == "s" || escolha == "SIM" || escolha == "Sim" || escolha == "sim")
    {
        jogadas++;
        limite = 2;
        // Ninguem ganha pontos.
        if (numjogador == aposta)
        {
            Console.Clear();
            Console.WriteLine("O seu número ( " + numjogador + " ) é igual ao número da aposta ( " + aposta + " ), houve um empate nesta jogada.\n\nJogadas - " + jogadas + "\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n");
        }

        // Jogador ganha pontos.
        if (numjogador > aposta)
        {
            Console.Clear();
            pontos++;
            Console.WriteLine("Parabéns!!\nO seu número ( " + numjogador + " ) é MAIOR que o número da aposta ( " + aposta + " ), Você ganhou nesta jogada!\n\nJogadas - " + jogadas + "\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n");
        }

        // Computador ganha pontos.
        if (numjogador < aposta)
        {
            Console.Clear();
            pontospc++;
            Console.WriteLine("Que azar.\nO seu número ( " + numjogador + " ) é MENOR que o número da aposta ( " + aposta + " ), Você perdeu nesta jogada.\n\nJogadas - " + jogadas + "\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n");
        }
    }
    // Recusa aposta.
    else if (escolha == "N" || escolha == "n" || escolha == "NÃO" || escolha == "NAO" || escolha == "Nao" || escolha == "Não" || escolha == "nao" || escolha == "não")
    {
        Console.Clear();
        limite--;
        Console.WriteLine("Atenção!!\n\nVocê tem um Limite para Recusar apostas. Você pode recusar mais " + limite + " vez.\nSe você recusar mais do que 2 vezes, o Computador ganhará nesta jogada.\n");

        // Alcancou o limite.
        if (limite == 0)
        {
            Console.Clear();
            Console.WriteLine("Seu limite é " + limite + "! Você não pode mais recusar!\n\nSe você recusar mais 1 vez, o Computador ganhará nesta jogada.\n");
        }
        // Passou do limite.
        if (limite < 0)
        {
            Console.Clear();
            pontospc++;
            Console.WriteLine("Que pena.\nO limite foi excedido.\nO Computador ganhou.\n\nComputador: Esta foi fácil .\n\nJogadas - " + jogadas + "\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n");
            limite = 2;
        }
    }

    // Sair do jogo
    if (escolha == "0")
    {
        aceitar = false;
        //Vitoria
        if (pontos > pontospc)
        {
            Console.Clear();
            Console.WriteLine("Parabéns!!\nVocê venceu mais apostas.\n\nJogadas - " + jogadas + "\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.");
        }

        //Derrota
        else if (pontospc > pontos)
        {
            Console.Clear();
            Console.WriteLine("Infelizmente o Computador ganhou de você.\n\nJogadas - " + jogadas + "\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.");
        }

        //Empate
        else
        {
            Console.Clear();
            Console.WriteLine("Você e o Computador empataram.\n\nJogadas - " + jogadas + "\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.");
        }
    }

    // Reiniciar o jogo
    if (escolha == "1")
    {

        //Vitoria
        if (pontos > pontospc)
        {
            Console.Clear();
            Console.WriteLine("Parabéns!!\nVocê venceu mais apostas.\n\nJogadas - " + jogadas + "\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n\nNovo Jogo!!\n");
        }

        //Derrota
        else if (pontospc > pontos)
        {
            Console.Clear();
            Console.WriteLine("Infelizmente o Computador ganhou de você.\n\nJogadas - " + jogadas + "\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n\nNovo Jogo!!\n");
        }

        //Empate
        else
        {
            Console.Clear();
            Console.WriteLine("Você e o Computador empataram.\n\nJogadas - " + jogadas + "\nComputador - " + pontospc + " pts.\nJogador - " + pontos + " pts.\n\nNovo Jogo!!\n");
        }
        jogadas = 0;
        pontos = 0;
        pontospc = 0;
    }
} while (aceitar == true);