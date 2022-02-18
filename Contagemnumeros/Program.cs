using System;

namespace Contagemnumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite os numeros!!");
            string[] strnumeros = Console.ReadLine().Split(' ');
            int[] numeros = new int[4];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(strnumeros[i]);
            }
            for(int i = 0;i < numeros.Length;i++)
            {
                Console.WriteLine("{0}, {0], {0} e {0}", strnumeros[i], strnumeros[0], strnumeros[1], strnumeros[2]);
            }
            
            

        
        
        
        
        
          Console.ReadLine();
        }
    }
}
