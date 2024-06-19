using System.Runtime.Serialization;

namespace Wzdx.v4.WorkZones
{
    /// <summary>
    /// The type of WZDx road event
    /// </summary>
    public enum EventType
    {
        [EnumMember(Value = @"work-zone")]
        WorkZone = 1,
        [EnumMember(Value = @"detour")]
        Detour = 2,
        [EnumMember(Value = @"restriction")]
        Restriction = 3,
        [EnumMember(Value = @"incident")]
        Incident = 4,
    }
}