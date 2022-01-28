using System;
using System.Collections.Generic;
namespace Piano
{
    class Key : IComparable<Key>
    {
        public Note KeyNote { get; private set; }
        public Accidental KeyAccidental { get; private set; }
        public Octave KeyOctave{ get; private set; }

        public Key(Note note, Accidental accidental, Octave octave)
        {
            this.KeyNote = note;
            this.KeyAccidental = accidental;
            this.KeyOctave = octave;
        }

        //Creating enums for notes, accidentals and octaves
        public enum Note
        {
            A,B,C,D,E,F,G
        }

        public enum Accidental
        {
            Sharp,
            Flat,
            NoSign
        }

        public enum Octave
        {
            First = 1,
            Second = 2,
            Third = 3,
            Fourth = 4,
            Fifth = 5,
            Sixth = 6,
            Seventh = 7
        }

        //Overriding ToString
        public override string ToString()
        {
            var accidentalSymbol = "";

            if (KeyAccidental == Accidental.Sharp)
            {
                accidentalSymbol = "#";
            } 
            else if (KeyAccidental == Accidental.Flat)
            {
                accidentalSymbol = "b";
            } else
            {
                accidentalSymbol = "";
            }

            return KeyNote + "" + accidentalSymbol + " " + $"({(int)KeyOctave})" ;
        }

        //Overriding Equals. Addind logic to compare. 
        public override bool Equals(object obj)
        {

            if (obj == null)
            {
                throw new ArgumentNullException();
            }

            Key otherKey = obj as Key;

            if (

                otherKey is Key &&
                (this.KeyOctave == otherKey.KeyOctave) &&

                (this.KeyNote == Note.C && this.KeyAccidental == Accidental.Sharp) &&
                (otherKey.KeyNote == Note.D && otherKey.KeyAccidental == Accidental.Flat) ||


                (this.KeyNote == Note.D && this.KeyAccidental == Accidental.Sharp) &&
                (otherKey.KeyNote == Note.E && otherKey.KeyAccidental == Accidental.Flat) ||


                (this.KeyNote == Note.F && this.KeyAccidental == Accidental.Sharp) &&
                (otherKey.KeyNote == Note.G && otherKey.KeyAccidental == Accidental.Flat) ||


                (this.KeyNote == Note.G && this.KeyAccidental == Accidental.Sharp) &&
                (otherKey.KeyNote == Note.A && otherKey.KeyAccidental == Accidental.Flat) ||


                (this.KeyNote == Note.A && this.KeyAccidental == Accidental.Sharp) &&
                (otherKey.KeyNote == Note.B && otherKey.KeyAccidental == Accidental.Flat))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }


        //Comparing Octave propery 
        public int CompareTo(Key obj)
        {
            Key otherKey = obj as Key;

            if (this.KeyOctave == otherKey.KeyOctave)
            {
                return 1;
            } else
            {
                return 0;
            }
        }
    }
}
