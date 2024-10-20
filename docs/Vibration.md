# Vibration

## Uses [Maui Vibration](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/device/vibrate?view=net-maui-8.0&tabs=android)

## Description

`Vibration` is a TypeScript class that provides methods to control the vibration functionality in a web application. It allows you to start and stop vibrations for specified durations.

## Usage

### Accessing the vibration Object

After including the script, you can access the `vibration` instance as follows:

```javascript
const { vibration } = maui2js;
```
Methods
1. Starting Vibration

To start vibrating for a specified duration, use the startVibration method:

```javascript

vibration.startVibration(2000); // Vibrate for 2000 milliseconds (2 seconds)
```

You can also specify the duration as a hh:mm:ss object (note that the maximum duration allowed is 5 seconds).

```javascript
vibration.startVibration("00:00:02"); // Vibrate for 2 seconds
```

2. Stopping Vibration

To stop any ongoing vibration, use:

```javascript
vibration.stopVibration().then(() => {
    console.log('Vibration stopped.');
}).catch(error => {
    console.error('Error stopping vibration:', error);
});
```