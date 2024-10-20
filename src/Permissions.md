# Permissions Required for MAUI Applications

This document outlines the permissions required for different platforms in a MAUI application.

## Android Permissions

Add the following permissions to your `AndroidManifest.xml`:

```xml
<manifest xmlns:android="http://schemas.android.com/apk/res/android" package="com.example.yourapp">
    <uses-permission android:name="android.permission.BATTERY_STATS" />
    <uses-permission android:name="android.permission.BLUETOOTH" />
    <uses-permission android:name="android.permission.READ_CALENDAR" />
    <uses-permission android:name="android.permission.WRITE_CALENDAR" />
    <uses-permission android:name="android.permission.CAMERA" />
    <uses-permission android:name="android.permission.READ_CONTACTS" />
    <uses-permission android:name="android.permission.WRITE_CONTACTS" />
    <uses-permission android:name="android.permission.FLASHLIGHT" />
    <uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
    <uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />
    <uses-permission android:name="android.permission.MAPS_RECEIVE" />
    <uses-permission android:name="android.permission.READ_MEDIA" />
    <uses-permission android:name="android.permission.RECORD_AUDIO" />
    <uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
    <uses-permission android:name="android.permission.READ_PHONE_STATE" />
    <uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE" />
    <uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
    <uses-permission android:name="android.permission.VIBRATE" />
    <uses-permission android:name="android.permission.RECEIVE_SMS" />
    <uses-permission android:name="android.permission.READ_REMINDERS" />
    <uses-permission android:name="android.permission.READ_SENSORS" />
    <uses-permission android:name="android.permission.READ_SMS" />
    <uses-permission android:name="android.permission.SPEECH" />
    <uses-permission android:name="android.permission.POST_NOTIFICATIONS" />
</manifest>
```

## iOS Permissions

Add the following permissions to your `Info.plist`:

```xml
    <key>NSBluetoothAlwaysUsageDescription</key>
    <string>This app requires Bluetooth access.</string>
    <key>NSCameraUsageDescription</key>
    <string>This app requires camera access.</string>
    <key>NSContactsUsageDescription</key>
    <string>This app requires access to your contacts.</string>
    <key>NSLocationAlwaysUsageDescription</key>
    <string>This app requires access to your location.</string>
    <key>NSLocationWhenInUseUsageDescription</key>
    <string>This app requires access to your location while in use.</string>
    <key>NSMicrophoneUsageDescription</key>
    <string>This app requires access to the microphone.</string>
    <key>NSPhotoLibraryUsageDescription</key>
    <string>This app requires access to your photo library.</string>
    <key>NSPhotoLibraryAddUsageDescription</key>
    <string>This app requires permission to add photos.</string>
    <key>NSRemindersUsageDescription</key>
    <string>This app requires access to your reminders.</string>
    <key>NSSpeechRecognitionUsageDescription</key>
    <string>This app requires access to speech recognition.</string>
    <key>NSVibrationUsageDescription</key>
    <string>This app requires access to vibrate your device.</string>
    <key>NSUserTrackingUsageDescription</key>
    <string>This app requires tracking permission.</string>
```

## Windows Permissions

Add the following permissions to your `Package.appxmanifest`:

```xml
<Package ...>
    <Capabilities>
        <Capability Name="internetClient" />
        <DeviceCapability Name="location" />
        <DeviceCapability Name="webcam" />
        <DeviceCapability Name="microphone" />
        <DeviceCapability Name="reminders" />
        <DeviceCapability Name="contacts" />
        <DeviceCapability Name="picturesLibrary" />
        <DeviceCapability Name="musicLibrary" />
        <DeviceCapability Name="videosLibrary" />
        <DeviceCapability Name="vibrate" />
        <DeviceCapability Name="bluetooth" />
        <DeviceCapability Name="sms" />
        <DeviceCapability Name="calendar" />
    </Capabilities>
</Package>
```

## Tizen Permissions

Add the following permissions to your `tizen-manifest.xml`:

```xml
<tizen-manifest version="2.4">
    <application id="your.application.id" package="your.application.package" required-version="2.4">
        <privileges>
            <privilege>http://tizen.org/privilege/internet</privilege>
            <privilege>http://tizen.org/privilege/location</privilege>
            <privilege>http://tizen.org/privilege/contacts</privilege>
            <privilege>http://tizen.org/privilege/camera</privilege>
            <privilege>http://tizen.org/privilege/microphone</privilege>
            <privilege>http://tizen.org/privilege/alarm</privilege>
            <privilege>http://tizen.org/privilege/reminders</privilege>
            <privilege>http://tizen.org/privilege/sms</privilege>
            <privilege>http://tizen.org/privilege/vibration</privilege>
            <privilege>http://tizen.org/privilege/file</privilege>
        </privileges>
    </application>
</tizen-manifest>
```

## Mac Catalyst Permissions

Add the following permissions to your `Info.plist`:

```xml
    <key>NSCameraUsageDescription</key>
    <string>This app requires camera access.</string>
    <key>NSMicrophoneUsageDescription</key>
    <string>This app requires access to the microphone.</string>
    <key>NSLocationAlwaysUsageDescription</key>
    <string>This app requires access to your location.</string>
    <key>NSLocationWhenInUseUsageDescription</key>
    <string>This app requires access to your location while in use.</string>
    <key>NSBluetoothAlwaysUsageDescription</key>
    <string>This app requires Bluetooth access.</string>
    <key>NSPhotoLibraryUsageDescription</key>
    <string>This app requires access to your photo library.</string>
    <key>NSUserTrackingUsageDescription</key>
    <string>This app requires tracking permission.</string>
```