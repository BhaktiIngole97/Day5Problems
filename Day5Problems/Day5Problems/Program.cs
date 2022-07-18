char ch;
Console.WriteLine("Enter the letter:");
ch = Char.Parse(Console.ReadLine());
if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u') || (ch == 'A') || (ch == 'E') || (ch == 'I') || (ch == 'O') || (ch == 'U'))
{
    Console.WriteLine(ch + " is a Vowel.");
}
else
{
    Console.WriteLine(ch + " is a Consonant.");
}