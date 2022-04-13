using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExercises
{

    internal class Program
    {

        static void Main(string[] args)
        {
            // Singleton proof that two  object references refer to the same object in heap
            Console.WriteLine("===== Singleton Pattern ======");
            CreationalPatterns.Singleton singleton1 = CreationalPatterns.Singleton.GetMySingleton();
            CreationalPatterns.Singleton singleton2 = CreationalPatterns.Singleton.GetMySingleton();
            bool areEqual = System.Object.ReferenceEquals(singleton1, singleton2);
            Console.WriteLine($"It is {areEqual} that they are equal\n\n");

            // Builder design pattern
            Console.WriteLine("===== Builder Pattern =====");
            CreationalPatterns.SmartphoneShop shopBuilder = new CreationalPatterns.SmartphoneShop();
            CreationalPatterns.Smartphone mySmartphone;
            mySmartphone = shopBuilder.Construct(new CreationalPatterns.IPhoneSEBuilder());
            mySmartphone.Show();

        }
    }
}
