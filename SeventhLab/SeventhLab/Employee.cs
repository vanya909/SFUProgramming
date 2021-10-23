namespace SeventhLab
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
