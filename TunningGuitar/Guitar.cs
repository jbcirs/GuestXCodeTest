using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestXCodingTest.TunningGuitar
{
    public class Guitar
    {
        public IEnumerable<string> OneFretType { get; set; }
        public string FretPosition { get; set; }
        public string NotePosition { get; set; }
        public int stringCount { get; set; }

        public bool Compare()
        {
            return OneFretType.Any(t => t == FretPosition) ? true : false;
        }
    }
}
