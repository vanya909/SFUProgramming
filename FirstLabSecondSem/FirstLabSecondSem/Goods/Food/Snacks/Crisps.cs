namespace FirstLabSecondSem
{
    class Crisps : ISnacks
    {
        public static string Name { get; } = "Crisps";
        public bool Proteins => false;

        public bool Fats => true;

        public bool Carbohydrates => false;
    }
}
