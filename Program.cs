// Sortear um numero aleatório
Random aleatorio = new Random();
int numeroSorteado = aleatorio.Next(0, 100);

// Perguntar o nome do jogador
Console.WriteLine("Bem vindo ao Sort5000!");
Console.WriteLine("Qual o seu nome jogador?");
string nome = Console.ReadLine();

// Perguntar o primeiro palpite
Console.WriteLine("Você possui três chances para acertar o numero entre 0 e 100");
Console.WriteLine("Boa sorte!");
Console.WriteLine($"{nome}, qual o primeiro palpite?");
int palpite = int.Parse(Console.ReadLine());

// O palpite está correto?
if (palpite == numeroSorteado)
{
    // Acertou
    Console.WriteLine("Parabéns! Você só pode ter roubado!");
    // parar o meu programa
    return;
}
else
{
    // Errou
    Console.WriteLine("Palpite errado!");
    if (palpite > numeroSorteado)
    {
        Console.WriteLine("Seu palpite é MAIOR!");
    }
    else
    {
        Console.WriteLine("Seu palpite é MENOR!");
    }
}

Console.WriteLine($"{nome}, qual o segundo palpite?");
palpite = int.Parse(Console.ReadLine());

// O palpite está correto?
if (palpite == numeroSorteado)
{
    // Acertou
    Console.WriteLine("Parabéns! Você só pode ter roubado!");
    // parar o meu programa
    return;
}
else
{
    // Errou
    Console.WriteLine("Palpite errado!");
    if (palpite > numeroSorteado)
    {
        Console.WriteLine("Seu palpite é MAIOR!");
    }
    else
    {
        Console.WriteLine("Seu palpite é MENOR!");
    }
}

Console.WriteLine($"{nome}, qual o ultimo palpite?");
palpite = int.Parse(Console.ReadLine());

// O palpite está correto?
if (palpite == numeroSorteado)
{
    // Acertou
    Console.WriteLine("Parabéns! Não fez mais que sua obrigação!");
    // parar o meu programa
    return;
}
else
{
    Console.WriteLine("Você perdeu, eu sabia desde o inicio.");
    Console.WriteLine($"O número sorteado era {numeroSorteado}");
    Console.WriteLine("Fim de jogo!");
}