namespace StopwatchEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ListasMuvelet().Vegrehajt();
            new HalmazMuvelet().Vegrehajt();
            //abban az esetben ha kellenek paraméterek akkor azt a konstruktornak
            //kell átadni, ő fogja eltárolni.
        }
    }
}
