namespace FirstLabSecondSem
{
    class DumplingsMeat : ISemiFinishedFood
    {
        public static string Name { get; } = "DumplingsMeat";
        public bool Proteins => true;

        public bool Fats => false;

        public bool Carbohydrates => false;
    }
}
