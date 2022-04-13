using System.Reflection;

namespace FourthLabSecondSem
{
    internal class ConsoleReporting
    {
        public void Parse(List<Object> objects)
        {
            foreach (Object obj in objects)
            {
                bool horizontalPrint = obj.GetType().GetCustomAttributes(typeof(HorizontalAlignmentAttribute)).Any();


                Console.WriteLine($"****** {obj.GetType().Name} Report ******");

                if (horizontalPrint)
                    HorizontalPrint(obj);
                else
                    VerticalPrint(obj);

                Console.WriteLine();
            }
        }
        private void HorizontalPrint(Object src)
        {
            foreach (PropertyInfo property in GetPropertiesToPrint(src))
            {
                Console.Write($"{property.Name}: {property.GetValue(src)}");
                Console.Write(" | ");
            }
            Console.WriteLine();
        }

        private void VerticalPrint(Object src)
        {
            foreach (PropertyInfo property in GetPropertiesToPrint(src))
                Console.WriteLine($"{property.Name}: {property.GetValue(src)}");
        }

        private static List<PropertyInfo> GetPropertiesToPrint(Object obj)
        {
            return obj.
                   GetType().
                   GetProperties().
                   Where(p => !p.GetCustomAttributes(typeof(NotPrintableAttribute)).Any()).
                   ToList();
        }
    }
}
