using Intellenum;

namespace Soenneker.Enums.NotificationChannels;

/// <summary>
/// An enumeration of common notification channels
/// </summary>
[Intellenum<string>]
public sealed partial class NotificationChannel
{
    public static readonly NotificationChannel Errors = new(nameof(Errors));
    public static readonly NotificationChannel Notifications = new(nameof(Notifications));
}