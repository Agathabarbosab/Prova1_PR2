using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Menu

            float exercicio;
            Console.WriteLine(" ======Menu====== ");
            Console.WriteLine(" exercício 1 - Digite1 ");
            Console.WriteLine(" exercício 2 - Digite2 ");
            Console.WriteLine(" exercício 3 - Digite3 ");
            Console.WriteLine(" exercício 4 - Digite4 ");
            Console.WriteLine(" exercício 5 _ Digite5 ");
            Console.WriteLine(" exercício 6 - Digite6 ");
            Console.WriteLine(" exercício 7 - Digite7 ");

            exercicio = float.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 1:
                    int res;
                    Console.WriteLine("Digite um numero inteiro:");

                    int n = int.Parse(Console.ReadLine());

                    if(n < 0)
                    {
                        res = n * -1;
                        Console.WriteLine(res);

                    }
                    else
                        Console.WriteLine(n);


                    break;
               

                case 2:
                    Console.WriteLine("Digite um numero:");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero % 3 == 0 && numero % 5 == 0)
                    { 
                        Console.WriteLine("O numero digitado é multiplo de 3 e 5."); 
                    }



                    else if (numero % 4 == 0 && numero % 7 == 0)
                    { 
                        Console.WriteLine("O numero é multiplo de 4 e 7.");
                    }

                    else if ( numero % 3 == 0)
                    {
                        Console.WriteLine("O numero é multiplo de 3.");
                    }
                    else if (numero % 5 == 0)
                    {
                        Console.WriteLine("O numero é multiplo de 5.");
                    }
                    else if (numero % 4 == 0)
                    {
                        Console.WriteLine("O numero é multiplo de 4.");
                    }
                    else 
                    
                        Console.WriteLine("O numero é multiplo de 7.");
                    break;

                case 3:

                    Console.WriteLine("Digite o primeiro valor:");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor:");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro valor:");
                    int n3 = int.Parse(Console.ReadLine());

                    if (n1 > n2 && n1 > n3)
                    {
                        Console.WriteLine("O maior numero é:"+ n1);

                    }

                    else if (n2 > n1 && n2 > n3)
                    {
                        Console.WriteLine("O maior numero é:"+ n2);
                    }

                    else
                        Console.WriteLine("O maior numero é:"+ n3);


                    break;

                case 4:
                    Console.WriteLine("Escolha um dia da semana:");
                    Console.WriteLine("1-domingo");
                    Console.WriteLine("2-segunda-feira");
                    Console.WriteLine("3-terça-feira");
                    Console.WriteLine("4-quarta-feira"); 
                    Console.WriteLine("5-quinta-feira");
                    Console.WriteLine("6-sexta-feira");
                    Console.WriteLine("7-sabado");

                    int dia = int.Parse(Console.ReadLine());

                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("Domingo é dia de descanssar");

                            break;

                        case 2:
                            Console.WriteLine("Segunda temos aula das seguintes diciplinas:");
                            Console.WriteLine("Filosofia");
                            Console.WriteLine("Português");
                            Console.WriteLine("Matematica");
                            break;

                        case 3:
                            Console.WriteLine("Terça-feira temos aula das seguintes diciplinas:");
                            Console.WriteLine("Química");
                            Console.WriteLine("História");
                            Console.WriteLine("Inglês");
                            break;

                        case 4:
                            Console.WriteLine("Quarta-feira temos aula das seguintes matérias:");
                            Console.WriteLine("Biologia");
                            Console.WriteLine("Portugês");
                            Console.WriteLine("Programação");
                            break;

                            case 5:
                            Console.WriteLine("Quinta-feira temos as seguintes diciplinas:");
                            Console.WriteLine("Física");
                            Console.WriteLine("Redes");
                            Console.WriteLine("Sociologia");
                            break;

                        case 6:
                            Console.WriteLine("Sexta-feira temos aulas das seguintes diciplinas:");
                            Console.WriteLine("Geografia");
                            Console.WriteLine("Matematica");
                            Console.WriteLine("Banco de dados");
                            break;

                        case 7:
                            Console.WriteLine("Sabado é dia de assistir TV");
                            break;


                          
                    }


                    break;
                case 5:

                   



                   

                        break;
                case 6:
                     
                    Console.WriteLine("Digite o numero:");
                    int neme = int.Parse(Console.ReadLine());

                    
                    break;

                    default:
                    Console.WriteLine("Opção invalida");
                    break;


                    




                    
            }
            Console.ReadKey();
        }
    }
}
