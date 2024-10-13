namespace QESolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(x-1)(x-2) = 0 -> 1x2-3x+2
            QE qe = new QE();
            qe.A = 1;
            qe.B = -3;
            qe.C = 2;

            if (qe.GetSolNum() >= 0) 
            {
                double x1, x2;
                x1 = qe.GetResult().X1;
                x2 = qe.GetResult().X2;
                Console.WriteLine($"x1: {x1}, x2: {x2}");
            }
        }
    }

    class QE
    {
        //Property definiálása, azaz kívülről változtathatóak
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        //Field, ez csak belülről használható
        double d;

        private void GetD()
        {
            d = B * B - 4 * A * C;
        }

        public int GetSolNum()
        {
            GetD();
            switch (d)
            {
                case < 0:
                    return 0;
                case < 1: 
                    return 1;
                default:
                    return 2;
            }
        }

        public (double X1, double X2) GetResult()
        {
            double x1, x2;
            GetD();
            x1 = (-B + Math.Sqrt(d)) / 2 * A;
            x2 = (-B - Math.Sqrt(d)) / 2 * A;
            return (x1, x2);
        }
    }
}
