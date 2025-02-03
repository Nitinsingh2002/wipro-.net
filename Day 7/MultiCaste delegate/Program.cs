
namespace MultiCaste_delegate {
    internal class Program
    {
        public delegate void MathOpDel(int c, int d);
        private static void Main(string[] args)
        {

            //creating instance of delegate
            MathOpDel mt = new MathOpDel(MathOpe.Add);


            //multicaste delegate 
            mt += MathOpe.Sub;
            mt += MathOpe.Mul;
            mt += MathOpe.Div;
            mt(10, 20);



        }

    }
}