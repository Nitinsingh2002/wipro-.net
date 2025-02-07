namespace ClassLibrary1
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }


        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
                if (b == 0.0)
                {
                    throw new DivideByZeroException("Error: Division by zero is not allowed.");
            }

            return a / b; 
        }


        public virtual bool display()
        {
            return true;
        }
    }
}
