using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.NotificationChannels;

/// <summary>
/// An enumeration of common notification channels
/// </summary>
[EnumValue<string>]
public sealed partial class NotificationChannel
{
    /// <summary>
    /// The errors.
    /// </summary>
    public static readonly NotificationChannel Errors = new(nameof(Errors));
    /// <summary>
    /// The notifications.
    /// </summary>
    public static readonly NotificationChannel Notifications = new(nameof(Notifications));
}