Console.WriteLine("enter the number");
long N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N; i++)
{
    double powerOfTwo = Math.Pow(2, i);
    Console.WriteLine( "Power of Two : " +powerOfTwo);
}