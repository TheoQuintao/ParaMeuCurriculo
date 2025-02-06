List<char> Abc = new List<char>{};
for(char i='A';i<='Z';i++)
{
    Abc.Add(i);
}
return1:
Console.Clear();
Console.Write("digite um numero entre 1 e 26: ");
if(int.TryParse(Console.ReadLine(), out int valor) && valor <=26 && valor > 0)
{
    for(int i = valor; i <= 26; i++)
    {
        if(i==valor)
        {
            Console.Write(Abc[i-1]);
        }
        else{
            Console.Write(" - " + Abc[i-1]);
        }
    }
}
else{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor invalido!!");
    Thread.Sleep(1500);
    Console.ResetColor();
    goto return1;
}
