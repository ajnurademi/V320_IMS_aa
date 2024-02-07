namespace Auto_uebung
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Auto meinAuto = new Auto();
            Motor meinMotor = new Motor();

            meinAuto.Anlassen(meinMotor);
        }
           

        // Klasse für das Auto
        class Auto
        {
            public void Anlassen(Motor motor)
            {
                Console.WriteLine("Auto anlassen");
                motor.Starten();
            }
        }

        // Klasse für den Motor
        class Motor
        {
            public void Starten()
            {
                Console.WriteLine("Motor starten");
                Benzinpumpe pump = new Benzinpumpe();
                Anlasser starter = new Anlasser();
                pump.Pumpen();
                starter.Starten();
                Regeln();
            }

            private void Regeln()
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Motor regeln");
                }
                Anlasser starter = new Anlasser();
                starter.Stoppen();
            }
        }

        // Klasse für die Benzinpumpe
        class Benzinpumpe
        {
            public void Pumpen()
            {
                Console.WriteLine("Pumpen");
            }
        }

        // Klasse für den Anlasser
        class Anlasser
        {
            public void Starten()
            {
                Console.WriteLine("Anlasser gestartet");
            }

            public void Stoppen()
            {
                Console.WriteLine("Anlasser gestoppt");
            }
        }
        }

        

    }

