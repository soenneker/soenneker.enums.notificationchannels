using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.NotificationChannels;

/// <summary>
/// Identifies the destination channel used to categorize operational messages.
/// </summary>
[EnumValue<string>]
public sealed partial class NotificationChannel
{
    /// <summary>
    /// Error and failure notifications requiring investigation.
    /// </summary>
    public static readonly NotificationChannel Errors = new(nameof(Errors));
    /// <summary>
    /// General informational and operational notifications.
    /// </summary>
    public static readonly NotificationChannel Notifications = new(nameof(Notifications));
}
