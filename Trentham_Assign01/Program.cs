/*
Shane Trentham
8/29/2019
CSCI 3005-10
This program creates 3 planets and then displays the volume for each
 */
using System;

namespace Trentham_Assign01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Planet first = new Planet();
            Planet second = new Planet();
            Planet third = new Planet();
            PlanetBuilder builder = new PlanetBuilder();

            Console.WriteLine("Define the first planet.");
            builder.BuildPlanet();
            first = builder.GetPlanet();

            Console.WriteLine("Define the second planet.");
            builder.BuildPlanet();
            second = builder.GetPlanet();

            Console.WriteLine("Define the third planet.");
            builder.BuildPlanet();
            third = builder.GetPlanet();
           
            Console.WriteLine("The volume for " + first.getName() + " is: " + first.computeVolume());
            Console.WriteLine("The volume for " + second.getName() + " is: " + second.computeVolume());
            Console.WriteLine("The volume for " + third.getName() + " is: " + third.computeVolume());
        }
    }
}
