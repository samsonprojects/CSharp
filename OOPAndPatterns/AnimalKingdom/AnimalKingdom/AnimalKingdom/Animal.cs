using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat.
/// All of them are animals (Animal). 
/// Animals are characterized by age, name and gender. 
/// Each animal makes a sound (use a virtual method in the Animal class).
/// </summary>
namespace AnimalKingdom
{
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected bool Male;
        
        protected string Name
        {
            get { return this.name; }
        }

        protected int Age
        {
            get { return this.age; }
        }

        protected bool GetSexIfMale
        {
            get { return this.Male; }
        }

       
        public void MakeSound()
        {
            Console.WriteLine("{0}", GetTypicalSound());
        }

        protected abstract String GetTypicalSound();

    }


}
