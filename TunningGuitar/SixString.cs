using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestXCodingTest.TunningGuitar
{
    public class SixString: Guitar
    {
        public SixString(int FretCount) : base(6, FretCount)
        {
            for (var i = 0; i < FretCount; i++)
            {
                AddFret(new Fret(i, NumStrings,
                                (Notes)((int)(Notes.E + i) % 12),
                                (Notes)((int)(Notes.A + i) % 12),
                                (Notes)((int)(Notes.D + i) % 12),
                                (Notes)((int)(Notes.G + i) % 12),
                                (Notes)((int)(Notes.B + i) % 12),
                                (Notes)((int)(Notes.E + i) % 12)
                                )
                );
            }
        }
    }
}
