String num = args[0];
int n = int.Parse(num);
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(Math.Pow(2, i));
}