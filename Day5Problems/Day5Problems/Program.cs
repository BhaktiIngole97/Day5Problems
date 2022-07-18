Console.WriteLine("Enter 3 numbers:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if ((num1 > num2) && (num1 > num3))
{
    Console.WriteLine("Number 1 is greater no.");
}
else if ((num2 > num3) && (num2 > num3))
{
    Console.WriteLine("Number 2 is greater no.");
}
else
{
    Console.WriteLine("Number 3 is greater no.");
}