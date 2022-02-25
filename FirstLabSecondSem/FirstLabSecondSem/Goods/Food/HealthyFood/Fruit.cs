namespace FirstLabSecondSem
{
    class Fruit : IHealthyFood
    {
        public static string Name { get; } = "Fruit";
        public bool Proteins => false;

        public bool Fats => false;

        public bool Carbohydrates => true;
    }
}
