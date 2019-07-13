using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestXCodingTest.TunningGuitar
{
    public class Fret
    {
        public int NumStrings { get; set; }
        public int Rank { get; set; }
        private Notes[] _notes;

        public Fret(int rank, int numStrings, params Notes[] StringNotes)
        {
            Rank = rank;
            NumStrings = numStrings;

            if (StringNotes == null)
            {
                throw new ArgumentNullException("Not the same number of notes as strings");
            }
            else if (StringNotes.Length != numStrings)
            {
                throw new ArgumentException("Not the same number of notes as strings");
            }

            _notes = new Notes[numStrings];
            for (var i = 0; i < NumStrings; _notes[i] = StringNotes[i++]);
        }

        public Notes GetNote(int stringNumber)
        {
            Notes result = Notes.A;

            if (stringNumber < NumStrings + 1)
            {
                result = _notes[stringNumber - 1];
            }
            else
            {
                throw new ArgumentOutOfRangeException($"String '{stringNumber}' does not exist on this guitar");
            }

            return result;
        }
    }
}
