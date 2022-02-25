namespace FirstLabSecondSem
{
    class BalykCheese : ISnacks
    {
        public static string Name { get; } = "BalykCheese";
        public bool Proteins => true;

        public bool Fats => false;

        public bool Carbohydrates => false;
    }
}
