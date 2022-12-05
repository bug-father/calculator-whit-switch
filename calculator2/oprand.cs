using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculator2;

namespace calculator2
{
    public  class oprand
    {
        public static int sum(int a, int b)
        {
            return a + b;
            
        }
        public static int minus(int a, int b)
        {

            return a - b;
        }
        public static int multi(int a, int b)
        {
            return a * b;

        }
        public static int devide(int a, int b)
        {

            return a / b;
        }
        public static double log(int a)
        {
            return Math.Log(a);

        }
        public static double radical(int a)
        {
            return Math.Sqrt(a);

        }
        public static double Power(int a, int b)
        {

            return Math.Pow(a,b);
        }







    }

    
}
