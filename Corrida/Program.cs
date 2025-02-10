using blibio;

List<char> Jogador1 = new List<char>{};
List<char> Jogador2 = new List<char>{};

int Tamanho = Facilitador.ValorInt();

Corrida.TamanhoCorrida(ref Jogador1,Tamanho);
Corrida.TamanhoCorrida(ref Jogador2,Tamanho);

while(true)
{
    Console.Clear();

    Corrida.Imprimir(ref Jogador1,1);
    Corrida.Imprimir(ref Jogador2,2);

    Console.WriteLine("Jogador vermelho jogue o dado!!!!");
    Facilitador.Pausa();
    Corrida.Andar(ref Jogador1, Corrida.Dado());

}