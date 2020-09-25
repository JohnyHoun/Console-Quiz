using System;
using System.Runtime.ConstrainedExecution;

namespace Console_Quiz
{
    class Program
    {
        public static int montante = 5;
        
        
        static void Main()
        {
            //Questão 1

            Console.WriteLine("Perguntas Gerais Sobre o Mundo");
            Console.WriteLine("Pergunta 1:");
            Console.WriteLine("Qual a montanha mais alta do Brasil ?");
            Console.WriteLine("a) Pico da Neblina");
            Console.WriteLine("b) Pico da Bandeira");
            Console.WriteLine("c) Monte Roraima");
            Console.WriteLine("d) Pico Paraná");
            Console.Write("Resposta:");

            string montanha = Console.ReadLine();

            if (montanha == "a")
            {
                Console.WriteLine("Acertou ! :)");
            }
            else
            {
                Console.WriteLine("Errou ! :(");
                montante = montante - 1;
            }

            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            //Console.TreatControlCAsInput = true;
         
            Console.WriteLine("Aperte Enter para continuar. \n");
            do
            {
                cki = Console.ReadKey();
                               
            } while (cki.Key != ConsoleKey.Enter);

            Console.Clear();

            // Questão 2:

            Console.WriteLine("Pergunta 2:");
            Console.WriteLine("Qual a divisão usada nos planetas do Sistema Solar ?");
            Console.WriteLine("a) Quentes e Frios");
            Console.WriteLine("b) Rochosos e Gasosos");
            Console.WriteLine("c) Rochosos e Polares");
            Console.WriteLine("d) Gasosos e Quentes");
            Console.Write("Resposta:");

            string divisao = Console.ReadLine();

            if (divisao == "b")
            {
                Console.WriteLine("Acertou ! :)");
                
            }
            else
            {
                Console.WriteLine("Errou ! :(");
                montante = montante - 1;
            }

            ConsoleKeyInfo ckj;
            // Prevent example from ending if CTL+C is pressed.
            //Console.TreatControlCAsInput = true;

            Console.WriteLine("Aperte Enter para continuar. \n");
            do
            {
                ckj = Console.ReadKey();

            } while (ckj.Key != ConsoleKey.Enter);

            Console.Clear();

            // Questão 3:

            Console.WriteLine("Pergunta 3:");
            Console.WriteLine("Porque os Flamingos são Rosas ?");
            Console.WriteLine("a) Eles se esfregam em árvores rosas");
            Console.WriteLine("b) Por comer camarões e algas vermelhas");
            Console.WriteLine("c) O sol altera a cor de suas penas");
            Console.WriteLine("d) Eles são cobertos de uma alga rosa");
            Console.Write("Resposta:");

            string razao = Console.ReadLine();

            if (razao == "b")
            {
                Console.WriteLine("Acertou ! :)");
                
            }
            else
            {
                Console.WriteLine("Errou ! :(");
                montante = montante - 1;
            }

            ConsoleKeyInfo ckk;
            // Prevent example from ending if CTL+C is pressed.
            //Console.TreatControlCAsInput = true;

            Console.WriteLine("Aperte Enter para continuar. \n");
            do
            {
                ckk = Console.ReadKey();

            } while (ckk.Key != ConsoleKey.Enter);

            Console.Clear();

            // Questão 4:

            Console.WriteLine("Pergunta 4:");
            Console.WriteLine("Qual tipo sanguíneo é considerado doador universal ?");
            Console.WriteLine("a) A-");
            Console.WriteLine("b) B+");
            Console.WriteLine("c) AB+");
            Console.WriteLine("d) O-");
            Console.Write("Resposta:");

            string sangue = Console.ReadLine();

            if (sangue == "d")
            {
                Console.WriteLine("Acertou ! :)");
                
            }
            else
            {
                Console.WriteLine("Errou ! :(");
                montante = montante - 1;
            }

            ConsoleKeyInfo cks;
            // Prevent example from ending if CTL+C is pressed.
            //Console.TreatControlCAsInput = true;

            Console.WriteLine("Aperte Enter para continuar. \n");
            do
            {
                cks = Console.ReadKey();

            } while (cks.Key != ConsoleKey.Enter);

            Console.Clear();

            // Questão 5:

            Console.WriteLine("Pergunta 5:");
            Console.WriteLine("Qual desses metais é liquido em temperatura ambiente ?");
            Console.WriteLine("a) Níquel");
            Console.WriteLine("b) Paládio");
            Console.WriteLine("c) Mercúrio");
            Console.WriteLine("d) Manganês");
            Console.Write("Resposta:");

            string metal = Console.ReadLine();

            if (metal == "c")
            {
                Console.WriteLine("Acertou ! :)");
                
            }
            else
            {
                Console.WriteLine("Errou ! :(");
                montante = montante - 1;
            }

            ConsoleKeyInfo ckm;
            // Prevent example from ending if CTL+C is pressed.
            //Console.TreatControlCAsInput = true;

            Console.WriteLine("Aperte Enter para continuar. \n");
            do
            {
                ckm = Console.ReadKey();

            } while (ckm.Key != ConsoleKey.Enter);

            Console.Clear();
            Console.WriteLine("Pontuação:");
            Console.WriteLine("Acertos: " + montante);
            montante = 5 - montante;
            Console.WriteLine("Erros: " + montante);
            Console.WriteLine("");

            Console.WriteLine("Obrigado por jogar!");
            Console.WriteLine("João Vitor D.G");
            Console.ReadKey();

            
        }
    }
}
