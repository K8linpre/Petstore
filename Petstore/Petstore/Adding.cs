using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petstore
{
    public class Adding
    {

        
        static Pet Pet1 = new Pet("","", "", "", "", "");








        public static void Add()
        {

        Console.WriteLine("Please Enter the Animal type");
            string atype = (Console.ReadLine());
        Console.WriteLine("Please Enter the Animal's age");
            float age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter the Animal's gender");
            string gender = (Console.ReadLine());
        Console.WriteLine("Is the animal Microschipped (Yes/No)");
            string microchipped = (Console.ReadLine());
        Console.WriteLine("Please Enter the Animal's breed");
            string breed = (Console.ReadLine());
        Console.WriteLine("Please Enter the Animal's price");
            float price = int.Parse(Console.ReadLine());
        Console.ReadLine();

            Console.WriteLine("Pet List");
            Console.WriteLine("Type: {0}", atype);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Microchipped: {0}", microchipped);
            Console.WriteLine("Breed: {0}", breed);
            Console.WriteLine("Price: ${0}", price);
        }
    }
}
