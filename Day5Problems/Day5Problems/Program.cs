int NumberOftimes = 5;
int heads = 0, tails = 0;
double hPercentage, tPercentage;
Random random = new Random();
for (int i = 0; i < NumberOftimes; i++)
{
    int coinFlip = random.Next(0, 2);
    if (coinFlip < 0.5)
    {
        Console.WriteLine(" Tails");
        tails++;
    }
    else
    {
        Console.WriteLine(" Heads");
        heads++;
    }
}
hPercentage = 100 * heads / NumberOftimes;
tPercentage = 100 * tails / NumberOftimes;
Console.WriteLine("Heads % : " + hPercentage + " vs Tails % : " + tPercentage);
