namespace FirstLabSecondSem
{
    interface IThing
    {
        static string Name { get; }

        public string ToString()
        {
            return Name;
        }
    }
}
