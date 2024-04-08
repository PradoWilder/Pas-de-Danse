


namespace pasDeDanse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[32]; // Création du tableau moves de taille 32

            Console.WriteLine("Entrez les pas de danse (avec \"done\" pour terminer) :");

            // Boucle pour saisir les pas de danse
            int index = 0;
            string input;
            do
            {
                input = Console.ReadLine();

                if (input.ToLower() != "done")
                {
                    moves[index] = input;
                    index++;
                }

            } while (input.ToLower() != "done" && index < 32);

            // Demander le nombre d'itérations
            Console.Write("Entrez le nombre d'itérations : ");
            int iterations = Convert.ToInt32(Console.ReadLine());

            // Répéter la suite de pas le nombre d'itérations spécifié
            Console.WriteLine("\nVoici la suite de pas répétée {0} fois :", iterations);
            for (int i = 0; i < iterations; i++)
            {
                foreach (string move in moves)
                {
                    if (move != null)
                    {
                        Console.Write(move + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}