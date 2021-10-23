namespace SeventhLab
{
    class Cashier : Employee
    {
        public string Qualification { set; get; }

        public override string GetFullName()
        {
            return FirstName + " " + LastName + " " + Qualification;
        }
    }
}
