namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Given the following code, change the code to implement:
            //
            // inferred typing
            // string interpolation
            // and the ternary operator
            
         // int answer = 4;
         //  string response;
         // if (answer < 9) 
         // {
         //     response = answer + " is less than nine";
         // }
         // else
         // {
         //     response = answer + " is greater than or equal to nine";
         // }   
         
         Console.WriteLine("This will say if the number is less than or greater than 4.");
         var readResult = false;
         
         while(!readResult)
         {
             Console.WriteLine("Enter in a number. Not a word mind you. A number.");
             readResult = int.TryParse(Console.ReadLine(), out int answer);

             Console.WriteLine((readResult) ? "\nThat's a number!" : "\nCome on that's not what I asked for.");

             var response = (answer < 9)
                 ? answer + " is less than nine"
                 : answer + " is greater than or equal to nine";

             Console.WriteLine((readResult) ? $"Did you know: {response}? Much smart. So knowledge. Wow." : "");
         }
         
        }
    }
}
