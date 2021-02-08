using System;
using System.Collections.Generic;
using System.Text;

namespace GOSLibraries.Enums
{
    public enum LoanScheduleTypeEnum
    {
        Annuity = 1,
        ReducingBalance = 2,
        BulletPayment = 3,
        IrregularSchedule = 5,
        ConstantPrincipalAndInterest = 6,
        BallonPayment = 7
    }
}
