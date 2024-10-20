
# Permissions Class

## Overview

The `Permissions` class provides methods to check and request various permissions for device capabilities, such as camera, location, and notifications.

## Usage

To use the `Permissions` class, first import the `Permissions` object from `maui2js`:

```js
const { permissions } = maui2js;
```

### Example

```js
async function checkPermissions() {
    const cameraPermissionGranted = await permissions.isCameraPermissionGranted();
    if (!cameraPermissionGranted) {
        const requested = await permissions.requestCameraPermission();
        console.log(`Camera permission requested: ${requested}`);
    } else {
        console.log('Camera permission already granted.');
    }
}
```

## Available Methods

### Battery

- `isBatteryPermissionGranted(): Promise<boolean>`
- `requestBatteryPermission(): Promise<boolean>`

### Bluetooth

- `isBluetoothPermissionGranted(): Promise<boolean>`
- `requestBluetoothPermission(): Promise<boolean>`

### Calendar

- `isCalendarReadPermissionGranted(): Promise<boolean>`
- `requestCalendarReadPermission(): Promise<boolean>`
- `isCalendarWritePermissionGranted(): Promise<boolean>`
- `requestCalendarWritePermission(): Promise<boolean>`

### Camera

- `isCameraPermissionGranted(): Promise<boolean>`
- `requestCameraPermission(): Promise<boolean>`

### Contacts

- `isContactsReadPermissionGranted(): Promise<boolean>`
- `requestContactsReadPermission(): Promise<boolean>`
- `isContactsWritePermissionGranted(): Promise<boolean>`
- `requestContactsWritePermission(): Promise<boolean>`

### Flashlight

- `isFlashlightPermissionGranted(): Promise<boolean>`
- `requestFlashlightPermission(): Promise<boolean>`

### Launch App

- `isLaunchAppPermissionGranted(): Promise<boolean>`
- `requestLaunchAppPermission(): Promise<boolean>`

### Location

- `isLocationWhenInUsePermissionGranted(): Promise<boolean>`
- `requestLocationWhenInUsePermission(): Promise<boolean>`
- `isLocationAlwaysPermissionGranted(): Promise<boolean>`
- `requestLocationAlwaysPermission(): Promise<boolean>`

### Maps

- `isMapsPermissionGranted(): Promise<boolean>`
- `requestMapsPermission(): Promise<boolean>`

### Media

- `isMediaPermissionGranted(): Promise<boolean>`
- `requestMediaPermission(): Promise<boolean>`

### Microphone

- `isMicrophonePermissionGranted(): Promise<boolean>`
- `requestMicrophonePermission(): Promise<boolean>`

### Nearby WiFi Devices

- `isNearbyWifiDevicesPermissionGranted(): Promise<boolean>`
- `requestNearbyWifiDevicesPermission(): Promise<boolean>`

### Network State

- `isNetworkStatePermissionGranted(): Promise<boolean>`
- `requestNetworkStatePermission(): Promise<boolean>`

### Phone

- `isPhonePermissionGranted(): Promise<boolean>`
- `requestPhonePermission(): Promise<boolean>`

### Photos

- `isPhotosPermissionGranted(): Promise<boolean>`
- `requestPhotosPermission(): Promise<boolean>`
- `isPhotosAddOnlyPermissionGranted(): Promise<boolean>`
- `requestPhotosAddOnlyPermission(): Promise<boolean>`

### Post Notifications

- `isPostNotificationsPermissionGranted(): Promise<boolean>`
- `requestPostNotificationsPermission(): Promise<boolean>`

### Reminders

- `isRemindersPermissionGranted(): Promise<boolean>`
- `requestRemindersPermission(): Promise<boolean>`

### Sensors

- `isSensorsPermissionGranted(): Promise<boolean>`
- `requestSensorsPermission(): Promise<boolean>`

### SMS

- `isSmsPermissionGranted(): Promise<boolean>`
- `requestSmsPermission(): Promise<boolean>`

### Speech

- `isSpeechPermissionGranted(): Promise<boolean>`
- `requestSpeechPermission(): Promise<boolean>`

### Storage

- `isStorageReadPermissionGranted(): Promise<boolean>`
- `requestStorageReadPermission(): Promise<boolean>`
- `isStorageWritePermissionGranted(): Promise<boolean>`
- `requestStorageWritePermission(): Promise<boolean>`

