namespace Functii
{
    public class Functie
    {
        public virtual double daValoare(Variabila var)
        {
            return 0;
        }

        public virtual Functie Deriveaza()
        {
            return new Const(0);
        }

        public override string ToString()
        {
            return "";
        }

        public string param;

    }

    public class Plus : Functie
    {
        public Functie e1, e2;

        public Plus(Functie e1, Functie e2)
        {
            this.e1 = e1;
            this.e2 = e2;
        }

        public override double daValoare(Variabila var)
        {
            return e1.daValoare(var) + e2.daValoare(var);
        }

        public override Functie Deriveaza()
        {
            return new Plus(e1.Deriveaza(), e2.Deriveaza());
        }

        public override string ToString()
        {

           return "(" + e1.ToString() + " + " + e2.ToString() + ")";
        
        }
    }
    public class Minus : Functie
    {
        public Functie e1, e2;

        public Minus(Functie e1, Functie e2)
        {
            this.e1 = e1;
            this.e2 = e2;
        }

        public override double daValoare(Variabila var)
        {
            return e1.daValoare(var) - e2.daValoare(var);
        }

        public override Functie Deriveaza()
        {
            return new Minus(e1.Deriveaza(), e2.Deriveaza());
        }

        public override string ToString()
        {
            return "(" + e1.ToString() + " - " + e2.ToString() + ")";
        }

    }
    public class Inmultit : Functie
    {
        public Functie e1, e2;
        
        public Inmultit(Functie e1, Functie e2)
        {
            this.e1 = e1;
            this.e2 = e2;
        }

        public override double daValoare(Variabila var)
        {
            return e1.daValoare(var) * e2.daValoare(var);
        }

        public override Functie Deriveaza()
        {  
            return new Plus(new Inmultit(e1, e2.Deriveaza()), new Inmultit(e1.Deriveaza(), e2));
        }

        public override string ToString()
        {
            return "(" + e1.ToString() + " * " + e2.ToString() + ")";
        }
    }

    public class Impartit : Functie
    {
        public Functie e1, e2;

        public Impartit(Functie e1, Functie e2)
        {
            this.e1 = e1;
            this.e2 = e2;
        }

        public override double daValoare(Variabila var)
        {
            return e1.daValoare(var) / e2.daValoare(var);
        }

        public override Functie Deriveaza()
        {
            return new Impartit(new Minus(new Inmultit(e1.Deriveaza(), e2), new Inmultit(e1, e2.Deriveaza())), new Inmultit(e2, e2));
        }

        public override string ToString()
        {
            return "(" + e1.ToString() + " / " + e2.ToString() + ")";
        }
    }

    public class Putere : Functie
    {
        public Functie e1, e2;

        public Putere(Functie e1,Functie e2 )
        {
            this.e1 = e1;
            this.e2 = e2;
        }

        public override double daValoare(Variabila var)
        {
            return Math.Pow(e1.daValoare(var) , e2.daValoare(var));
        }

        public override Functie Deriveaza()
        {
            if (e2 is Const)
            {
                if (e1 is Const)
                    return new Const(0);
                else
                    return new Inmultit(new Inmultit(new Const(e2.daValoare(null)), new Putere(e1, new Minus(e2, new Const(1)))), e1.Deriveaza());
            }
            else if(e1 is Const)
                return new Inmultit(new Putere(e1, e2), new Log(e1,10));
           return null;
        }

        public override string ToString()
        {
            return "(" + e1.ToString() + "^" + e2.ToString() + ")";
        }
    }

    public class Sin : Functie
    {
        public Functie e;

        public Sin(Functie e)
        {
            this.e = e;
        }

        public override double daValoare(Variabila var)
        {
            return Math.Sin(e.daValoare(var));
        }

        public override Functie Deriveaza()
        {
            return new Inmultit(new Cos(e), e.Deriveaza());
        }

        public override string ToString()
        {
            return "sin(" + e.ToString() + ")" ;
        }
    }

    public class Cos : Functie
    {
        public Functie e;

        public Cos(Functie e)
        {
            this.e = e;
        }

        public override double daValoare(Variabila var)
        {
            return Math.Cos(e.daValoare(var));
        }

        public override Functie Deriveaza()
        {
            return new Inmultit(new Const(-1),new Inmultit(new Sin(e), e.Deriveaza()));
        }

        public override string ToString()
        {
            return "cos(" + e.ToString() + ")";
        }
    }
    public class Tg : Functie
    {
        public Functie e;

        public Tg(Functie e)
        {
            this.e = e;
        }

        public override double daValoare(Variabila var)
        {
            return Math.Tan(e.daValoare(var));
        }

        public override Functie Deriveaza()
        {
            return new Impartit(e.Deriveaza(), new Inmultit(new Cos(e), new Cos(e)));
        }

        public override string ToString()
        {
            return "tg(" + e.ToString() + ")";
        }
    }

    public class Log : Functie
    {
        public Functie e;
        public double b;

        public Log(Functie e,double b)
        {
            this.e = e;
            this.b = b;
        }

        public override double daValoare(Variabila var)
        {
            return Math.Log(e.daValoare(var),b);      
        }

        public override Functie Deriveaza()
        {
            if (b == 10)
            {
                return new Impartit(new Const(1), e); 
            }
            else return new Impartit(new Const(1), new Inmultit(e, new Log(new Const(b), 10)));
            
        }

        public override string ToString()
        {
            if(b==10)
                return "(" + " ln " + e.ToString() + ")";
            else return "( " + "log_" + b + "(" + e.ToString() + ")" + " )";
        }
    }



    public class Const : Functie
    {
        public double c;

        public Const(double c)
        {
            this.c = c;
        }

        public override double daValoare(Variabila var)
        {
            return c;
        }

        public override Functie Deriveaza()
        {
            return new Const(0);
        }

        public override string ToString()
        {
            return c.ToString();
        }
    }

    public class Var : Functie
    {
        public string Variabila { get; set; }
        public string Parametru = null;

        public Var() { }

        public Var(string parametru)
        {
            Parametru = parametru;
        }

        public override double daValoare(Variabila var)
        {
            
                return var.Value;
            
        }

        public override Functie Deriveaza()
        {
            if(Parametru==null)
                return new Const(1);
            return new Const(0);
            
        }

        public override string ToString()
        {
            if (Parametru == null)
                return Variabila;
            return Parametru;
        }

    }

}
