namespace FirstLabSecondSem
{
    class ChocolateBar : ISnacks
    {
        public static string Name { get; } = "ChocolateBar";
        public bool Proteins => false;

        public bool Fats => false;

        public bool Carbohydrates => true;
    }
}
