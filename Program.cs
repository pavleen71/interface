using System.Diagnostics.CodeAnalysis;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x=new int[5] {1,3,4,6,7};
            int sum = 0;
            for(int i = 0; i < x.Length; i++)
            {
                
                Console.WriteLine(x[i]);
                sum = x[0] + x[x.Length - 1] + x[(x.Length) / 2];
               

            }
            Console.WriteLine(sum);

        }
    }
}