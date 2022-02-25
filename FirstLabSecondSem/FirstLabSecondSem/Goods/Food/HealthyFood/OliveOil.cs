namespace FirstLabSecondSem
{
    class OliveOil : IHealthyFood
    {
        public static string Name { get; } = "OliveOil";
        public bool Proteins => false;

        public bool Fats => true;

        public bool Carbohydrates => false;
    }
}
