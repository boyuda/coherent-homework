using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    struct Key
    {
        public Note _Note { get; set; }
        public Accidental _Accidental { get; set; }
        public Octave _Octave{ get; set; }

        public Key(Note note, Accidental accidental, Octave octave)
        {
            _Note = note;
            _Accidental = accidental;
            _Octave = octave;

        }

        public enum Note
        {
            A,B,C,D,E,F
        }

        public enum Accidental
        {
            Sharp,
            Flat
        }

        public enum Octave
        {
            First,
            Second,
            Third,
            Fourth,
            Fifth,
            Sixth,
            Seventh
        }
    }
}
