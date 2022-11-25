using System;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtração, Multiplicação, Divisão, Potência, Radical, Sair }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos fazer uma operação matemática?");
            bool sairPrograma = false;
            while (!sairPrograma)
            {                
                Console.WriteLine("Selecione alguma operação:");
                Console.WriteLine("1- Soma\n2- Subtração\n3- Multiplicação\n4- Divisão\n5- Potência\n6- Radical(raiz)\n7- Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());         
                
                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtração:
                        Sub();
                        break;
                    case Menu.Multiplicação:
                        Mult();
                        break;
                    case Menu.Divisão:
                        Div();
                        break;
                    case Menu.Potência:
                        Pot();
                        break;
                    case Menu.Radical:
                        Rad();
                        break;
                    case Menu.Sair:
                        sairPrograma = true;
                        break;
                    default:
                        Console.WriteLine("Por favor digite um número correspondente com o menu.");
                        Console.WriteLine("Aperte ENTER para voltar ao menu.");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            }           
        }

        static void Soma()
        {
            Console.WriteLine("Soma selecionada.");
            Console.WriteLine("Digite o primeiro número:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double b = double.Parse(Console.ReadLine());
            double resultado = a + b;
            Console.WriteLine($"O resultado da soma é {resultado}.");
            Console.WriteLine("Aperte ENTER para retornar ao menu.");
            Console.ReadLine();
        }

        static void Sub()
        {
            Console.WriteLine("Subtração selecionada.");
            Console.WriteLine("Digite o primeiro número:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double b = double.Parse(Console.ReadLine());
            double resultado = a - b;
            Console.WriteLine($"O resultado da subtração é {resultado}.");
            Console.WriteLine("Aperte ENTER para retornar ao menu.");
            Console.ReadLine();
        }

        static void Mult()
        {
            Console.WriteLine("Multiplicação selecionada.");
            Console.WriteLine("Digite o primeiro número:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double b = double.Parse(Console.ReadLine());
            double resultado = a * b;
            Console.WriteLine($"O resultado da multiplicação é {resultado}.");
            Console.WriteLine("Aperte ENTER para retornar ao menu.");
            Console.ReadLine();
        }

        static void Div()
        {
            Console.WriteLine("Divisão selecionada.");
            Console.WriteLine("Digite o primeiro número:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double b = double.Parse(Console.ReadLine());
            double resultado = a / b;
            Console.WriteLine($"O resultado da divisão é {resultado}.");
            Console.WriteLine("Aperte ENTER para retornar ao menu.");
            Console.ReadLine();
        }

        static void Pot()
        {
            Console.WriteLine("Potenciação selecionada.");
            Console.WriteLine("Digite a base:");
            double baseNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            double expo = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado da potenciação é {resultado}.");
            Console.WriteLine("Aperte ENTER para retornar ao menu.");
            Console.ReadLine();
        }

        static void Rad()
        {
            Console.WriteLine("Radicalização (raiz quadrada) selecionada.");
            Console.WriteLine("Digite o número:");
            double a = double.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado da soma é {resultado}.");
            Console.WriteLine("Aperte ENTER para retornar ao menu.");
            Console.ReadLine();
        }
    }
}