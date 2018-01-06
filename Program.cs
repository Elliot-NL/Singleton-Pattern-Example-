using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___Singleton_Pattern
{
    class SingletonExample
    {
        private static SingletonExample _instance;

        protected SingletonExample()
        {
        }

        public static SingletonExample Instance()
        {
            // Lazy initialization:

            if (_instance == null)
            {
                _instance = new SingletonExample();
            }

            return _instance;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Globally accessible single object instance 
            //Singleton vs Static Data
            SingletonExample s1 = SingletonExample.Instance();
            SingletonExample s2 = SingletonExample.Instance();

            // Test for same instance

            if (s1 == s2)
            {
                Console.WriteLine("The Objects are the same instance");
            }

            Console.ReadKey();
        }
    }
}
