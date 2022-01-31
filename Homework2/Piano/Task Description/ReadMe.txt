Task 1. You need to create a Key structure to represent a key on a piano keyboard (see figure).

The characteristics of the key are:
1. Octave (this is a member of the Octave enumeration).
2. English alphabetic name of the note (enumeration element Note).
3. Alteration sign - no sign, sharp, flat (elements of the Accidental enumeration).
Provide the structure with a constructor, override the ToString () and Equals () methods.

Implement in the structure the standard System.IComparable <T> interface for comparing
two keys.
An example of a possible use of your structure:
// C# of the first octave
Key c = new Key(Note.C, Accidental.Sharp, Octave.First);
Console.WriteLine(c); // C# (1)
// D flat of the first octave
Key d = new Key(Note.D, Accidental.Flat, Octave.First);
Console.WriteLine(c.Equals(d)); // True, is the same key!
Console.WriteLine(c.CompareTo(d));