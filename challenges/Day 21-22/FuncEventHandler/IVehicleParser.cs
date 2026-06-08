using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_21_22.FuncEventHandler
{
    internal interface IVehicleParser
    {
        Vehicle ParseLine(string rawLine);
    }
}
