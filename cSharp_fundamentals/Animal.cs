using System;
namespace cSharp_fundamentals
{
    public class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        
        //Getter setter
        public string Name
        {
            get { return name; }
            set { name = value; } //For setter this has to be the value all the time
        }
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.sound = "";
            this.name = "";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string sound, string name)
        {
            this.height = height;
            this.weight = weight;
            this.sound = sound;
            this.name = name;
            numOfAnimals++;
        }

        //Static variables and methods
        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        //toString
        public string toString()
        {
            return String.Format( "{0} is {1} feet long and {2} weight. It makes sound of {3}", this.name, this.height, this.weight, this.sound);

        }

        //Method overloading
        public int getSum(int num1, int num2)
        {
            return num1 + num2;
        }

        public double getSum(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
