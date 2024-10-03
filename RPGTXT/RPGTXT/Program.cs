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
string[] origens = {"Acadêmico","Agente de Saúde","Amnésico","Artista","Atleta","Chef","Criminoso","Cultista Arrependido","Desgarrado","Engenheiro","Executivo","Investigador","Lutador","Magnata","Mercenario","Militar","Operário","Policial","Religioso","Servidor Público","Teórico da Conspiração","T.I.","Trabalhador Rural","Trambiqueiro","universitário","Vitima"},
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
switch(oringemEscolhida)
{
    case "Acadêmico":

    break;
    case "Agente de Saúde":
        
    break;
    case "Amnésico":
        
    break;
    case "Artista":
        
    break;
    case "Atleta":
        
    break;
    case "Chef":
        
    break;
    case "Criminoso":
        
    break;
    case "Cultista Arrependido":
        
    break;
    case "Desgarrado":
        
    break;
    case "Engenheiro":
        
    break;
    case "Executivo":
        
    break;
    case "Investigador":
        
    break;
    case "Lutador":
        
    break;
    case "Magnata":
        
    break;
    case "Mercenário":
        
    break;
    case "Militar":
        
    break;
    case "Operário":
        
    break;
    case "Policial":
        
    break;
    case "Religioso":
        
    break;
    case "Servidor Público":
        
    break;
    case "Teórico da Conspiração":
        
    break;
    case "T.I.":
        
    break;
    case "Trabalhador Rural":
        
    break;
    case "Trambiqueiro":
        
    break;
    case "Universitário":
        
    break;
    case "Vítima":
        
    break;
    default:
        Console.WriteLine("Escreva o nome corretamente: ");
        goto selecaodeorigem;
}

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
Console.Write("\nEscreva o nome da classe escolhida:");
string ClasseEscolhida = Console.ReadLine();
switch(ClasseEscolhida)
{
    case "Combatente":

    break;
    case "Especialista":

    break;
    case "Ocultista":

    break;
}

//Definição dos pontos de atributos

int Força = 1,
    Agilidade = 1,
    Vigor = 1,
    Presença = 1,
    Intelecto = 1;

Console.WriteLine("Agora escolheremos seus pontos de atributos");
for(int pontos = 4;pontos == 0;pontos--)
{
    Console.WriteLine($"Força = {Força}");
    Console.WriteLine($"Agilidade = {Agilidade}");
    Console.WriteLine($"Vigor = {Vigor}");
    Console.WriteLine($"Presença = {Presença}");
    Console.WriteLine($"Intelecto = {Intelecto}");
    Console.Write("Deseja adicionar 1 ponto a qual atributo? ");
}

//Criação da ficha por NEX