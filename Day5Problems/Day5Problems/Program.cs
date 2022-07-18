Console.WriteLine("Enter the value of N: ");
int num = int.Parse(Console.ReadLine());
for (int i = 2; 1 < num; i++)
{
    while (num % i == 0)
    {
        Console.WriteLine(i);
        num = num / i;
    }
}