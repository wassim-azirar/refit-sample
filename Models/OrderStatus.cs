using System.Runtime.Serialization;

namespace RefitSample.Models;

public enum OrderStatus
{
    [EnumMember(Value = @"placed")]
    Placed = 0,

    [EnumMember(Value = @"approved")]
    Approved = 1,

    [EnumMember(Value = @"delivered")]
    Delivered = 2
}