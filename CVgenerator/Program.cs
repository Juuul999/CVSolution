namespace CVgenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Spørger om navn og gemmer det som name
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Question 1");
            Console.WriteLine("What is your first name");
            string name = Console.ReadLine();
            Console.WriteLine(name + " entered");
            Console.WriteLine("");

            // spørger om efternavn og gemmer det some nameTwo
            Console.WriteLine("Question 2");
            Console.WriteLine("What is your sir name?");
            string nameTwo = Console.ReadLine();
            Console.WriteLine(nameTwo + " entered");

            // Arrays til at gemme spørgsmål, svarmuligheder og korrekte svar
            string[] questions = new string[]
            {
            "Hvad er hovedstaden i Danmark?",
            "Hvad er 5 + 3?",
            "Hvem skrev 'Hamlet'?"
            };

            string[,] answerChoices = new string[,]
            {
            { "København", "Aarhus", "Odense", "Aalborg" },
            { "6", "7", "8", "9" },
            { "Shakespeare", "Ibsen", "Goethe", "Dostojewski" }
            };

            string[] correctAnswers = new string[]
            {
            "København",
            "8",
            "Shakespeare"
            };

            int score = 0;

            // Gennemgå alle spørgsmålene
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Spørgsmål {i + 1}: {questions[i]}");

                // Udskriv svarmulighederne for det nuværende spørgsmål
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"{j + 1}. {answerChoices[i, j]}");
                }

                // Bed brugeren om at vælge et svar
                Console.Write("Indtast nummeret på dit svar (1-4): ");
                int userAnswer = int.Parse(Console.ReadLine());

                // Tjek om svaret er korrekt
                if (answerChoices[i, userAnswer - 1] == correctAnswers[i])
                {
                    Console.WriteLine("Korrekt!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Forkert! Det korrekte svar er {correctAnswers[i]}.");
                }

                Console.WriteLine(); // Linjeskift for bedre læsbarhed
            }

            // Vis slutresultat
            Console.WriteLine(name + " " + nameTwo + $" du har scoret {score} ud af {questions.Length}.");
        }
    }
}
