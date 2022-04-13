namespace FourthLabSecondSem
{
    internal class TestClassTwo
    {
        public string OneTwo { get; set; } = "OneTwo";
        public string TwoTwo { get; set; } = "TwoTwo";
        public int ThreeTwo { get; set; } = 32;
        public int FourTwo { get; set; } = 42;

        [NotPrintable]
        public int SecretToo { get; set; } = 555;
    }
}
