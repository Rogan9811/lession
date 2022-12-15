Console.Write("Enter your first count: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your second count: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b == a * a)
{
    Console.WriteLine("yyeeess");
}
else if (a == b * b)
{
    Console.WriteLine("yyeeess");
}
else
{
    Console.WriteLine("noo");
}