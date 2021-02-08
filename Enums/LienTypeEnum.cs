using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSLibraries.Enums
{
    public enum LienTypeEnum
    {
        CollateralSearch = 1,
        PrincipalRepayment = 2,
        InterestRepayment = 3,
        OverdraftCleanUp = 4,
        APGBooking = 5,
        APSRequest = 6,
        WriteOff = 7,
        CollateralCreation = 8
    }
}
