using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petstore
{
    class Pet
    {
        static void Main(string[] args)
        {
            Program.Method();
        }

            string atype = "";
            string gender;
            string microchipped;
            string breed;
            float age;
            float price;

        public string AType
        {
            get
            {
                return atype;
            }
            set
            {
                atype = value;
            }
        }
        public float Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string Microchipped
        {
            get
            {
                return microchipped;
            }
            set
            {
                microchipped = value;
            }
        }
        public string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    
        public Pet(string _atype, float _age, string _gender, string _microchipped, string _breed, float _price)
        {
            AType = _atype;
            Age = _age;
            Gender = _gender;
            Microchipped = _microchipped;
            Breed = _breed;
            Price = _price;
        }

    }

    public class Program
    {
        public static void Method()
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

            Console.WriteLine("Pet List");
            Console.WriteLine("Type: {0}", atype);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Microchipped: {0}", microchipped);
            Console.WriteLine("Breed: {0}",breed);
            Console.WriteLine("Price: ${0}", price);
        }
    }
}
