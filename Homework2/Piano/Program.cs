using System;
using static Piano.Key;

namespace Piano
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# of the first octave
            Key c = new (Note.C, Accidental.Sharp, Octave.First);
            Console.WriteLine(c); // C# (1)

            // D flat of the first octave
            Key d = new (Note.D, Accidental.Flat, Octave.First);

            Console.WriteLine(c.Equals(d)); // True, is the same key!
            Console.WriteLine(c.CompareTo(d)); // 0

        }
    }
}
