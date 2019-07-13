using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestXCodingTest.TunningGuitar
{
    public class FourString : Guitar
    {
        public FourString(int FretCount) : base(4, FretCount)
        {
            for (var i = 0; i < FretCount; i++)
            {
                AddFret(new Fret(i, NumStrings,
                                (Notes)((int)(Notes.E + i) % 12),
                                (Notes)((int)(Notes.A + i) % 12),
                                (Notes)((int)(Notes.D + i) % 12),
                                (Notes)((int)(Notes.G + i) % 12)
                                )
                );
            }
        }
    }
}
