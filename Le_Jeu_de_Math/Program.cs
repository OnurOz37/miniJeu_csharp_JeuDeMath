using System;

namespace Le_Jeu_de_Math
{
    class Program
    {
        enum e_Operateur
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SOUSTRACTION = 3
        }
         
        static void Main(string[] args)
        {
            
            const int NOMBRE_Min = 1;
            const int NOMBRE_Max = 10;
            const int nbQuestions = 10; 
            int points = 0;

            for (int i = 0; i < nbQuestions; i++)
            {
                Console.WriteLine("Question n° " + (i + 1) + "/" + nbQuestions);
                bool bonneReponse = PoserQuestion(NOMBRE_Min, NOMBRE_Max);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nombre de points = " + points + "/" + nbQuestions);
            float moyenne = nbQuestions / 2;
            if (points == nbQuestions)
            {
                Console.WriteLine("Excellent");
            }
            else if (points == 0)
            {
                Console.WriteLine("Révisez vos maths");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("Pas mal");
            }
            else if (points < moyenne)
            {
                Console.WriteLine("Peut mieux faire");
            }

            Console.WriteLine("Appuyer sur une touche pour quitter");
            Console.ReadKey();

        }
        static bool PoserQuestion(int Min, int Max)
        {
            Random rand = new Random();
            int reponseInt = 0;

            while (true)
            {
                int a = rand.Next(Min, Max + 1);
                int b = rand.Next(Min, Max + 1);
                e_Operateur o = (e_Operateur)rand.Next(1, 4); 
                int resultatAttendu;

                switch (o)
                {
                    case e_Operateur.ADDITION://=if (o==e_operateur.addition)
                        Console.Write("Combien fait : " + a + " + " + b + " ? ");
                        resultatAttendu = a + b;
                        break;
                    case e_Operateur.MULTIPLICATION:
                        Console.Write("Combien fait : " + a + " x " + b + " ? ");
                        resultatAttendu = a * b;
                        break;
                    case e_Operateur.SOUSTRACTION:
                        Console.Write("Combien fait : " + a + " - " + b + " ? ");
                        resultatAttendu = a - b;
                        break;
                    default:
                        Console.WriteLine("ERROR: Operateur Inconnu");
                        return false;
                       
                }
             

                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    if (reponseInt == resultatAttendu)
                    {

                        return true;
                    }
                    return false;
                }
                catch
                {

                    Console.WriteLine("ERROR : Vous devez rentrer un nombre "); ;
                }
            }

        }
    }
}
