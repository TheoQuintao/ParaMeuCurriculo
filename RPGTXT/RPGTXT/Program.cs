Console.Clear();

int largura = 39;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("=".PadLeft(largura, '='));
Console.WriteLine(" Bem vindo novo agente ao RPG.TXT");
Console.WriteLine("=".PadLeft(largura, '='));
Console.ResetColor();
Console.WriteLine("\nUm criador  de fichas de Ordem Paranormal V1.2");
Thread.Sleep(3000);
Console.Clear();

//Seleção de Origem

int Origem = 0;
string[] origens = {"Acadêmico","Agente de Saúde","Amnésico","Artista","Atleta","Chef","Criminoso","Cultista Arrependido","Desgarrado","Engenheiro","Executivo","Investigador","Lutador","Magnata","Mercenario","Militar","Operário","Policial","Religioso","Servidor Público","Teórico da Conspiração","T.I.","Trabalhador Rural","Trambiqueiro","universitário","Vítima"},
        pericias = {" Ciências e Investigação"," Intuição e Medicina"," Duas à escolha do mestre","Artes e Enganação","Acrobacia e Atletismo","Fortitude e Profissão (cozinheiro)","Crime e Furtividade","Ocultismo e Religião","Fortitude e Sobrevivência"," Profissão e Tecnologia","Diplomacia e Profissão"," Investigação e Percepção","Luta e Reflexos","Diplomacia e Pilotagem","Iniciativa e Intimidação"," Pontaria e Tática"," Fortitude e Profissão"," Percepção e Pontaria","Religião e Vontade","Intuição e Vontade"," Investigação e Ocultismo"," Investigação e Tecnologia","Adestramento e Sobrevivência","Crime e Enganação","Atualidades e Investigação"," Reflexos e Vontade"},
        poder = {"Saber é Poder","Técnica Medicinal","Vislumbres do Passado"," Magnum Opus","110%"," Ingrediente Secreto","O Crime Compensa","Traços do Outro Lado","Calejado","Ferramenta Favorita","Processo Otimizado","Faro para Pistas","Mão Pesada","Patrocinador da Ordem","Posição de Combate","Para Bellum","Ferramenta de Trabalho","Patrulha","Acalentar","Espírito Cívico","Eu Já Sabia","Motor de Busca","Desbravador","Impostor","Dedicação","Cicatrizes Psicológicas"};
Thread.Sleep(2000);
Console.WriteLine("Começaremos na seleção de Origem.");
Thread.Sleep(2000);
Console.WriteLine("Selecione uma das Origens abaixo escrevendo o nome dela:\n ");
foreach(string O in origens)
{
    Console.ResetColor();
    Console.WriteLine(O);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("-".PadLeft(23, '-'));
    Thread.Sleep(250);
}
Console.ResetColor();
Console.Write("Escreva o nome: ");
selecaodeorigem:
string oringemEscolhida = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
switch(oringemEscolhida)
{
    case "Acadêmico":
        Origem = 0;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Agente de Saúde":
        Origem = 1;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Amnésico":
        Origem = 2;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Artista":
        Origem = 3;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Atleta":
        Origem = 4;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Chef":
        Origem = 5;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Criminoso":
        Origem = 6;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Cultista Arrependido":
        Origem = 7;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Desgarrado":
        Origem = 8;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Engenheiro":
        Origem = 9;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Executivo":
        Origem = 10;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Investigador":
        Origem = 11;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Lutador":
        Origem = 12;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Magnata":
        Origem = 13;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Mercenário":
        Origem = 14;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Militar":
        Origem = 15;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Operário":
        Origem = 16;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Policial":
        Origem = 17;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Religioso":
        Origem = 18;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Servidor Público":
        Origem = 19;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Teórico da Conspiração":
        Origem = 20;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "T.I.":
        Origem = 21;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Trabalhador Rural":
        Origem = 22;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Trambiqueiro":
        Origem = 23;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Universitário":
        Origem = 24;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    case "Vítima":
        Origem = 25;
        Console.WriteLine($"\nVocê recebeu a habilidade: {poder[Origem]}");
    break;
    default:
        Console.Write("Escreva o nome corretamente: ");
    goto selecaodeorigem;
}
Thread.Sleep(2000);
Console.Clear();
Console.ResetColor();

//seleção de classe

int largurac = 20;
string[] classes = {"Combatente","Especialista","Ocultista"};
Console.WriteLine("\nAgora selecionaremos a classe do seu personagem");
Console.WriteLine("As classes são: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("-".PadLeft(largurac, '-'));
Console.WriteLine(classes[0]);
Console.WriteLine("-".PadLeft(largurac, '-'));
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("-".PadLeft(largurac, '-'));
Console.WriteLine(classes[1]);
Console.WriteLine("-".PadLeft(largurac, '-'));
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-".PadLeft(largurac, '-'));
Console.WriteLine(classes[2]);
Console.WriteLine("-".PadLeft(largurac, '-'));
Console.ResetColor();
Console.Write("\nEscreva o nome da classe escolhida: ");
int classe;
selecaodeclasse:
string ClasseEscolhida = Console.ReadLine();
switch(ClasseEscolhida)
{
    case "Combatente":
        classe = 0;
    break;
    case "Especialista":
        classe = 1;
    break;
    case "Ocultista":
        classe = 2;
    break;
    default:
        Console.Write("Escreva o nome corretamente: ");
    goto selecaodeclasse;
}
Thread.Sleep(2000);
Console.Clear();

//Definição dos pontos de atributos

Console.WriteLine("Agora escolheremos seus pontos de atributos");
Thread.Sleep(5000);
resetarpontos:
int Força = 1,
    Agilidade = 1,
    Vigor = 1,
    Presença = 1,
    Intelecto = 1;
bool reduzir = false,
    jareduziu = true;
for(int pontos = 3;pontos >= 0;pontos--)
{   
    selecaodepontos:
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Força = {Força}");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Agilidade = {Agilidade}");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Vigor = {Vigor}");
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine($"Presença = {Presença}");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Intelecto = {Intelecto}");
    Console.ResetColor();
    Console.WriteLine($"\nVocê possui {pontos+1} pontos para gastar");
    
    if(reduzir==false)
    {
        
        Console.Write("Você pode reduzir 1 valor para ganhar 1 ponto, Deseja fazer isso? (Sim) (Não) ");
        desejareduzir:
        string reduzirp = Console.ReadLine().ToLower();
        switch(reduzirp)
        {
            case "sim":
                Console.Write("Deseja reduzir qual atributo? ");
                pontos+=2;
                reduzir=true;
            break;
            case "não":
                Console.Write("Deseja adicionar 1 ponto a qual atributo? ");
            break;
            default:
                Console.Write("Escreva o corretamente: ");
            goto desejareduzir;
        }
    }
    else
    {
        Console.Write("Deseja adicionar 1 ponto a qual atributo? ");
    }
    string somaponto = Console.ReadLine();
    switch(somaponto)
    {
        case "Força":
            if(Força==3)
            {
                Console.Write("O maximo de pontos que pode ter em 1 atributo e 3");
                goto selecaodepontos;
            }
            else if(jareduziu==true & reduzir==true)
            {
                Força--;
                jareduziu=false;
            }
            else
                Força++;
        break;
        case "Agilidade":
            if(Agilidade==3)
                {
                    Console.Write("O maximo de pontos que pode ter em 1 atributo e 3");
                    goto selecaodepontos;
                }
                else if(jareduziu==true & reduzir==true)
                {
                    Agilidade--;
                    jareduziu=false;
                }
                else
                Agilidade++;
        break;
        case "Vigor":
            if(Vigor==3)
                {
                    Console.Write("O maximo de pontos que pode ter em 1 atributo e 3");
                    goto selecaodepontos;
                }
                else if(jareduziu==true & reduzir==true)
                {
                    Vigor--;
                    jareduziu=false;
                }
                else
                Vigor++;
        break;
        case "Presença":
            if(Presença==3)
                {
                    Console.Write("O maximo de pontos que pode ter em 1 atributo e 3");
                    goto selecaodepontos;
                }
                else if(jareduziu==true & reduzir==true)
                {
                    Presença--;
                    jareduziu=false;
                }
                else
                Presença++;
        break;
        case "Intelecto":
            if(Intelecto==3)
                {
                    Console.Write("O maximo de pontos que pode ter em 1 atributo e 3");
                    goto selecaodepontos;
                }
                else if(jareduziu==true & reduzir==true)
                {
                    Intelecto--;
                    jareduziu=false;
                }
                else
                Intelecto++;
        break;
        default:
            Console.Write("Escreva o nome corretamente: ");
        goto selecaodepontos;
    }
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;    
Console.WriteLine($"Força = {Força}");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Agilidade = {Agilidade}");
Console.ForegroundColor = ConsoleColor.DarkRed;    
Console.WriteLine($"Vigor = {Vigor}");    
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($"Presença = {Presença}");    
Console.ForegroundColor = ConsoleColor.Yellow;    
Console.WriteLine($"Intelecto = {Intelecto}");
Console.ResetColor();
Console.Write("\nDeseja resetar os pontos? (Sim) (Não) ");
resetarpont:
string resetarponto = Console.ReadLine().ToLower();
switch(resetarponto)
{
    case "sim":
    goto resetarpontos;
    case "não":
    break;
    default:
        Console.Write("Escreva corretamente: ");
    goto resetarpont;
}
//Claculando estatistacas
int[] VigorDeClasse = {20,16,12},
    PresençaDeClasse = {2,3,4},
    sanidade = {12,16,20};
int Vida = Vigor+VigorDeClasse[classe],
    PontosDePresença = Presença+PresençaDeClasse[classe];

// if(oringemEscolhida == "Cultista Arrependido")
// {
//     sanidade[classe]/=2;
// }

int sanidadevdd = sanidade[classe];
//Criação da ficha por NEX
coneme:
Console.Clear();
Console.Write("Escreva o nome do sue presonagem: ");
string nome = Console.ReadLine();
Console.Clear();
Console.Write($"O seu nome e: {nome} \n\nDeseja confirmar esse nome? (Sim)(Não) ");
conome:
string confirmarnome = Console.ReadLine().ToLower();
switch(confirmarnome)
{
    case "sim":
    break;
    case "não":
    goto coneme;
    default:
    goto conome;
}  

Console.Write($"Nome:{nome} NEX: 5% \n\nOrigem: {oringemEscolhida}\nClasse: {ClasseEscolhida} \nVida: {Vida}\nPontos de esforço: {PontosDePresença}\nSanidade: {sanidadevdd}");