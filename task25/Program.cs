Console.Clear();
Console.Write("insert an integer: ");
int n=int.Parse(Console.ReadLine()!);
Console.Write("insert a grade for the integer: ");
int pow=int.Parse(Console.ReadLine()!);
double output=n;
for(int i=1;i<pow;i++)output*=n;
Console.WriteLine(output);
