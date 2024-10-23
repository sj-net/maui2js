using Microsoft.JSInterop;
using Microsoft.Maui.ApplicationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.ApplicationModel;

namespace Maui2JS.Extensions
{
    public static class PermissionExtensions
    {
        // Battery Permission
        [JSInvokable]
        public static async Task<bool> IsBatteryPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Battery>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestBatteryPermission() =>
            await Permissions.RequestAsync<Permissions.Battery>() == PermissionStatus.Granted;

        // Bluetooth Permission
        [JSInvokable]
        public static async Task<bool> IsBluetoothPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Bluetooth>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestBluetoothPermission() =>
            await Permissions.RequestAsync<Permissions.Bluetooth>() == PermissionStatus.Granted;

        // Calendar Read Permission
        [JSInvokable]
        public static async Task<bool> IsCalendarReadPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.CalendarRead>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestCalendarReadPermission() =>
            await Permissions.RequestAsync<Permissions.CalendarRead>() == PermissionStatus.Granted;

        // Calendar Write Permission
        [JSInvokable]
        public static async Task<bool> IsCalendarWritePermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.CalendarWrite>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestCalendarWritePermission() =>
            await Permissions.RequestAsync<Permissions.CalendarWrite>() == PermissionStatus.Granted;

        // Camera Permission
        [JSInvokable]
        public static async Task<bool> IsCameraPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Camera>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestCameraPermission() =>
            await Permissions.RequestAsync<Permissions.Camera>() == PermissionStatus.Granted;

        // Contacts Read Permission
        [JSInvokable]
        public static async Task<bool> IsContactsReadPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.ContactsRead>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestContactsReadPermission() =>
            await Permissions.RequestAsync<Permissions.ContactsRead>() == PermissionStatus.Granted;

        // Contacts Write Permission
        [JSInvokable]
        public static async Task<bool> IsContactsWritePermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.ContactsWrite>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestContactsWritePermission() =>
            await Permissions.RequestAsync<Permissions.ContactsWrite>() == PermissionStatus.Granted;

        // Flashlight Permission
        [JSInvokable]
        public static async Task<bool> IsFlashlightPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Flashlight>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestFlashlightPermission() =>
            await Permissions.RequestAsync<Permissions.Flashlight>() == PermissionStatus.Granted;

        // Launch App Permission
        [JSInvokable]
        public static async Task<bool> IsLaunchAppPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.LaunchApp>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestLaunchAppPermission() =>
            await Permissions.RequestAsync<Permissions.LaunchApp>() == PermissionStatus.Granted;

        // Location When In Use Permission
        [JSInvokable]
        public static async Task<bool> IsLocationWhenInUsePermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestLocationWhenInUsePermission() =>
            await Permissions.RequestAsync<Permissions.LocationWhenInUse>() == PermissionStatus.Granted;

        // Location Always Permission
        [JSInvokable]
        public static async Task<bool> IsLocationAlwaysPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.LocationAlways>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestLocationAlwaysPermission() =>
            await Permissions.RequestAsync<Permissions.LocationAlways>() == PermissionStatus.Granted;

        // Maps Permission
        [JSInvokable]
        public static async Task<bool> IsMapsPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Maps>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestMapsPermission() =>
            await Permissions.RequestAsync<Permissions.Maps>() == PermissionStatus.Granted;

        // Media Permission
        [JSInvokable]
        public static async Task<bool> IsMediaPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Media>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestMediaPermission() =>
            await Permissions.RequestAsync<Permissions.Media>() == PermissionStatus.Granted;

        // Microphone Permission
        [JSInvokable]
        public static async Task<bool> IsMicrophonePermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Microphone>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestMicrophonePermission() =>
            await Permissions.RequestAsync<Permissions.Microphone>() == PermissionStatus.Granted;

        // Nearby Wifi Devices Permission
        [JSInvokable]
        public static async Task<bool> IsNearbyWifiDevicesPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.NearbyWifiDevices>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestNearbyWifiDevicesPermission() =>
            await Permissions.RequestAsync<Permissions.NearbyWifiDevices>() == PermissionStatus.Granted;

        // Network State Permission
        [JSInvokable]
        public static async Task<bool> IsNetworkStatePermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.NetworkState>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestNetworkStatePermission() =>
            await Permissions.RequestAsync<Permissions.NetworkState>() == PermissionStatus.Granted;

        // Phone Permission
        [JSInvokable]
        public static async Task<bool> IsPhonePermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Phone>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestPhonePermission() =>
            await Permissions.RequestAsync<Permissions.Phone>() == PermissionStatus.Granted;

        // Photos Permission
        [JSInvokable]
        public static async Task<bool> IsPhotosPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Photos>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestPhotosPermission() =>
            await Permissions.RequestAsync<Permissions.Photos>() == PermissionStatus.Granted;

        // Photos Add Only Permission
        [JSInvokable]
        public static async Task<bool> IsPhotosAddOnlyPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.PhotosAddOnly>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestPhotosAddOnlyPermission() =>
            await Permissions.RequestAsync<Permissions.PhotosAddOnly>() == PermissionStatus.Granted;

        // Post Notifications Permission
        [JSInvokable]
        public static async Task<bool> IsPostNotificationsPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.PostNotifications>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestPostNotificationsPermission() =>
            await Permissions.RequestAsync<Permissions.PostNotifications>() == PermissionStatus.Granted;

        // Reminders Permission
        [JSInvokable]
        public static async Task<bool> IsRemindersPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Reminders>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestRemindersPermission() =>
            await Permissions.RequestAsync<Permissions.Reminders>() == PermissionStatus.Granted;

        // Sensors Permission
        [JSInvokable]
        public static async Task<bool> IsSensorsPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Sensors>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestSensorsPermission() =>
            await Permissions.RequestAsync<Permissions.Sensors>() == PermissionStatus.Granted;

        // SMS Permission
        [JSInvokable]
        public static async Task<bool> IsSmsPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Sms>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestSmsPermission() =>
            await Permissions.RequestAsync<Permissions.Sms>() == PermissionStatus.Granted;

        // Speech Permission
        [JSInvokable]
        public static async Task<bool> IsSpeechPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Speech>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestSpeechPermission() =>
            await Permissions.RequestAsync<Permissions.Speech>() == PermissionStatus.Granted;

        // Storage Read Permission
        [JSInvokable]
        public static async Task<bool> IsStorageReadPermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.StorageRead>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestStorageReadPermission() =>
            await Permissions.RequestAsync<Permissions.StorageRead>() == PermissionStatus.Granted;

        // Storage Write Permission
        [JSInvokable]
        public static async Task<bool> IsStorageWritePermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.StorageWrite>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestStorageWritePermission() =>
            await Permissions.RequestAsync<Permissions.StorageWrite>() == PermissionStatus.Granted;

        // Vibrate Permission
        [JSInvokable]
        public static async Task<bool> IsVibratePermissionGranted() =>
            await Permissions.CheckStatusAsync<Permissions.Vibrate>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestVibratePermission() =>
            await Permissions.RequestAsync<Permissions.Vibrate>() == PermissionStatus.Granted;
    }
}
