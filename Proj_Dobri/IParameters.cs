using System;
using System.Collections.Generic;
using System.Text;

namespace Proj_Dobri
{
    interface IParameters
    {
        int Amount { get; set; }
        double Rate { get; set; }
        int Term { get; set; }
    }
}
