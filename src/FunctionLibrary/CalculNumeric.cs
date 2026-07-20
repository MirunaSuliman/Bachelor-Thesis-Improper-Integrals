namespace Functii
{
    public class MaximFunctie
    {
        public double Maxim(Functie f, double a, double b)
        {
            double max = double.MinValue;

            for (double x = a; x <= b; x += 0.01)
            {
                double valoare = f.daValoare(new Variabila(x));
                max = Math.Max(max, valoare);
            }

            return max;
        }
    }

    public class CalculNumeric
    {
        public virtual double Aproximare()
        {
            return 0;
        }
        public virtual double Eroare()
        {
            return 0;
        }
    }

    public class MetodaDreptunghiului:CalculNumeric
    {
        public double Aproximare(Functie f, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x = a + (i + 0.5) * h;
                sum += f.daValoare(new Variabila(x));
            }

            return h * sum;
        }

        public double Eroare(Functie f, double a, double b, double n)
        {
            double error;
            double M = 0; //max a<=x<=b |f'(x)|
            MaximFunctie max = new MaximFunctie();
            Functie fs = new Simplificare().Simplifica(f);
            Functie fd1 = fs.Deriveaza();
            Functie fd1s = new Simplificare().Simplifica(fd1);

            if (fd1s is Const)
            {
                if (fd1s.daValoare(null) != 0)
                    M = fd1s.daValoare(null);
            }
            else M = max.Maxim(fd1s, a, b);

            error = Math.Abs((Math.Pow((b - a), 1) * M) / (4*n));


            return error;
        }

    }

    public class MetodaTrapezelor:CalculNumeric
    {
        public double Aproximare(Functie f, double a, double b, int n)
        {
            double h = (b - a) / n;
            double I = (f.daValoare(new Variabila(a)) + f.daValoare(new Variabila(b)))/2 ;

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                I += f.daValoare(new Variabila(x));
            }

            I *= h;
            return I;
        }

        public double Eroare(Functie f,double a,double b,double n)
        {
            double error;
            double M=0; //max a<=x<=b |f''(x)|
            MaximFunctie max = new MaximFunctie();
            Functie fs = new Simplificare().Simplifica(f);
            Functie fd1 = fs.Deriveaza();
            Functie fd1s = new Simplificare().Simplifica(fd1);
            Functie fd2 = fd1s.Deriveaza();
            Functie fd2s = new Simplificare().Simplifica(fd2);

            if (fd2s is Const)
            {
                if (fd2s.daValoare(null) != 0)
                    M = fd2s.daValoare(null);
            }
            else M = max.Maxim(fd2s, a, b);

            error = Math.Abs((Math.Pow((b - a), 3) * M) / (12 * Math.Pow(n, 2)));
            
            return error;
        }

    }

    public class MetodaSimpson:CalculNumeric
    {
        public double Aproximare(Functie f, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = f.daValoare(new Variabila(a)) + f.daValoare(new Variabila(b));

            for (int i = 1; i < n; i += 2)
            {
                double x = a + i * h;
                sum += 4 * f.daValoare(new Variabila(x));
            }

            for (int i = 2; i < n; i += 2)
            {
                double x = a + i * h;
                sum += 2 * f.daValoare(new Variabila(x));
            }

            return (h / 3) * sum;
        }

        public double Eroare(Functie f, double a, double b, double n)
        {
            double error;
            double M = 0; //max a<=x<=b |f^(4)(x)|
            MaximFunctie max = new MaximFunctie();
            Functie fs = new Simplificare().Simplifica(f);
            Functie fd1 = fs.Deriveaza();
            Functie fd1s = new Simplificare().Simplifica(fd1);
            Functie fd2 = fd1s.Deriveaza();
            Functie fd2s = new Simplificare().Simplifica(fd2);
            Functie fd3 = fd2s.Deriveaza();
            Functie fd3s = new Simplificare().Simplifica(fd3);
            Functie fd4= fd3s.Deriveaza();
            Functie fd4s = new Simplificare().Simplifica(fd4);

            if (fd4s is Const)
            {
                if (fd4s.daValoare(null) != 0)
                    M = fd4s.daValoare(null);
            }
            else M = max.Maxim(fd4s, a, b);
            
           
            error = Math.Abs((Math.Pow((b - a), 5) * M) / (2880 * Math.Pow(n, 4)));

            return error;
        }
    }
}
