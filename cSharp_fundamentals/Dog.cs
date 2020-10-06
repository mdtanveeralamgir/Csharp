using System;
namespace cSharp_fundamentals
{
    public class Dog : Animal
    {
        private string favFood;

        public string FavFood
        {
            get => favFood;
            set => favFood = value;
        }

        public Dog():base()
        {
            this.favFood = "";
        }

        public Dog(double height, double width, string sound, string name, string favFood):base(height: height, width, sound, name)
        {
            this.favFood = favFood;
        }

        //Method overriding
        //toString
        new public string toString()
        {
            return String.Format("{0} is {1} feet long and {2} weight. It makes sound of {3}. His fav food is {4}", this.name, this.height, this.weight, this.sound, this.favFood);

        }
    }
}
