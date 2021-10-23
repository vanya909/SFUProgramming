using System;

namespace CatsLab
{
    class Cat
    {
        private string _name;
        private int _health = 10;

        public String Name
        {
            get { return _name; }
            set
            {
                if (_name is null)
                    _name = value;
            }
        }

        public int Age
        {
            get;
            init;
        }

        public string Color
        {
            get { return _health > 0 ? "Green" : "White"; }
        }

        public void Feed(int foodCount)
        {
            _health += foodCount;
        }

        public void Punish(int hit)
        {
            _health -= hit;
        }



        static void Main(string[] args)
        {
            Cat cat = new Cat()
            {
                Age = 10,
                Name = "Johny"
            };

            while (cat.Color.Equals("Green"))
            {
                Console.WriteLine("Do you want to feed or to punish?");
                string answer = Console.ReadLine();

                Console.WriteLine("Enter the value:");
                int value = Convert.ToInt32(Console.ReadLine());

                if (answer.ToLower().Equals("feed"))
                    cat.Feed(value);
                else
                    cat.Punish(value);

                Console.WriteLine($"The cat's color is {cat.Color}");
            }

            Console.WriteLine($"The {cat.Name} is died ;(");
        }
    }
}
