namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite subject in school?");
            
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math? Nice.");
                    break;
                case "english":
                    Console.WriteLine("English? Nice.");
                    break;
                case "history":
                    Console.WriteLine("History? Nice.");
                    break;
                case "science":
                    Console.WriteLine("Science? Nice.");
                    break;
                case "psychology":
                    Console.WriteLine("Psychology? Nice.");
                    break;
                default:
                    Console.WriteLine($"{subject}!!! Nice.");
                    break;
            }
        }
    }
}