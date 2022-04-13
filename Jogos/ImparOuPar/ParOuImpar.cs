int pontos = 0, pontospc = 0;
bool jogar = true;
while (jogar == true)
{
    Console.WriteLine("Escolha:\n1 - Ímpar\n2 - Par\n0 - Sair\n3 - Reiniciar");
    int escolha = System.Convert.ToInt16(Console.ReadLine());

    Random gerador = new Random();
    int resultado = gerador.Next(0,1000);

    // Escolhas Impares
    if (escolha == 1 && resultado % 2 != 0)
    {
        Console.Clear();
        Console.WriteLine("Parabéns!\nO número sorteado - " + resultado + " - é Ímpar!");
        pontos++;
        Console.WriteLine("\nComputador = " + pontospc + "\nJogador = " + pontos + "\n\n");
    }

    if (escolha == 1 && resultado % 2 == 0)
    {
        Console.Clear();
        Console.WriteLine("O Resultado (" + resultado + ") deu Par, infelizmente sua escolha foi Ímpar.\nTente ganhar do Computador!");
        pontospc++;
        Console.WriteLine("\nComputador = " + pontospc + "\nJogador = " + pontos + "\n\n");
    }

    // Escolhas Pares
    if (escolha == 2 && resultado % 2 == 0)
    {
        Console.Clear();
        Console.WriteLine("Parabéns!\nO número sorteado - " + resultado + " - é Par!");
        pontos++;
        Console.WriteLine("\nComputador = " + pontospc + "\nJogador = " + pontos + "\n\n");
    }

    if (escolha == 2 && resultado % 2 != 0)
    {
        Console.Clear();
        Console.WriteLine("O Resultado (" + resultado + ") deu Ímpar, infelizmente sua escolha foi Par.\nTente ganhar do Computador!");
        pontospc++;
        Console.WriteLine("\nComputador = " + pontospc + "\nJogador = " + pontos + "\n\n");
    }

    // Metodo de Saida
    if (escolha == 0)
    {
        jogar = false;
        if (pontos > pontospc)
        {
            Console.Clear();
            Console.WriteLine("Parabéns, você ganhou este jogo!!\nComputador = " + pontospc + "\nJogador = " + pontos + "\n\n");
        }
        else if (pontospc > pontos)
        {
            Console.Clear();
            Console.WriteLine("Infelizmente você perdeu o  jogo.\nComputador = " + pontospc + "\nJogador = " + pontos + "\n\n");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Houve um empate!.\nComputador = " + pontospc + "\nJogador = " + pontos + "\n\n");
        }
    }

    // Metodo de Reiniciar
    if (escolha == 3)
    {
        if (pontos > pontospc)
        {
            Console.Clear();
            Console.WriteLine("Parabéns, você ganhou este jogo!!\nComputador = " + pontospc + "\nJogador = " + pontos + "\n\nNovo jogo!!\n");
        }
        else if (pontospc > pontos)
        {
            Console.Clear();
            Console.WriteLine("Infelizmente você perdeu o  jogo.\nComputador = " + pontospc + "\nJogador = " + pontos + "\n\nNovo jogo!!\n");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Houve um empate!.\nComputador = " + pontospc + "\nJogador = " + pontos + "\n\nNovo jogo!\n");
        }
        pontos = 0;
        pontospc = 0;
    }

    //Controle de Opções
    else if (escolha < 0 || escolha > 3)
    {
        Console.Clear();
        Console.WriteLine("Escolha uma opção disponível.\n\n");
    }
}
