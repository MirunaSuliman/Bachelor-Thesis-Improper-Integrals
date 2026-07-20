using Functii;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interfata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image img;
        Graphics g;
        double a, b, m, M;
        List<PointF> puncte;
        double raport;
        Functie f;
        bool ok = false;

        void test_campuri()
        {
            bool inputValid = true;
            if (var_der.Text.Length == 0)
            {
                MessageBox.Show("Introduceti variabila de integrare!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputValid = false;
            }
            else if (camp_a.Text.Length == 0 || camp_b.Text.Length == 0)
            {
                MessageBox.Show("Introduceti intervalul de integrare!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputValid = false;
            }
            if (!inputValid) { Application.Restart(); }


        }

        int da_pozitie(string expresie, int codCaracterCautat)
        {
            int temp = 0;
            for (int i = expresie.Length - 1; i >= 0; i--)
            {
                if ((temp == 0) && (expresie[i] == codCaracterCautat)) return i;
                if (expresie[i] == ')') temp++;
                if (expresie[i] == '(') temp--;
            }
            return -1;
        }

        Functie calculeaza(string expresie)
        {
            try
            {
                if (expresie.Trim().Length == 0) return null;
                expresie = expresie.Trim();

                int pozitie;
                pozitie = da_pozitie(expresie, '+');
                if (pozitie >= 0)
                {
                    Functie val1 = calculeaza(expresie.Substring(0, pozitie));
                    Functie val2 = calculeaza(expresie.Substring(pozitie + 1));
                    return new Plus(val1, val2);
                }

                pozitie = da_pozitie(expresie, '-');
                if (pozitie >= 0)
                {
                    Functie val1 = calculeaza(expresie.Substring(0, pozitie));
                    Functie val2 = calculeaza(expresie.Substring(pozitie + 1));
                    if (val1 != null)
                        return new Minus(val1, val2);
                    else if (val1 == null) return new Inmultit(new Const(-1), val2);
                }

                pozitie = da_pozitie(expresie, '*');
                if (pozitie >= 0)
                {
                    Functie val1 = calculeaza(expresie.Substring(0, pozitie));
                    Functie val2 = calculeaza(expresie.Substring(pozitie + 1));
                    return new Inmultit(val1, val2);
                }

                pozitie = da_pozitie(expresie, '/');
                if (pozitie >= 0)
                {
                    Functie val1 = calculeaza(expresie.Substring(0, pozitie));
                    Functie val2 = calculeaza(expresie.Substring(pozitie + 1));
                    return new Impartit(val1, val2);
                }

                pozitie = da_pozitie(expresie, '^');
                if (pozitie >= 0)
                {
                    Functie val1 = calculeaza(expresie.Substring(0, pozitie));
                    Functie val2 = calculeaza(expresie.Substring(pozitie + 1));
                    return new Putere(val1, val2);
                }

                double result;
                if (expresie.StartsWith("sin(") && expresie.EndsWith(")")) return new Sin(calculeaza(expresie.Substring(4, expresie.Length - 5)));
                if (expresie.StartsWith("cos(") && expresie.EndsWith(")")) return new Cos(calculeaza(expresie.Substring(4, expresie.Length - 5)));
                if (expresie.StartsWith("tg(") && expresie.EndsWith(")")) return new Tg(calculeaza(expresie.Substring(3, expresie.Length - 4)));
                if (expresie.StartsWith("ln(") && expresie.EndsWith(")")) return new Log(calculeaza(expresie.Substring(3, expresie.Length - 4)), Math.E);
                if (expresie.StartsWith("log_(") && expresie.EndsWith(")"))
                {
                    int j = 0;
                    for (int i = 0; i <= expresie.Length - 1; i++)
                        if (expresie[i].Equals('(')) { j = i; break; }
                    string baza = expresie.Substring(4, j - 4);
                    string exp = expresie.Substring(j + 1, expresie.Length - (6 + baza.Length));
                    return new Log(calculeaza(exp), Convert.ToDouble(baza));
                }
                if (expresie.StartsWith("(") && expresie.EndsWith(")")) return calculeaza(expresie.Substring(1, expresie.Length - 2));
                if (expresie.ToLower() == "e") return new Const(Math.E);
                if (Double.TryParse(expresie, out result)) return new Const(Convert.ToDouble(expresie));
                if (expresie == var_der.Text)
                {
                    Var v = new Var();
                    v.Variabila = var_der.Text;
                    return v;

                }
                if (expresie == param.Text)
                {
                    Var p = new Var(expresie);
                    if (Double.TryParse(val_param.Text, out result))
                        return new Const(Convert.ToDouble(val_param.Text));
                    else
                    {
                        ok = true;
                        return p;
                    }

                }

                throw new Exception("Expresie invalida a functiei!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }

            return null;

        }

        void daPuncte()
        {
            puncte = new List<PointF>();

            if (b > a)
            {
                m = M = f.daValoare(new Variabila(a));
                int N = 250;
                for (int i = 0; i <= N; i++)
                {
                    double x = a + i * (b - a) / N;
                    double y = f.daValoare(new Variabila(x));
                    if (y < m) m = y;
                    else if (y > M) M = y;
                    puncte.Add(new PointF((float)x, (float)y));
                }
                if (b - a > M - m)
                    raport = 400 / (b - a);
                else raport = 400 / (M - m);
            }
        }

        Point daCoord(double x, double y)
        {
            int x0 = (int)((x - a) * raport + 50 + (400 - (b - a) * raport) / 2);
            int y0 = (int)((M - y) * raport + 50 + (400 - (M - m) * raport) / 2);
            return new Point(x0, y0);
        }

        void deseneazaAxe()
        {
            g.Clear(Color.White);
            g.FillRectangle(Brushes.LightGray, 25, 25, 450, 450);
            Pen creion = new Pen(Color.Black, 3);
            g.DrawLine(creion, 25, daCoord(a, 0).Y, 475, daCoord(a, 0).Y);
            g.DrawLine(creion, 469, daCoord(a, 0).Y - 6, 475, daCoord(a, 0).Y);
            g.DrawLine(creion, 469, daCoord(a, 0).Y + 6, 475, daCoord(a, 0).Y);
            g.DrawLine(creion, daCoord(0, m).X, 475, daCoord(0, m).X, 25);
            g.DrawLine(creion, daCoord(0, m).X - 6, 31, daCoord(0, m).X, 25);
            g.DrawLine(creion, daCoord(0, m).X + 6, 31, daCoord(0, m).X, 25);

            p.Refresh();
        }

        void scrieCoordonate()
        {
            Font f = new Font("Courier New", 14);
            Pen creion = new Pen(Color.Black, 3);
            g.DrawString("O", f, Brushes.Blue, daCoord(0, 0));
            g.DrawLine(creion, daCoord(a, 0).X, daCoord(a, 0).Y - 6, daCoord(a, 0).X, daCoord(a, 0).Y + 6);
            g.DrawString("a", f, Brushes.Blue, daCoord(a, 0));
            g.DrawLine(creion, daCoord(b, 0).X, daCoord(b, 0).Y - 6, daCoord(b, 0).X, daCoord(b, 0).Y + 6);
            g.DrawString("b", f, Brushes.Blue, daCoord(b, 0));
            g.DrawLine(creion, daCoord(0, M).X - 6, daCoord(0, M).Y, daCoord(0, M).X + 6, daCoord(0, M).Y);
            g.DrawString("M", f, Brushes.Blue, daCoord(0, M).X + 6, daCoord(0, M).Y - 6);
            g.DrawLine(creion, daCoord(0, m).X - 6, daCoord(0, m).Y, daCoord(0, m).X + 6, daCoord(0, m).Y);
            g.DrawString("m", f, Brushes.Blue, daCoord(0, m).X + 6, daCoord(0, m).Y - 6);
            g.DrawString("m=" + ((int)(m * 100000) / 100000.0), f, Brushes.Blue, 10, 0);
            g.DrawString("M=" + ((int)(M * 100000) / 100000.0), f, Brushes.Blue, 355, 0);


            p.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(img);
            g.Clear(Color.White);
            raport = 1;
            daPuncte();
        }

        void scrieFunctia()
        {
            Font f = new Font("Courier New", 14);
            Pen creion = new Pen(Color.Black, 3);
            if (param.Text.Length == 0)
                g.DrawString("f(" + var_der.Text + ")=" + calculeaza(f_in.Text), f, Brushes.Blue, 30, p.Height - 30);
            else g.DrawString("f(" + var_der.Text + "," + param.Text + ")=" + calculeaza(f_in.Text), f, Brushes.Blue, 30, p.Height - 30);
            p.Refresh();
        }
        void deseneazaGrafic()
        {
            Pen creion = new Pen(Color.Red, 2);
            for (int i = 1; i < puncte.Count; i++)
            {
                PointF P1 = (PointF)puncte[i - 1];
                PointF P2 = (PointF)puncte[i];
                g.DrawLine(creion, daCoord(P1.X, P1.Y), daCoord(P2.X, P2.Y));
            }
            p.Refresh();
        }

        private void p_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0, p.Width, p.Height);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            test_campuri();
            MetodaDreptunghiului metodaDreptunghiului = new MetodaDreptunghiului();
            MetodaTrapezelor metodaTrapezelor = new MetodaTrapezelor();
            MetodaSimpson metodaSimpson = new MetodaSimpson();
            int n = 1000000;
            Font font = new Font("Courier New", 14);

            f = calculeaza(f_in.Text);
            Functie f_simplificata = new Simplificare().Simplifica(f);

            Functie f_derivata = f_simplificata.Deriveaza();
            Functie f_derivata_simplificata = new Simplificare().Simplifica(f_derivata);

            f_derivata_out.Text = f_derivata_simplificata.ToString();

            if (param.Text.Length != 0 && val_param.Text.Length == 0 && ok == true)
            {

                g.Clear(Color.White);
                g.FillRectangle(Brushes.LightGray, 25, 25, 450, 450);
                g.DrawString("Introduceti o valoare parametrului", font, Brushes.Red, 0, 0);
                scrieFunctia();

                drept_aprox.Text = null;
                drept_er.Text = null;
                trap_aprox.Text = null;
                trap_er.Text = null;
                simp_aprox.Text = null;
                simp_er.Text = null;
            }
            else
            {

                try
                {
                    if (camp_a.Text == "-inf")
                        a = -1e2;
                    else
                        a = Convert.ToDouble(camp_a.Text);

                    if (camp_b.Text == "inf")
                        b = 1e2;
                    else
                        b = Convert.ToDouble(camp_b.Text);

                    f = calculeaza(f_in.Text);
                    daPuncte();
                    deseneazaAxe();
                    scrieFunctia();
                    scrieCoordonate();
                    deseneazaGrafic();
                }
                catch (Exception)
                {
                    g.Clear(Color.White);
                    g.FillRectangle(Brushes.LightGray, 25, 25, 450, 450);
                    p.Refresh();
                }


                drept_aprox.Text = Convert.ToString(metodaDreptunghiului.Aproximare(f, a, b, n));
                drept_er.Text = Convert.ToString(metodaDreptunghiului.Eroare(f, a, b, n));

                trap_aprox.Text = Convert.ToString(metodaTrapezelor.Aproximare(f, a, b, n));
                trap_er.Text = Convert.ToString(metodaTrapezelor.Eroare(f, a, b, n));

                simp_aprox.Text = Convert.ToString(metodaSimpson.Aproximare(f, a, b, n));
                simp_er.Text = Convert.ToString(metodaSimpson.Eroare(f, a, b, n));
            }
        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            param.Text = "p";
           val_param.Text = "1";
            var_der.Text = "x";
            f_in.Text = "x^(p-1)*e^(-x)";
            camp_a.Text = "0";
            camp_b.Text = "inf";

            button1_Click(sender, e);
        }

        private void gaussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var_der.Text = "x";
            f_in.Text = "e^(-x^2)";
            camp_a.Text = "-inf";
            camp_b.Text = "inf";

            button1_Click(sender, e);
        }
    }
}