namespace ScientificCalculatorApi.Services
{
    public interface ICalculatorService
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
        double SquareRoot(double a);
        double Exponent(double baseValue, double exponent);
        double Percentage(double value, double total);
        double Modulus(double a, double b);
        long Factorial(int number);
        double CubeRoot(double a);
    }

}
