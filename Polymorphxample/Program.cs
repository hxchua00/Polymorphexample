using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphexample
{
    class Human
    {
        public string name;
        public int age;
        public string gender;



        public void printAll(string name, int age, string gender)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
        }

    }

    class HumanA : Human
    {
        public string racialStats;
        public string complextion;
        public string language;

        public void printAll(string name, int age, string gender, string racialStats, string complextion, string language)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("RacialStats = " + racialStats);
            Console.WriteLine("Complextion = " + complextion);
            Console.WriteLine("Language spoken: " + language);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            HumanA guyA = new HumanA();

            guyA.printAll("Harry", 12, "Male","Asian","Good","English");
            Console.ReadLine();
        }
    }
}
