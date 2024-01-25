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
        // expression = { "3", "4", "+"}
        var stack = New stack<var>
        foreach (string i in expression)
        {
            //i = var.Parse();
            stack = stack.push(i);
        }
        foreach (var i in stack)
        {
            var op2 = stack.pop();
            var op1 = stack.pop();
            if (i == +) {
                answer = op2 + op1;
            } else if (i == *) {
                answer = op2 * op1;
            } else if (i == /) {
                answer = op1 / op2;
            }
        }
        return answer;
    }
    
}