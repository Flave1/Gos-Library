using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSLibraries.Enums
{
    public enum LoanApplicationStatusEnum
    {
        ApplicationInProgress = 1,
        ApplicationCompleted = 2,
        CAMInProgress = 3,
        CAMCompleted = 4,
        OfferLetterGenerationInProgress = 5,
        OfferLetterGenerationCompleted = 6,
        OfferLetterReviewInProgress = 7,
        OfferLetterReviewCompleted = 8,
        ChecklistInProgress = 13,
        ChecklistCompleted = 14,
    }


    public enum WebsiteLoanApplicationStatusEnum
    {
        ApplicationInProgress = 1,
        ApplicationCompleted = 2,
    }
}
