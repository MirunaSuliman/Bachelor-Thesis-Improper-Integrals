namespace Functii
{
    public class Variabila
    {
        double val;

        public Variabila(double val)
        {
            this.val = val;
        }

        public Variabila(char val)
        {
            this.val = val;
        }

        public double Value
        {
            set { val = value; }
            get { return val; }
        }

    }

   
}
