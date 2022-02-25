namespace FirstLabSecondSem
{
    class DumplingsBerries : ISemiFinishedFood
    {
        public static string Name { get; } = "DumplingsBerries";
        public bool Proteins => false;

        public bool Fats => false;

        public bool Carbohydrates => true;
    }
}
