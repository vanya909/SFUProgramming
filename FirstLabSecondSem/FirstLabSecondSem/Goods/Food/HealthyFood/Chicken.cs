namespace FirstLabSecondSem
{
    class Chicken : IHealthyFood
    {
        public static string Name { get; } = "Chicken";
        public bool Proteins => true;

        public bool Fats => false;

        public bool Carbohydrates => false;
    }
}
