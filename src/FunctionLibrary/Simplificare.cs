namespace Functii
{
    public class Simplificare
    {

        public Functie Simplifica(Functie f)
        {
            // Not x ca o functie oarecare         
            
            if (f is Inmultit inmultit)
            {
                Functie e1 = Simplifica(inmultit.e1);
                Functie e2 = Simplifica(inmultit.e2);

                // cst + cst = cst
                if (e1 is Const && e2 is Const)
                {
                    double valoare = e1.daValoare(null) * e2.daValoare(null);
                    return new Const(valoare);

                }
                // x * x = x^2
                else if (e1.ToString() == e2.ToString())
                {
                    return new Putere(Simplifica(e1), new Const(2));

                }
                // 0 * x = x * 0 = 0
                else if ((e1 is Const && e1.daValoare(null) == 0) || (e2 is Const && e2.daValoare(null) == 0))
                {
                    return new Const(0);
                }
                // 1 * x = x
                else if (e1 is Const && e1.daValoare(null) == 1)
                {
                    return Simplifica(e2);
                }
                // x * 1 = x
                else if (e2 is Const && e2.daValoare(null) == 1)
                {
                    return Simplifica(e1);
                }
                else if (e1 is Putere p1)
                {
                    // x ^ p * x ^ q = x ^ ( p + q )
                    if (e2 is Putere p2 && p1.e1.ToString() == p2.e1.ToString())
                        return new Putere(Simplifica(p1.e1), Simplifica(new Plus(p1.e2, p2.e2)));
                    // x ^ p * x = x ^ ( p + 1 )
                    else if (p1.e1.ToString() == e2.ToString())
                        return new Putere(Simplifica(p1.e1), Simplifica(new Plus(p1.e2, new Const(1))));
                }
                // x * x ^ p = x ^ ( p + 1 )
                else if (e2 is Putere p2 && e1.ToString() == p2.e1.ToString())
                    return new Putere(Simplifica(e1), Simplifica(new Plus(p2.e2, new Const(1))));
                

                else if(e1 is Inmultit i1 && e2 is Inmultit i2)
                {
                    // ( x * p ) * ( x * q ) = ( p * q ) * x^2
                    if (i1.e2 is Const p3 && i2.e2 is Const q && i1.e1.ToString() == i2.e1.ToString())
                        return new Inmultit(Simplifica(new Inmultit(p3,q)),Simplifica(new Putere(i1.e1,new Const(2))));

                    // ( x * p ) * ( q * x ) = ( p * q ) * x^2
                    if (i1.e2 is Const p4 && i2.e1 is Const q1 && i1.e1.ToString() == i2.e2.ToString())
                        return new Inmultit(Simplifica(new Inmultit(p4, q1)), Simplifica(new Putere(i1.e1, new Const(2))));

                    // ( p * x ) * ( x * q ) = ( p * q ) * x^2
                    if (i1.e1 is Const p5 && i2.e2 is Const q2 && i1.e2.ToString() == i2.e1.ToString())
                        return new Inmultit(Simplifica(new Inmultit(p5, q2)), Simplifica(new Putere(i1.e2, new Const(2))));

                    // ( p * x ) * ( q * x ) = ( p * q ) * x^2
                    if (i1.e1 is Const p6 && i2.e1 is Const q3 && i1.e2.ToString() == i2.e2.ToString())
                        return new Inmultit(Simplifica(new Inmultit(p6, q3)), Simplifica(new Putere(i1.e2, new Const(2))));
                }

                else if (e1 is Inmultit inm1)
                {
                    // ( p * x ) * x = p * x^2
                    if (inm1.e1 is Const p3 && inm1.e2.ToString() == e2.ToString())
                        return new Inmultit(new Const(p3.daValoare(null)), Simplifica(new Putere(e2, new Const(2))));

                    // ( x * p ) * x = p * x^2
                    else if (inm1.e2 is Const p4 && inm1.e1.ToString() == e2.ToString())
                        return new Inmultit(new Const(p4.daValoare(null)), Simplifica(new Putere(e2, new Const(2))));

                    // ( x * p ) * q = p * q * x
                    else if (inm1.e2 is Const p5 && e2 is Const q)
                        return new Inmultit(Simplifica(new Inmultit(p5,q)),Simplifica(inm1.e1));

                    // ( p * x ) * q = p * q * x
                    else if (inm1.e1 is Const p6 && e2 is Const q1)
                        return new Inmultit(Simplifica(new Inmultit(p6, q1)), Simplifica(inm1.e2));

                }

                else if (e2 is Inmultit inm2)
                {
                    // x * ( p * x ) = p * x^2
                    if (inm2.e1 is Const p3 && inm2.e2.ToString() == e1.ToString())
                        return new Inmultit(new Const(p3.daValoare(null)), Simplifica(new Putere(e1, new Const(2))));

                    // x * ( x * p ) = p * x^2
                    else if (inm2.e2 is Const p4 && inm2.e1.ToString() == e1.ToString())
                        return new Inmultit(new Const(p4.daValoare(null)), Simplifica(new Putere(e1, new Const(2))));

                    // q * ( x * p ) = p * q * x
                    else if (inm2.e2 is Const p5 && e1 is Const q)
                        return new Inmultit(Simplifica(new Inmultit(p5, q)), Simplifica(inm2.e1));

                    // q * ( p * x ) = p * q * x
                    else if (inm2.e1 is Const p6 && e1 is Const q1)
                        return new Inmultit(Simplifica(new Inmultit(p6, q1)), Simplifica(inm2.e2));

                }

                return new Inmultit(Simplifica(e1), Simplifica(e2));
                
                
               
            }

            if (f is Impartit impartit)
            {
                Functie e1 = Simplifica(impartit.e1);
                Functie e2 = Simplifica(impartit.e2);

                // cst / cst = cst
                if (e1 is Const && e2 is Const)
                {
                    double valoare = e1.daValoare(null) / e2.daValoare(null);
                    return new Const(valoare);
                }
                // 0 / x = 0
                else if (e1 is Const && e1.daValoare(null) == 0)
                {
                    return new Const(0);
                }
                // x / 1 = x
                else if (e2 is Const && e2.daValoare(null) == 1)
                {
                    return Simplifica(e1);
                }
                // x / 0 = !
                else if (e2 is Const && e2.daValoare(null) == 0)
                {
                    throw new DivideByZeroException("Nu se poate imparti la 0!");
                }

                return new Impartit(Simplifica(e1), Simplifica(e2));
                
            }

            if (f is Putere putere)
            {
                Functie e1 = Simplifica(putere.e1);
                Functie e2 = Simplifica(putere.e2);


                if (e2 is Const)
                {
                    // cst ^ cst = cst
                    if (e1 is Const)
                    {
                        double valoare = Math.Pow(e1.daValoare(null), e2.daValoare(null));
                        return new Const(valoare);
                    }
                    else 
                    {
                        // x ^ 1 = x
                        if (e2.daValoare(null) == 1)
                        {
                            return Simplifica(e1);
                        }
                        // x ^ 0 = 1
                        else if (e2.daValoare(null) == 0)
                        {
                            return new Const(1);
                        }

                    }
                }
                return new Putere(Simplifica(e1), Simplifica(e2));      
            }

            if (f is Plus plus)
            {                   
                Functie e1 = Simplifica(plus.e1);
                Functie e2 = Simplifica(plus.e2);

                // cst + cst = cst
                if (e1 is Const && e2 is Const)
                {
                    double valoare = e1.daValoare(null) + e2.daValoare(null);
                    return new Const(valoare);
                }
                // x + x = 2*x
                else if (e1.ToString() == e2.ToString())
                {
                    return new Inmultit(new Const(2),Simplifica(e1));
                }
                // 0 + x = x
                else if (e1 is Const && e1.daValoare(null) == 0)
                {
                    return Simplifica(e2);
                }
                // x + 0 = x
                else if (e2 is Const && e2.daValoare(null) == 0)
                {
                    return Simplifica(e1);
                }

                else if(e1 is Inmultit inm1)
                {
                    // x * p + x = (p + 1) * x
                    if(inm1.e1 is Const p1 && inm1.e2.ToString()==e2.ToString())
                        return new Inmultit(new Const(p1.daValoare(null) + 1), Simplifica(e2));
                    // p * x + x = (p + 1) * x
                    else if (inm1.e2 is Const p2 && inm1.e1.ToString()==e2.ToString())
                        return new Inmultit(new Const(p2.daValoare(null) + 1), Simplifica(e2));
                    // p * x + q * x =(p + q) * x
                    else if (e2 is Inmultit inm2 && inm1.e1 is Const p3 && inm2.e1 is Const p4 && inm1.e2.ToString()==inm2.e2.ToString() )
                        return new Inmultit(new Const(p3.daValoare(null) + p4.daValoare(null)), Simplifica(inm1.e2));

                }
                else if(e2 is Inmultit inm2)
                {
                    // x + p * x = (p + 1) * x
                    if (inm2.e1 is Const p1 && inm2.e2.ToString() == e1.ToString())
                        return new Inmultit(new Const(p1.daValoare(null) + 1), Simplifica(e1));
                    // x + x * p = (p + 1) * x
                    else if (inm2.e2 is Const p2 && inm2.e1.ToString() == e1.ToString())
                        return new Inmultit(new Const(p2.daValoare(null) + 1), Simplifica(e1));

                }
                
                return new Plus(Simplifica(e1), Simplifica(e2));
               
            }

            if (f is Minus minus)
            {
                Functie e1 = Simplifica(minus.e1);
                Functie e2 = Simplifica(minus.e2);

                // cst - cst = cst
                if (e1 is Const && e2 is Const)
                {
                    double valoare = e1.daValoare(null) - e2.daValoare(null);
                    return new Const(valoare);
                }
                // 0 - x = -1 * x
                else if (minus.e1 is Const && e1.daValoare(null) == 0)
                {
                    return new Inmultit(new Const(-1), Simplifica(e2));
                }
                // x - 0 = x
                else if (minus.e2 is Const && e2.daValoare(null) == 0)
                {
                    return Simplifica(e1);
                }
                else if (e1 is Inmultit inm1)
                {
                    // x * p - x = (p - 1) * x
                    if (inm1.e1 is Const p1 && inm1.e2.ToString() == e2.ToString())
                        return new Inmultit(new Const(p1.daValoare(null) - 1), Simplifica(e2));
                    // p * x - x = (p - 1) * x
                    else if (inm1.e2 is Const p2 && inm1.e1.ToString() == e2.ToString())
                        return new Inmultit(new Const(p2.daValoare(null) - 1), Simplifica(e2));
                    // p * x - q * x =(p - q) * x
                    else if (e2 is Inmultit inm2 && inm1.e1 is Const p3 && inm2.e1 is Const p4 && inm1.e2.ToString() == inm2.e2.ToString())
                        return new Inmultit(new Const(p3.daValoare(null) - p4.daValoare(null)), Simplifica(inm1.e2));

                }
                else if (e2 is Inmultit inm2)
                {
                    // x - p * x = (1 - p) * x
                    if (inm2.e1 is Const p1 && inm2.e2.ToString() == e1.ToString())
                        return new Inmultit(new Const(1-p1.daValoare(null)), Simplifica(e1));
                    // x - x * p = (1-p) * x
                    else if (inm2.e2 is Const p2 && inm2.e1.ToString() == e1.ToString())
                        return new Inmultit(new Const(1-p2.daValoare(null)), Simplifica(e1));
                }
                
                return new Minus(Simplifica(e1), Simplifica(e2));
                
            }

            if (f is Log log)
            {
                Functie e = Simplifica(log.e);
                double b = log.b;
                
                if (e is Const )
                {
                    double valoare = Math.Log(e.daValoare(null), b);
                    // ln e = 1
                    if ( e.daValoare(null) == Math.E && b == 10)
                        return new Const(1);
                    // log_cst(cst) = cst
                    return new Const(valoare);
                    
                }
             
                else return new Log(Simplifica(e), b);

            }

            return f;
        }
    }
}
