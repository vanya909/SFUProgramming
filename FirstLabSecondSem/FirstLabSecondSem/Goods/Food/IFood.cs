namespace FirstLabSecondSem
{
    interface IFood : IThing
    {
        bool Proteins { get; }
        bool Fats { get; }
        bool Carbohydrates { get; }
    }
}
