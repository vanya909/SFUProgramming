namespace FourthLabSecondSem
{
    [HorizontalAlignment]
    internal class TestClassOne
    {
        public string OneOne { get; set; } = "OneOne";
        public string TwoOne { get; set; } = "TwoOne";
        public int ThreeOne { get; set; } = 31;
        public int FourOne { get; set; } = 41;

        [NotPrintable]
        public int Secret { get; set; } = 111;
           
    }
}
