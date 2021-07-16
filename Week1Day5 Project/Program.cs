using System;

namespace Week1Day5_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***BENVENUTO A TOMBOLA***");
            Console.WriteLine("***Iniziamo***");
            Console.WriteLine("***Inserisci 5 numeri da 1 a 90.***");

            int n = 0;
            int random = 0;
            bool continua = true;

            while (continua)
            {
                while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 90)
                {
                    Console.WriteLine("*Devi inserire un numero positivo compreso tra 1-90. * \nRiprova:");

                }
                int[] numTombola = ScriviNumTombola(n); 

                StampaNumScelti(numTombola);

                Console.WriteLine($"***Premi *S* per continuare e vedere i numeri scelti dalla Tombola.***");//lho aggiunto giusto per farlo piú carino
                char S = char.Parse(Console.ReadLine());
                if (S == 'S')
                {
                    int[] m = RandNum(random);//TODO non stampa la array dei numeri , lho lasciato cosí perché altrimenti é sempre settolineato rosso

                    Console.WriteLine($"Ecco i numeri random \n{m}");
                }
                //if (n == random)
                //{
                //    Console.WriteLine("Hai fatto ambo!");

                //}
                //else if (n == random)
                //{
                //    Console.WriteLine("Hai fatto terno!");
                //}
                //else if (n == random)
                //{
                //    Console.WriteLine("Hai fatto quaterna!");
                //}
                //else
                //{
                //    Console.WriteLine("Hai fatto cinquinta!");
                //}
            }

            static int[] RandNum(int m)
            {

                int[] randomN = new int[20];
                for (int i = 0; i < randomN.Length; i++)
                {
                    Random RNum;
                    RNum = new Random();
                    int a = RNum.Next(1, 91);

                    randomN[i] = a;

                }
                return randomN;

            }


            static void StampaNumScelti(int[] numTombola)
            {
                Console.WriteLine("Ecco i numeri scelti da te:");
                for (int i = 0; i < numTombola.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {numTombola[i]}");

                }
                Console.WriteLine("***Adesso vengono estratti 20 numeri a caso.***");
                Console.WriteLine("***Vediamo se hai avuto fortuna.***");
            }


            static int[] ScriviNumTombola(int n) //scrive un numero in piu al inizio 
            {
                int[] numbers = new int[n=5];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Inserisci il tuo {i + 1} numero:");
                    int num = int.Parse(Console.ReadLine());

                    int scelto = Array.IndexOf(numbers, num);

                    if (scelto > -1)
                    {
                        Console.WriteLine("Non puoi scegliere due numeri uguali o zero. Inserisci altro:");
                        i--;
                    }
                    else
                    {
                        numbers[i] = num;
                    }
                    
                }
                return numbers;


            }



        }

      
    }
}
