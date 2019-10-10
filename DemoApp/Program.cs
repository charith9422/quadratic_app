using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Quadratic {

        string a_val;
        string b_val;
        string c_val;
        double a = 0;
        double b = 0;
        double c = 0;
        double determinent = 0;
        double root = 0;

        public void Solve() {

            Console.WriteLine("Enter Coefficients");
            Console.Write("Enter a:");

            a_val = Console.ReadLine();
            a = Convert.ToDouble(a_val);

            if (a != 0)
            {
                Console.Write("Enter b:");
                b_val = Console.ReadLine();
                b = Convert.ToDouble(b_val);

                Console.Write("Enter c:");
                c_val = Console.ReadLine();
                c = Convert.ToDouble(c_val);

                Calculate();
            }
            else {
                Console.WriteLine("Coeffcient 'a' should not be equals to zero.Enter again");
                Solve();
            }
        }

        public void Calculate() {

            determinent = Math.Pow(b, 2) - (4 * a * c);

            if (determinent == 0)
            {

                root = -b / (2 * a);
                Console.WriteLine("Root is " + root);

            }
            else if (determinent > 0)
            {

                double root1 = (-b + (Math.Pow(determinent, 0.5))) / 2 * a;
                double root2 = (-b - (Math.Pow(determinent, 0.5))) / 2 * a;
                Console.WriteLine("Roots are " + root1 + " & " + root2);
            }
            else
            {

                Console.WriteLine("No real roots");
                
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Quadratic q = new Quadratic();
            q.Solve();
          
            Console.ReadLine();
        }
    }
}
