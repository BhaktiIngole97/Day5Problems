
Console.WriteLine("Enter the value of N: ");
int n = int.Parse(Console.ReadLine());
double harmonicNo = 0.0;
for (double i = 1; i <= n; i++)
{
    harmonicNo = harmonicNo + (1 / i);
}
Console.WriteLine("Harmonic value of " + n + " is : " + harmonicNo);