using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petstore
{
    public class Pet
    {
        static void Main(string[] args)
        {
            Program.Method();
            Adding.Add();
        }

            string atype;
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

            

        }
    }
}
