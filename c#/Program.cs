using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result = 0;
            string operacao;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite a operação: ");
            operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case "+":
                result = num1 + num2;
                break;

                case "-":
                result = num1 - num2;
                break;

                case "*":
                result = num1 * num2;
                break;

                case "/":
                result = num1 / num2;
                break;


                default:
                Console.WriteLine("Operação inválida");
                break;
            }
            Console.WriteLine("{0} {1} {2} = {3}", num1, operacao, num2, result);
            Console.ReadKey(true);
        }
    }
}
