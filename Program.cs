using System;

namespace FlynnsTaxonomy {
    public class Program {
        public static void Main(string[] str){
            
            SISD obj1 = new();
            SIMD obj2 = new();
            MISD obj3 = new();
            MIMD obj4 = new();

            Console.WriteLine("-----------| SISD | \n");
            obj1.Example();
            Console.WriteLine("\n-----------| SIMD | \n");
            obj2.Example();
            Console.WriteLine("\n-----------| MISD | \n");
            obj3.Example();
            Console.WriteLine("\n-----------| MIMD | \n");
            obj4.Example();

            Console.Write("\nPress any key to end the program...");
            Console.ReadKey();
        }
    }
}