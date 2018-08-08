using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petstore
{
    public class Adding
    {

        
        static Pet pet1 = new Pet("", 0, "", "", "", 0);








        public static void Add()
        {

        Console.WriteLine("Please Enter the Animal type");
            pet1.AType = (Console.ReadLine());
        Console.WriteLine("Please Enter the Animal's age");
            pet1.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter the Animal's gender");
            pet1.Gender = (Console.ReadLine());
        Console.WriteLine("Is the animal Microschipped (Yes/No)");
            pet1.Microchipped = (Console.ReadLine());
        Console.WriteLine("Please Enter the Animal's breed");
            pet1.Breed = (Console.ReadLine());
        Console.WriteLine("Please Enter the Animal's price");
            pet1.Price = int.Parse(Console.ReadLine());
        Console.Clear();

            Console.WriteLine("Pet List");
            Console.WriteLine("Type: {0}", pet1.AType);
            Console.WriteLine("Age: {0}", pet1.Age);
            Console.WriteLine("Gender: {0}", pet1.Gender);
            Console.WriteLine("Microchipped: {0}", pet1.Microchipped);
            Console.WriteLine("Breed: {0}", pet1.Breed);
            Console.WriteLine("Price: ${0}", pet1.Price);
        }
    }
}
