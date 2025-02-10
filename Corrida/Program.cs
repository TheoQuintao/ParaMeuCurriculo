using blibio;

List<char> Jogador1 = new List<char>{};
List<char> Jogador2 = new List<char>{};

int Tamanho = Facilitador.ValorInt();

Corrida.TamanhoCorrida(ref Jogador1,Tamanho);
Corrida.TamanhoCorrida(ref Jogador2,Tamanho);

Console.Clear();

Console.Write("Nome do primeiro Jogador: ");
string nome1 = Console.ReadLine()??"";

Console.Write("Nome do segundo Jogador: ");
string nome2 = Console.ReadLine()??"";

Console.Clear();

bool Vitoria = false;

while(true)
{
    Corrida.Imprimir(ref Jogador1,1,nome1);
    Corrida.Imprimir(ref Jogador2,2,nome2);

    Console.WriteLine($"Jogador {nome1} jogue o dado!!!!");
    Facilitador.Pausa();
    Corrida.Andar(ref Jogador1, Corrida.Dado(), Tamanho);
    Console.Clear();

    if(Jogador1.IndexOf('>')==Tamanho)
    {
        break;
    }

    Corrida.Imprimir(ref Jogador1,1,nome1);
    Corrida.Imprimir(ref Jogador2,2,nome2);

    Console.WriteLine($"Jogador {nome2} jogue o dado!!!!");
    Facilitador.Pausa();
    Corrida.Andar(ref Jogador2, Corrida.Dado(), Tamanho);
    Console.Clear();

    if(Jogador2.IndexOf('>')==Tamanho)
    {   
        Vitoria = true;
        break;
    }
}

if(Vitoria==false)
{
    Console.WriteLine($"{nome1} ganhou o jogo!!!");
}
else{
    Console.WriteLine($"{nome2} ganhou o jogo!!!");
}