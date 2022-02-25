using System.Collections.Generic;

namespace FirstLabSecondSem
{
    class Cart<T> where T : IFood
    {
        public List<T> Foodstuffs { get; } = new List<T>();

        public void CartBalansing()
        {
            if (Foodstuffs.Count == 0)
                throw new EmptyCartException("Can't balance empty cart");

            if (ContainsProteins() && ContainsFats() && ContainsCarbohydrates())
                return;

            if (ContainsHealthyFoodOnly())
            {
                if (!ContainsProteins())
                    AddHealthyFood("Proteins");

                if (!ContainsFats())
                    AddHealthyFood("Fats");

                if (!ContainsCarbohydrates())
                    AddHealthyFood("Carbohydrates");
            }
            else if (ContainsSemiFinishedFoodOnly())
            {
                if (!ContainsProteins())
                    AddSemiFinishedFood("Proteins");

                if (!ContainsFats())
                    AddSemiFinishedFood("Fats");

                if (!ContainsCarbohydrates())
                    AddSemiFinishedFood("Carbohydrates");
            }
            else
            {
                if (!ContainsProteins())
                    AddSnacks("Proteins");

                if (!ContainsFats())
                    AddSnacks("Fats");

                if (!ContainsCarbohydrates())
                    AddSnacks("Carbohydrates");
            }
        }

        private bool ContainsProteins()
        {
            foreach (T stuff in Foodstuffs)
            {
                if (((IFood)stuff).Proteins)
                    return true;
            }
            return false;
        }

        private bool ContainsFats()
        {
            foreach (T stuff in Foodstuffs)
            {
                if (((IFood)stuff).Fats)
                    return true;
            }
            return false;
        }

        private bool ContainsCarbohydrates()
        {
            foreach (T stuff in Foodstuffs)
            {
                if (((IFood)stuff).Carbohydrates)
                    return true;
            }
            return false;
        }

        private bool ContainsHealthyFood()
        {
            foreach(T stuff in Foodstuffs)
            {
                if (stuff is IHealthyFood)
                    return true;
            }
            return false;
        }

        private bool ContainsSemiFinishedFood()
        {
            foreach (T stuff in Foodstuffs)
            {
                if (stuff is ISemiFinishedFood)
                    return true;
            }
            return false;
        }

        private bool ContainsSnacks()
        {
            foreach (T stuff in Foodstuffs)
            {
                if (stuff is ISnacks)
                    return true;
            }
            return false;
        }

        private bool ContainsHealthyFoodOnly()
        {
            return ContainsHealthyFood() && !ContainsSemiFinishedFood() && !ContainsSnacks();
        }

        private bool ContainsSemiFinishedFoodOnly()
        {
            return ContainsSemiFinishedFood() && !ContainsHealthyFood() && !ContainsSnacks();
        }

        private bool ContainsSnacksOnly()
        {
            return ContainsSnacks() && !ContainsHealthyFood() && !ContainsSemiFinishedFood();
        }

        private void AddHealthyFood(string element)
        {
            switch (element)
            {
                case "Proteins":
                    Foodstuffs.Add((T)(IFood)new Chicken());
                    return;
                case "Fats":
                    Foodstuffs.Add((T)(IFood)new OliveOil());
                    return;
                case "Carbohydrates":
                    Foodstuffs.Add((T)(IFood)new Fruit());
                    return;
            }
        }

        private void AddSemiFinishedFood(string element)
        {
            switch (element)
            {
                case "Proteins":
                    Foodstuffs.Add((T)(IFood)new DumplingsMeat());
                    return;
                case "Fats":
                    Foodstuffs.Add((T)(IFood)new Cheburek());
                    return;
                case "Carbohydrates":
                    Foodstuffs.Add((T)(IFood)new DumplingsBerries());
                    return;
            }
        }

        private void AddSnacks(string element)
        {
            switch (element)
            {
                case "Proteins":
                    Foodstuffs.Add((T)(IFood)new BalykCheese());
                    return;
                case "Fats":
                    Foodstuffs.Add((T)(IFood)new Crisps());
                    return;
                case "Carbohydrates":
                    Foodstuffs.Add((T)(IFood)new ChocolateBar());
                    return;
            }
        }

        public override string ToString()
        {
            string repr = "";

            foreach (var stuff in Foodstuffs)
                repr += stuff.ToString() + "\n";

            repr += string.Format("Proteins: {0}\n", ContainsProteins());
            repr += string.Format("Fats: {0}\n", ContainsFats());
            repr += string.Format("Carbohydrates: {0}\n", ContainsCarbohydrates());

            return repr;
        }
    }
}
