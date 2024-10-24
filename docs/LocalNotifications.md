# Local Notification (WIP)

## Description

The `LocalNotification` class provides methods for sending instant notifications and scheduling notifications with optional recurrence, which are handled via .NET MAUI. The notifications can include a custom small icon, and this service can persist notification schedules across device reboots.

## Usage

### Accessing the `localNotification` Object

After including the script, you can access the `localNotification` instance as follows:

```javascript
const { localNotification } = maui2js;
```

Methods
1. sendInstantNotification

This method sends an instant notification with the specified title, message, and optional small icon.

```javascript
localNotification.sendInstantNotification(
  "Notification Title", 
  "Notification message", 
  smallIconResourceId // optional. A vaid icon id based from your MAUI App Resource Id's
).then(result => {
    console.log('Notification sent:', result);
}).catch(error => {
    console.error('Error sending notification:', error);
});

```

2. ScheduleNotificationAsync

Schedules a notification to be triggered at a later time with optional recurrence and a custom small icon.
```javascript
localNotification.ScheduleNotificationAsync(
  "Notification Title",
  "Notification message",
  new Date("2024-10-31T12:30:00"),
  smallIconResourceId // optional
).then(result => {
    console.log('Notification scheduled:', result);
}).catch(error => {
    console.error('Error scheduling notification:', error);
});
```