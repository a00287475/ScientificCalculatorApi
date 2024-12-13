namespace ScientificCalculatorApi.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero.");
        public double SquareRoot(double a) => Math.Sqrt(a);
        public double Exponent(double baseValue, double exponent) => Math.Pow(baseValue, exponent);
        public double Percentage(double value, double total) => (value / total) * 100;
        public double Modulus(double a, double b) => a % b;
        public long Factorial(int number)
        {
            if (number < 0) throw new ArgumentException("Number must be non-negative.");
            return number == 0 ? 1 : number * Factorial(number - 1);
        }
        public double CubeRoot(double a) => Math.Cbrt(a);
    }
}

