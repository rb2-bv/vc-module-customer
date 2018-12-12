using System;

namespace VirtoCommerce.CustomerModule.Data.Model
{
    [Flags]
    public enum MemberResponseGroup
    {
        Default = 0,
        WithNotes = 1 << 0,
        WithEmails = 1 << 1,
        WithAddresses = 1 << 2,
        WithPhones = 1 << 3,
        WithGroups = 1 << 4,
        WithSecurityAccounts = 1 << 5,
        WithDynamicProperties = 1 << 6,
        WithSeo = 1 << 7,
        Full = WithNotes | WithEmails | WithEmails | WithAddresses | WithPhones | WithGroups | WithSecurityAccounts | WithDynamicProperties | WithSeo
    }
}
