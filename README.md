[![](https://img.shields.io/nuget/v/soenneker.enums.notificationchannels.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.notificationchannels/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.notificationchannels/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.notificationchannels/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.notificationchannels.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.notificationchannels/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.notificationchannels/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.notificationchannels/actions/workflows/codeql.yml)

# Soenneker.Enums.NotificationChannels

A string-backed enum-value type for routing operational messages to an error or general-notification channel.

## Install

```bash
dotnet add package Soenneker.Enums.NotificationChannels
```

## Usage

```csharp
using Soenneker.Enums.NotificationChannels;

NotificationChannel channel = NotificationChannel.Errors;
string wireValue = channel.Value; // "Errors"

if (NotificationChannel.TryFromValue(input, out NotificationChannel? parsed))
{
    // Resolve parsed to a destination in your notification configuration
}
```

Available values:

- `Errors` — failures that need investigation
- `Notifications` — general informational and operational messages

`System.Text.Json` serializes the type as its string value and restores recognized values to the shared static instances. `FromValue` throws for unknown input; use `TryFromValue` at configuration or request boundaries. `FromName` and `TryFromName` are also generated.

These are logical categories, not provider channel IDs, URLs, email addresses, or queues. The consuming application must map each value to a destination and define delivery, retry, deduplication, and escalation behavior. Do not include secrets or sensitive payload data merely because a message is routed to `Errors`.
