    internal class Auto : Jarmu
    {

        public string model { get; set; }

        public Auto()
        {

        }

        public void EloreHaladas(int hanyMetert)
        {
            for (int i = 0; i < hanyMetert; i++)
            {
                System.Console.Write("=");
            }
            System.Console.Write("#  ide ért az autó!\n");
        }
    }