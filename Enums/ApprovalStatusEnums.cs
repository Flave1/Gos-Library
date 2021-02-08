using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GOSLibraries.Enums
{
    public enum ApprovalStatus

    {
        Pending = 0,
        Processing = 1,
        Approved = 2,
        Disapproved = 3,
        Authorised = 4,
        Revert = 5,
        Awaiting = 6
    }

    public enum WorkflowTaskStatus
    {
        Created = 1,
        Viewed,
        Done,
        Referred,
        Authorised,
        Disapproved,
        Completed
    }

    public enum PaymentTermsPhase
    {
        Phase_1 = 1,
        Phase_2,
        Phase_3,
        Phase_4,
        Phase_5,
        Phase_6,
        Phase_7,
        Phase_8,
        Phase_9,
        Phase_10,
        Phase_11,
        Phase_12,
        Phase_13,
        Phase_14,
        Phase_15,
        Phase_16,
        Phase_17,
        Phase_18,
        Phase_19,
        Phase_20,
    }

    public enum DecisionResult
    {
        Win = 1,
        Lost,
        [Description("N/A")]
        Non_Applicable
    }

    public enum JobProgressStatus
    {
        [Description("Executed Successfully")]
        Executed_Successfully = 1,
        [Description("In-Progress")]
        In_Progress,
        [Description("Cancelled")]
        Cancelled,
        [Description("Not Executed")]
        Not_Executed,
        [Description("Not Started")]
        Not_Started
    }

    public enum PaymentStatus
    {
        Paid = 1,
        Not_Paid,
        Canceled
    }

    public enum BusinessType
    {
        Sole_Proprietorship = 1,
        Partnership,
        Limited_Liability_Company,
        NGO,
        Private_Company,
        Public_Company,
        Others
    }

    public enum Identification
    {
        International_Passport = 1,
        National_ID,
        Drivers_License,
        Business_ID,
        Others

    }
}
