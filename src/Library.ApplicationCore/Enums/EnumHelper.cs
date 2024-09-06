using System.ComponentModel;
using System.Reflection;

namespace Library.ApplicationCore.Enums
{
    public static class EnumHelper
    {
        private static readonly Dictionary<LoanExtensionStatus, string> LoanExtensionStatusDescriptions = new()
        {
            { LoanExtensionStatus.Success, GetEnumDescription(LoanExtensionStatus.Success) },
            { LoanExtensionStatus.LoanNotFound, GetEnumDescription(LoanExtensionStatus.LoanNotFound) },
            { LoanExtensionStatus.LoanExpired, GetEnumDescription(LoanExtensionStatus.LoanExpired) },
            { LoanExtensionStatus.MembershipExpired, GetEnumDescription(LoanExtensionStatus.MembershipExpired) },
            { LoanExtensionStatus.LoanReturned, GetEnumDescription(LoanExtensionStatus.LoanReturned) },
            { LoanExtensionStatus.Error, GetEnumDescription(LoanExtensionStatus.Error) }
        };

        private static readonly Dictionary<LoanReturnStatus, string> LoanReturnStatusDescriptions = new()
        {
            { LoanReturnStatus.Success, GetEnumDescription(LoanReturnStatus.Success) },
            { LoanReturnStatus.LoanNotFound, GetEnumDescription(LoanReturnStatus.LoanNotFound) },
            { LoanReturnStatus.AlreadyReturned, GetEnumDescription(LoanReturnStatus.AlreadyReturned) },
            { LoanReturnStatus.Error, GetEnumDescription(LoanReturnStatus.Error) }
        };

        private static readonly Dictionary<MembershipRenewalStatus, string> MembershipRenewalStatusDescriptions = new()
        {
            { MembershipRenewalStatus.Success, GetEnumDescription(MembershipRenewalStatus.Success) },
            { MembershipRenewalStatus.PatronNotFound, GetEnumDescription(MembershipRenewalStatus.PatronNotFound) },
            { MembershipRenewalStatus.TooEarlyToRenew, GetEnumDescription(MembershipRenewalStatus.TooEarlyToRenew) },
            { MembershipRenewalStatus.LoanNotReturned, GetEnumDescription(MembershipRenewalStatus.LoanNotReturned) },
            { MembershipRenewalStatus.Error, GetEnumDescription(MembershipRenewalStatus.Error) }
        };

        private static string GetEnumDescription(Enum value)
        {
            FieldInfo? field = value.GetType().GetField(value.ToString());
            DescriptionAttribute? attribute = field?.GetCustomAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description ?? value.ToString();
        }

        public static string GetDescription(Enum value)
        {
            if (value == null)
                return string.Empty;

            if (value is LoanExtensionStatus loanExtensionStatus)
                return LoanExtensionStatusDescriptions[loanExtensionStatus];

            if (value is LoanReturnStatus loanReturnStatus)
                return LoanReturnStatusDescriptions[loanReturnStatus];

            if (value is MembershipRenewalStatus membershipRenewalStatus)
                return MembershipRenewalStatusDescriptions[membershipRenewalStatus];

            return value.ToString();
        }
    }
}