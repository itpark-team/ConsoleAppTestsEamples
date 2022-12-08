namespace ConsoleAppTestsEamples;

public class Calculator
{
    private double _a;
    private double _b;

    public Calculator(double a, double b)
    {
        _a = a;
        _b = b;
    }

    public double GetSum()
    {
        return _a + _b;
    }

    public double GetSub()
    {
        return _a - _b;
    }

    public double GetMul()
    {
        return _a * _b;
    }

    public double GetDiv()
    {
        if (_b == 0)
        {
            throw new Exception("division by zero");
        }

        return _a / _b;
    }

    public static double CalcExpression(string expression)
    {
        if (expression == null || expression == String.Empty)
        {
            return 0;
        }

        bool parseResult = double.TryParse(expression, out double result);

        if (parseResult)
        {
            return result;
        }

        string[] parts = expression.Split("+");

        return double.Parse(parts[0]) + double.Parse(parts[1]);
    }
}