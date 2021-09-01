using System;

namespace IdadePessoa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mostrar pessoa mais velha");
            Console.WriteLine("Quantas pessoas você deseja comparar? ");
            int total = int.Parse(Console.ReadLine());

            string[] pessoa = new string[total];
            int[] val = new int[total];
            int cont = 0;

            for (int i = 0; i < total; i++)
            {
                Console.Write("Digite o nome da pessoa: ");
                pessoa[i] = Console.ReadLine();
                Console.Write("Digite a idade da pessoa: ");
                val[i] = int.Parse(Console.ReadLine());

                cont = val[0];

                if (val[i] != cont)
                {
                    cont = i;
                }

                else
                {
                    cont = val[0];
                }
                    
            }

            Console.WriteLine("A pessoa mais velha da lista é " + pessoa[cont] + " com " + val[cont] + " anos ");
        }
    }

}           

            
            

            
            
        
    

