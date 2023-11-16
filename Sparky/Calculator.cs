namespace Sparky;

public class Calculator
{
    public int AddNumbers(int a, int b) => a + b;

    public int SubtractNumbers(int a, int b) => a - b;

    public int MultiplyNumbers(int a, int b) => a * b;

    public int DivideNumbers(int a, int b) => a / b;

    public int ModuloNumbers(int a, int b) => a % b;

    public int PowerNumbers(int a, int b) => (int)Math.Pow(a, b);

    public int SquareRootNumber(int a) => (int)Math.Sqrt(a);

    public int SquareNumber(int a) => a * a;

    public int CubeNumber(int a) => a * a * a;

    public int FactorialNumber(int a)
    {
        int result = 1;
        for (int i = 1; i <= a; i++)
        {
            result *= i;
        }
        return result;
    }

    public int FibonacciNumber(int a)
    {
        int result = 0;
        int previous = 1;
        for (int i = 0; i < a; i++)
        {
            int temp = result;
            result = previous;
            previous = temp + previous;
        }
        return result;
    }

    public bool IsOddNumber(int a) => a % 2 != 0;

    public bool IsEvenNumber(int a) => a % 2 == 0;

    public bool IsPrimeNumber(int a)
    {
        if (a <= 1)
        {
            return false;
        }
        for (int i = 2; i < a; i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
