namespace FourthLabSecondSem
{ 
    public class Program { 
        static void Main(string[] args)
        {
            TestClassOne one = new TestClassOne();
            TestClassTwo two = new TestClassTwo();

            List<Object> objects = new List<Object>();
            objects.Add(one);
            objects.Add(two);

            ConsoleReporting reporting = new ConsoleReporting();
            reporting.Parse(objects);
        }
    }
}