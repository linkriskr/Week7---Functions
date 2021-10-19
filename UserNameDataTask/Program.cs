using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnimi tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib 3, siis kuvatkase kasutaja eesnime pikkus

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number vahemikus 1-3:");
            int userNumber = Convert.ToInt32(Console.ReadLine());


            if (userNumber == 1)
            {
                for (int i = userName.Length - 1; i >= 0; i--)
                {
                    Console.Write(userName[i]);
                }
            }
            if (userNumber == 2)
            {
                    Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}.");
            }
            if (userNumber == 3)
            {
                Console.WriteLine($"Sinu eesnime pikkus on {userName.Length} tähte.");
            }
        }
    }
}
