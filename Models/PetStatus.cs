using System.Runtime.Serialization;

namespace RefitSample.Models;

public enum PetStatus
{
    [EnumMember(Value = @"available")]
    Available = 0,

    [EnumMember(Value = @"pending")]
    Pending = 1,

    [EnumMember(Value = @"sold")]
    Sold = 2
}