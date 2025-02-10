namespace blibio
{
    class Corrida
    {
        public static void VerificarVitoria(ref List<char> jogador, int Valor)
        {
            
        }
        public static void Andar(
            ref List<Char> Jogador, 
            int Valor1,
            int Valor2)
        {
            int posiçãoDoCarro = Jogador.IndexOf('>');
            try
            {
                Jogador[posiçãoDoCarro+Valor1] = '>';
                Jogador[posiçãoDoCarro] = '-';
            }
            catch{
                Jogador[Valor2] = '>';
                Jogador[posiçãoDoCarro] = '-';
                return;
            }
        }
        public static void TamanhoCorrida(ref List<char> jogador, int valor)
        {
            for(int i = 0; i <= valor;i++)
            {
                if(i==0)
                {
                    jogador.Add('>');
                }
                else{
                   jogador.Add('-'); 
                }
            }
        }
        public static int Dado()
        {
            Random random = new Random{};
            int j = 50;
            for(int i=0;i<=10;i++)
            {
                Console.Write($"Resultado: {random.Next(1,7)}");
                Thread.Sleep(200+(i*j));
                Console.Clear();
            }
            int Resultado = random.Next(1,7);
            Console.WriteLine($"Resultado: {Resultado}");
            Facilitador.Pausa();
            return Resultado;
        }
        public static void Imprimir(ref List<char> jogador, int valor, string nome)
        {   
            Console.WriteLine($"Jogador: {nome}");
            switch(valor)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Blue;
                break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                break;
            }
            
            foreach(char i in jogador)
            {
                Console.Write(i);
            }
            Console.ResetColor();
            Console.WriteLine("\n");
        }
    }
    class Facilitador
    {
        public static int ValorInt()
        {
            return1:
            Console.Clear();
            Console.Write("Tamanho da pista: ");
            if(!int.TryParse(Console.ReadLine(), out int valor))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor invalido!!");
                Thread.Sleep(1500);
                Console.ResetColor();
                goto return1;
            }

            return valor;
        }
        public static void Pausa()
        {
            Console.WriteLine();
            Console.Write("ENTER para continuar");
            Console.ReadLine();

        }
    }
}