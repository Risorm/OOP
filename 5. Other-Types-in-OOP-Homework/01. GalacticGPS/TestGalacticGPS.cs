﻿namespace _01.GalacticGPS
{
    public static class TestGalacticGps
    {
        static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            System.Console.WriteLine(home);
        }
    }
}