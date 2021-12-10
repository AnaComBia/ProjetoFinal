using System;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 2;
            ExibeMenu();
            
            do
            {
                
                opcao = OpcaoUser();
                Contas(opcao);
            
            }while(opcao != 8);
        }

        static void ExibeMenu()
        {

            string menu =
            @" 
               |++++++++++++++++++++|
               |        Menu        |
               |++++++++++++++++++++|
               |                    |
               | 1- Soma            |
               | 2- Subtração       | 
               | 3- Divisão         |
               | 4- Multiplicação   |
               | 5- Radiciação      |
               | 6- Exponenciação   |
               | 7- Sobre           |
               | 8- Sair            |
               |                    |
               |++++++++++++++++++++|
            ";

            Console.WriteLine($"{menu}");

        }

        static int OpcaoUser()
        {
            Console.Write("\nEscolha uma das opções: ");
            string opcao1 = Console.ReadLine();

            int opcao;

            bool certo = Int32.TryParse(opcao1, out opcao);

            if (certo)
            {
                return opcao;
            }
            else
            {
               return -1;
            }
 
        }

        static void Contas (int opcao)
        {
            switch(opcao)
            {
                case 1: 
                 
                 //soma

                 Console.Write("\nInforme o Primeiro termo da soma: ");
                 decimal soma1 = Convert.ToDecimal(Console.ReadLine());

                 Console.Write("\nInforme o Segundo termo da soma: ");
                 decimal soma2 = Convert.ToDecimal(Console.ReadLine());

                 decimal soma = soma1 + soma2;

                 Console.WriteLine($"\n{soma1} + {soma2} = {soma}");

                   break;
                case 2:

                  //subtração

                  Console.Write("\nInforme o Primeiro termo da subtração: ");
                 decimal sub1 = Convert.ToDecimal(Console.ReadLine());

                 Console.Write("\nInforme o Segundo termo da subtração: ");
                 decimal sub2 = Convert.ToDecimal(Console.ReadLine());

                 decimal sub = sub1 - sub2;

                 Console.WriteLine($"\n{sub1} - {sub2} = {sub}");
                
                   break;
                case 3:

                  //divisão

                  Console.Write("\n Informe o numeardor: ");
                  decimal numerador = Convert.ToDecimal(Console.ReadLine());

                  Console.Write("\n Informe o denominador: ");
                  decimal denominador = Convert.ToDecimal(Console.ReadLine());

                  decimal divisao;

                  if (denominador > 0)
                  {

                    divisao = numerador / denominador;

                    Console.WriteLine($"\n{numerador} / {denominador} = {divisao}");

                  }
                  else
                  {
                     Console.WriteLine("\nDenominador Inválido :( ");
                  }

                   break;
                case 4:

                  // multiplicação

                  Console.Write("\nInforme o primeiro Fator: ");
                  decimal fator1 = Convert.ToDecimal(Console.ReadLine());

                  Console.Write("\nInforme o segundo Fator: ");
                  decimal fator2 = Convert.ToDecimal(Console.ReadLine());

                  decimal multi = fator1 * fator2;

                  Console.WriteLine($"\n{fator1} x {fator2} = {multi}");

                  break;
                case 5:

                  //radiciação

                  Console.Write("\nInforme o radicando: ");
                  double radicando = Convert.ToDouble(Console.ReadLine());

                  double raiz = Math.Sqrt(radicando);

                  Console.WriteLine($"A Raiz de {radicando} é: {raiz}");

                   break;
                case 6:

                  //exponenciação

                  Console.Write("\nInforme a Base: ");
                  double Base = Convert.ToDouble(Console.ReadLine());

                  Console.Write("\nInforme o expoente: ");
                  double expoente = Convert.ToDouble(Console.ReadLine());

                  double potencia = Math.Pow(Base, expoente);

                  Console.WriteLine($"\n{Base} elevado à {expoente} é: {potencia}");
                
                   break;
                case 7:
                
                  //sobre

                  string sobre =
                  @"
                     * Meu nome é Ana Beatriz, 
                     * Tenho 17 anos 
                     * Estou aprendendo programação a seis meses : )
                                      
                  ";

                  Console.WriteLine(sobre);

                   break;
                case 8:

                  //sair

                   Console.WriteLine("\nSair :) \n");
                
                   break;
                default:
                   Console.WriteLine("Opção não válida :( \n");
                   break;
        }

    }
}}
