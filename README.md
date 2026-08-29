[![](https://img.shields.io/nuget/v/soenneker.enums.notificationchannels.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.notificationchannels/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.notificationchannels/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.notificationchannels/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.notificationchannels.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.notificationchannels/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.notificationchannels/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.notificationchannels/actions/workflows/codeql.yml)

# Soenneker.Enums.NotificationChannels

Identifies the destination channel used to categorize operational messages.

## Install

```bash
dotnet add package Soenneker.Enums.NotificationChannels
```

## What you get

- `NotificationChannel` — Identifies the destination channel used to categorize operational messages.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `NotificationChannel.Errors` | Error and failure notifications requiring investigation. | Error and failure notifications requiring investigation. |
| `NotificationChannel.Notifications` | General informational and operational notifications. | General informational and operational notifications. |
