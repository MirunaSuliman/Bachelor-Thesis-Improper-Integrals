namespace Functii
{
    class Program
    {
        static void Main(string[] args)
        {          
            Functie x = new Var();

            //Exemple de functii:

            // 2*x^2 + 3*x + 5 
            //Functie f = new Plus(new Plus(new Inmultit(new Const(2), new Inmultit(new Var(), new Var())), new Inmultit(new Const(3), new Var())), new Const(5));

            //x+x 
            // Functie f = new Plus(x, x);

            //cos(x)
            //Functie f = new Cos(new Var());

            //x^3 
            //Functie f = new Putere(x, 3);

            //x*1 
            //Functie f = new Inmultit(x, new Const(1));

            //x^5+2*sin(x) 
            //Functie f = new Plus(new Putere(x, 5), new Inmultit(new Const(2), new Sin(x)));

            //((1 - (3 * x)) * (11 + (5 * x))) 
            //Functie f = new Inmultit(new Minus(new Const(1), new Inmultit(new Const(3), x)), new Plus(new Const(11), new Inmultit(new Const(5), x)));

            //(x * (sin(x) * cos(x))) 
            //Functie f = new Inmultit(x, new Inmultit(new Sin(x), new Cos(x)));

            //x/0+2 
            //Functie f = new Plus(new Impartit(x, new Const (0)), new Const(2));

            //x+x+x 
            // Functie f = new Plus(new Plus(x, x),x);

            //((10 * x) + x)  
            //Functie f = new Plus(new Inmultit(new Const(10), x),x);

            //(((5 * x) + x) + ((7 * x) + x))  
            //Functie f = new Plus(new Plus(new Inmultit(new Const(5), x), x), new Plus(new Inmultit(new Const(7), x), x));

            //((5 * x) + x) + ((7 * x) + x)+((2*x)+x)  
            //Functie f = new Plus(new Plus(new Plus(new Inmultit(new Const(5), x), x), new Plus(new Inmultit(new Const(7), x), x)), new Plus(new Inmultit(new Const(2), x), x));

            //x^2*x  
            //Functie f = new Inmultit(new Putere(x, new Const(2)), x);

            //x * (x^2)  
            //Functie f = new Inmultit(x,new Putere(x, new Const(2)));

            //x^2*x^3  
            //Functie f = new Inmultit(new Putere(x, new Const(2)), new Putere(x,new Const(3)));

            //sin(x)*sin(x) 
            //Functie f = new Inmultit(new Sin(x), new Sin(x));

            //(2^x) 
            //Functie f = new Putere(new Const(2),x);

            //log_7(x) 
            //Functie f = new Log(x, 7);

            //e^x 
            //Functie f = new Putere(new Const(Math.E), x);

            //(sin(x) * (sin(x)^2)) 
            //Functie f =new Inmultit(new Sin(x),new Putere(new Sin(x),new Const(2)));

            // ((2 * sin(x)) - (5 * sin(x))) 
            //Functie f = new Minus(new Inmultit(new Const(2), new Sin(x)), new Inmultit(new Const(5), new Sin(x)));

            // (( log_2(x) ) - (2 * ( log_2(x) ))) 
            //Functie f = new Minus(new Log(x,2),new Inmultit(new Const(2),new Log(x,2)));


            //Var y= new Var();
            //y.Variabila = "y";

            //Var a = new Var("a");

            // ((y^2) * a) 
            //Functie f = new Inmultit(new Putere(y,new Const(2)),a);

            //  sin(((y^2) + a)) 
            //Functie f = new Sin(new Plus(new Putere(y, new Const(2)), a));

            // (a * ( log_8(y) )) 
            //Functie f = new Inmultit(a, new Log(y, 8));


            //Functie f=new Plus(new Putere(x,new Const(2)),new Inmultit(new Const(3),x));
            // Functie f = new Putere(x, new Const(6));

            Functie f = new Sin(new Putere(x, new Const(2)));

            //Functie f=new Impartit(new Const(1),new Putere(x,new Const(2)));

            //Functia simplificata     
            Functie fsimplificata = new Simplificare().Simplifica(f);         

            // Derivata 
            Functie fderivata = fsimplificata.Deriveaza();

            //Derivata simplificata
            Functie derivataSimplificata = new Simplificare().Simplifica(fderivata);

            Functie derivata2 = derivataSimplificata.Deriveaza();
            Functie derivata2s = new Simplificare().Simplifica(derivata2);

            //Console.WriteLine("Functia initiala: " + f.ToString());
            //Console.WriteLine("Functia simplificata: " + fsimplificata.ToString());
            //Console.WriteLine("Derivata: " + fderivata.ToString());
            //Console.WriteLine("Derivata simplificata: " + derivataSimplificata.ToString());

            //Console.ReadLine();

            MetodaDreptunghiului metodaDreptunghiului = new MetodaDreptunghiului();
            MetodaTrapezelor metodaTrapezelor = new MetodaTrapezelor();
            MetodaSimpson metodaSimpson = new MetodaSimpson();

            double a = 0;
            double b = 1e3;
            int n = 1000000;



            Console.WriteLine("Metoda Dreptunghiului: " + metodaDreptunghiului.Aproximare(f, a, b, n));
            Console.WriteLine("Metoda Trapezelor: " + metodaTrapezelor.Aproximare(f, a, b, n));
            Console.WriteLine("Metoda Simpson: " + metodaSimpson.Aproximare(f, a, b, n));

            Console.WriteLine("Eroare la Dreptunghi: " + metodaDreptunghiului.Eroare(f, a, b, n));

            Console.WriteLine("Eroarea la Trapez: " + metodaTrapezelor.Eroare(f,a,b,n));

            Console.WriteLine("Eroare la Simpson: " + metodaSimpson.Eroare(f, a, b, n));


        }
    }
}
