namespace ThirdLabSecondSem
{
    internal class TopServices
    {
        
        public string Service { get; set; }
        public int Count { get; set; }

        public TopServices(string service, int count)
        {
            Service = service;
            Count = count;
        }
    }
}
