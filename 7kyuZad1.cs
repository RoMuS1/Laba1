public class Kata
{
  public static double[] Multiples(int m, double n)
  {
    double[] multiples = new double[m];
    for (int i = 0; i < m; i++)
    {
         multiples[i] = n * (i + 1);
     }
     return multiples;
  }
}