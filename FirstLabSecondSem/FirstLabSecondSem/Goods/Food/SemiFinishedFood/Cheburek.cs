namespace FirstLabSecondSem
{
    class Cheburek : ISemiFinishedFood
    {
        public static string Name { get; } = "Cheburek";
        public bool Proteins => false;

        public bool Fats => true;

        public bool Carbohydrates => false;
    }
}
