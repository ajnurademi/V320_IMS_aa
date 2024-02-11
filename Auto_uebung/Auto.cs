using System;

namespace Auto_uebung
{
    public class Auto
    {
        public void Anlassen()
        {
            Console.WriteLine("Auto anlassen");
            Motor motor = new Motor();
            motor.Starten();
        }
    }
}
