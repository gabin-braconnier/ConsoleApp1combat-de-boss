int vieHero = 100;
int vieBoss = 150;
int tour = 1;

while (vieHero > 0 && vieBoss > 0)
{
    Console.WriteLine($"Tour {tour}:");
    Console.WriteLine($"Vie du héros: {vieHero}");
    Console.WriteLine($"Vie du boss: {vieBoss}");
    Random random = new Random();
int degatsHero = random.Next(10, 26); // Dégâts aléatoires entre 10 et 25;
    vieBoss -= degatsHero;
    Console.WriteLine($"Le héros inflige {degatsHero} points de dégâts au boss.");
    if (vieBoss <= 0)
    {
        Console.WriteLine("Le héros a vaincu le boss !");
        break;
    }
    int degatsBoss = random.Next(5, 16); // Dégâts aléatoires entre 5 et 15
    vieHero -= degatsBoss;
    Console.WriteLine($"Le boss inflige {degatsBoss} points de dégâts au héros.");
    if (vieHero <= 0)
    {
        Console.WriteLine("Le boss a vaincu le héros !");
        break;
    }
    tour++;
}