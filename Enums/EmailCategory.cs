using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSLibraries.Enums
{
    public enum EmailCategory
    {
        LoanApplication = 1,
        OfferLetter = 2
    }

    public enum EmailStatus
    {
        Sent = 1, 
        Awaiting = 2,
        Failed = -3,
        Read = 3,
        Received = 0
    }

    public enum EmailAction
    {
        Sender = 1,
        Receiver = 0
    }

    public enum MailTypeSelector
    {
        Account_Detail = 1,
        Login,
        Register,
        Inprocess_Workflow,
        Final_On_Workflow,
    }

    public enum EmailTemplate
    {
        Login = 1,
        Registration = 2,
        Default = 0, 
        LoginDetails = 3,
        Advert = 4,
        OTP = 5
    }
}
