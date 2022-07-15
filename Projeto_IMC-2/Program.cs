using System;

namespace Projeto_IMC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----> Índice de Massa Corporal (IMC) <----");

            Console.WriteLine("\n ---> Qual seu Nome?");
            string name = Console.ReadLine();

            Console.WriteLine("\n ---> Qual sua idade?");
            string age = Console.ReadLine();

            Console.WriteLine("\n ---> Qual o seu peso? (Use vírgula)");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n ---> Qual sua altura? (Use vírgula)");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            float imc = peso / (altura * altura);

            Console.WriteLine("\n Seu IMC é \n" + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("-> Você está Abaixo do Peso! Procure um Profissional.");
            }
            else if (imc < 25)
            {
                Console.WriteLine("-> Você está com o Peso Normal! ");
            }
            else if (imc < 30)
            {
                Console.WriteLine("-> Você está com Sobrepeso! Procure um Profissional.");
            }
            else if (imc >= 30)
            {
                Console.WriteLine("-> Você está Obeso! Procure um Profissional.");
            }
            else
            {
                Console.WriteLine("-> Ops, parece que deu um erro! Digite Novamente.");
            }
        }
    }
}