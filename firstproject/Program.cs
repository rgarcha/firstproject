using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    public interface IWood
    {
        void Sum(int a, int b);
    }
    public interface IGlass
    {
        void Mul(int a, int b);
    }

    class Ghar : IWood, IGlass
    {
        public void Mul(int a, int b)
        {
            Console.WriteLine($"hello from Mul {a} and hello from {b}", a.ToString(), b.ToString());
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine($"hello from Sum {a} and hello from {b}", a.ToString(), b.ToString());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Ghar obj = new Ghar();
            obj.Mul(1, 2);
            obj.Sum(2, 3);
        }
    }
}
