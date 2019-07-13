using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestXCodingTest.TunningGuitar
{
    public class Guitar
    {
        public int NumStrings { get; set; }
        public int NumFrets { get; set; }
        public Fret[] Frets { get; set; }

        public Guitar(int StringCount, int FretCount)
        {
            NumStrings = StringCount;
            NumFrets = FretCount;
            Frets = new Fret[NumFrets];
        }

        public bool AddFret(Fret newFret)
        {
            var  result = false;

            if (newFret.Rank > 0 && newFret.Rank <= NumFrets)
            {
                Frets[newFret.Rank - 1] = newFret;
                result = true;
            }

            return result;
        }

        public Notes GetNote(int FretNum, int StringNum)
        {
            Notes result;

            if (FretNum >= 0 && FretNum < NumFrets)
            {
                result = Frets[FretNum].GetNote(StringNum);
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Fret '{FretNum}' does not exist on this guitar");
            }

            return result;
        }

        public bool IsSameNote(int fretNum, int stringNum, Notes note)
        {
            var result = false;

            if (fretNum >= 0 && fretNum < NumFrets && stringNum > 0 && stringNum <= NumStrings)
            {
                result = note == Frets[fretNum].GetNote(stringNum);
            }

            return result;
        }
    }
}
