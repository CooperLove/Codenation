using Codenation.Challenge;
using System;


namespace Source
{
    public class program
    {
        static void Main (string[] args){
            // netstandard2.0  netcoreapp3.1
            Country c = new Country();
            State[] states =  c.Top10StatesByArea();
            foreach (State s in states)
            {
                Console.WriteLine($"{s.Name} {s.Acronym}");
            }
        }
    }
}