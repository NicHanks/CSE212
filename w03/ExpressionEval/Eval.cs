namespace empty;

public class Eval
{
    public Eval()
    {
        // Nothing at this point
    }

    private bool IsNumber(string s)
    {
        return s.All(char.IsNumber);
    }

    public double EvalExpression(List<string> expression)
    {
        double answer = 0.0;

        // TODO - add you code here
        var stack = new Stack<string>();
        foreach (string i in expression)
        {
            stack.Push(i);
        }
        foreach (string i in stack)
        {
            var op2 = float.Parse(stack.Pop());
            var op1 = float.Parse(stack.Pop());
            if (i == "+") {
                answer = op2 + op1;
            } else if (i == "*")
             {
                answer = op2 * op1;
            } else if (i == "/") {
                answer = op1 / op2;
            }
        }
        return answer;
    }
    
}