    abstract class Jarmu
    {

        public EJarmuTipus tipus { get; set; }
        public int evjarat { get; set; }
        public EUzemanyag uzemanyag { get; set; }
        public string szin { get; set; }


        public Jarmu()
        {

        }

        public void Start()
        {
            System.Console.WriteLine("A motor el lett indítva!");
        }
        public void Stop()
        {
            System.Console.WriteLine("A motor le lett állítva!");
        }
        public void GPSNyomkovetes()
        {
            System.Console.WriteLine("GPS-es nyomkövetés aktiválva!");
        }

        public void KormanyTekereseBalra()
        {
            System.Console.WriteLine("A kormány el lett tekerve balra");
        }


    }