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
selecaodeclasse:
string ClasseEscolhida = Console.ReadLine();
switch(ClasseEscolhida)
{
    case "Combatente":

    break;
    case "Especialista":

    break;
    case "Ocultista":

    break;
    default:
        Console.Write("Escreva o nome corretamente: ");
        goto selecaodeclasse;
}

//Definição dos pontos de atributos

int Força = 1,
    Agilidade = 1,
    Vigor = 1,
    Presença = 1,
    Intelecto = 1;

Console.WriteLine("Agora escolheremos seus pontos de atributos");
for(int pontos = 4;pontos >= 0;pontos--)
{
    Console.WriteLine($"Força = {Força}");
    Console.WriteLine($"Agilidade = {Agilidade}");
    Console.WriteLine($"Vigor = {Vigor}");
    Console.WriteLine($"Presença = {Presença}");
    Console.WriteLine($"Intelecto = {Intelecto}");
    Console.Write("Deseja adicionar 1 ponto a qual atributo? ");
}

//Criação da ficha por NEX