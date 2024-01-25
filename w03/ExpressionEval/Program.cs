namespace empty;

 internal class Program
 {
     public static void TestEval(List<String> expression)
     {
         Eval eval = new Eval();
         double answer = eval.EvalExpression((expression));
         Console.WriteLine($"Expression: {String.Join(", ", expression)} == {answer}");
     }
     
     static void Main(string[] args)
     {
         TestEval(new List<string>() { "3", "4", "+"});
         TestEval(new List<string>() { "3", "4", "+", "10", "*"});
         TestEval(new List<string>() { "3", "4", "/", "10", "-"});
         TestEval(new List<string>() { "3", "4", "/", "10", "-", "100", "+", "3", "/"});
     }
 }
 