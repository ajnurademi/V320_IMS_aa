using System;

namespace Auto_uebung
{
    public class Motor
    {
        public void Starten()
        {
            Console.WriteLine("Motor starten");
            Benzinpumpe pumpe = new Benzinpumpe();
            Anlasser anlasser = new Anlasser();
            pumpe.Pumpen();
            anlasser.Starten();
            Regeln(anlasser);
        }

        private void Regeln(Anlasser anlasser)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Motor regeln");
            }
            anlasser.Stoppen();
        }
    }
}
