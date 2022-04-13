using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class Singleton
    {
        private static readonly Singleton s_mySingletonObject = new Singleton();

        static Singleton() { }
        private Singleton() { }

        // Factory method to return the one instance of the singleton class
        public static Singleton GetMySingleton() 
        {
            return s_mySingletonObject;
        }

        public void GoAction() { }

    }
}
