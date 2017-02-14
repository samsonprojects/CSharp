using System;

namespace AnimalKingdom
{

    public class Cat : Animal
    {

       

        public Cat(string Name, int Age, bool Male)
        {
            this.name = Name;
            this.age = Age;
            this.Male = Male;

        }

        protected override string GetTypicalSound()
        {
            return "Meoow";
        }

        
    }
}
