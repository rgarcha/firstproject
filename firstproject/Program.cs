using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    // abstract class
    abstract class A
    {
        public A()
        {
            Console.WriteLine("constructorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr");
        }
        public virtual void Hello()
        {
            Console.WriteLine("Hi I am from A abstract");
        }
        public abstract void abst();
    }




    abstract class B
    {
        public void Hello()
        {
            Console.WriteLine("Hi I am from B abstract");
        }
        public abstract void abst();
    }

    class CC : A
    {
        public override void Hello()
        {
            Console.WriteLine("Helloooooo from override hello abstract");
        }
        public override void abst()
        {
            Console.WriteLine("Helloooooo from override abstract");
        }
    }







    //interface
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

    class House : IWood
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine($"hello from Sum in HOUSE CLASS {a} and hello from {b}", a.ToString(), b.ToString());
        }
    }


    interface ISave
    {
        void Save();
    }

    class SavetoSQL : ISave
    {
        public void Save()
        {
            Console.WriteLine("Save to SQL server");
        }
    }

    class SavetoMongoDB : ISave
    {
        public void Save()
        {
            Console.WriteLine("Save to Mongo DB");
        }
    }

    class SavetoExpressDB : ISave
    {
        public void Save()
        {
            Console.WriteLine("Save to Express DB");
        }
    }


    class common
    {
        public void Save()
        {
            SavetoSQL abc = new SavetoSQL();
            abc.Save();

            //SavetoMongoDB abc = new SavetoMongoDB();
            //abc.Save();
        }
    }




    class Project
    {
        private readonly ISave _save;
        public Project(ISave save)
        {
            _save = save;
        }

        public void hello()
        {
            _save.Save();
        }
    }


    class Program
    {
        static void Main(string[] args) // 100 files
        {

                        Ghar obj = new Ghar();
            obj.Mul(1, 2);
            obj.Sum(2, 3);


            House obj1 = new House();
            obj1.Sum(5, 6);

            common c = new common();
            c.Save();


            Project ppp = new Project(new SavetoExpressDB());
            ppp.hello();



            // abstract class
            CC cc = new CC();
            cc.abst();
            cc.Hello();

        }
    }
}
