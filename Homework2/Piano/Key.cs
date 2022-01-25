using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    struct Key
    {
        public Note note { get; private set; }
        public Accidental accidental { get; private set; }
        public Octave octave{ get; private set; }

        public Key(Note note, Accidental accidental, Octave octave)
        {
            this.note = note;
            this.accidental = accidental;
            this.octave = octave;
        }

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

        public override string ToString()
        {
            return note + "" + accidental + " " + $"({(int)octave})" ;
        }
    }
}
