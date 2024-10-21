using Microsoft.JSInterop;
using Microsoft.Maui.ApplicationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace Maui2JS.Extensions
{
    public static class PermissionExtensions
    {
        // Battery Permission
        [JSInvokable]
        public static async Task<bool> IsBatteryPermissionGranted() =>
            await CheckStatusAsync<Battery>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestBatteryPermission() =>
            await RequestAsync<Battery>() == PermissionStatus.Granted;

        // Bluetooth Permission
        [JSInvokable]
        public static async Task<bool> IsBluetoothPermissionGranted() =>
            await CheckStatusAsync<Bluetooth>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestBluetoothPermission() =>
            await RequestAsync<Bluetooth>() == PermissionStatus.Granted;

        // Calendar Read Permission
        [JSInvokable]
        public static async Task<bool> IsCalendarReadPermissionGranted() =>
            await CheckStatusAsync<CalendarRead>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestCalendarReadPermission() =>
            await RequestAsync<CalendarRead>() == PermissionStatus.Granted;

        // Calendar Write Permission
        [JSInvokable]
        public static async Task<bool> IsCalendarWritePermissionGranted() =>
            await CheckStatusAsync<CalendarWrite>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestCalendarWritePermission() =>
            await RequestAsync<CalendarWrite>() == PermissionStatus.Granted;

        // Camera Permission
        [JSInvokable]
        public static async Task<bool> IsCameraPermissionGranted() =>
            await CheckStatusAsync<Camera>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestCameraPermission() =>
            await RequestAsync<Camera>() == PermissionStatus.Granted;

        // Contacts Read Permission
        [JSInvokable]
        public static async Task<bool> IsContactsReadPermissionGranted() =>
            await CheckStatusAsync<ContactsRead>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestContactsReadPermission() =>
            await RequestAsync<ContactsRead>() == PermissionStatus.Granted;

        // Contacts Write Permission
        [JSInvokable]
        public static async Task<bool> IsContactsWritePermissionGranted() =>
            await CheckStatusAsync<ContactsWrite>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestContactsWritePermission() =>
            await RequestAsync<ContactsWrite>() == PermissionStatus.Granted;

        // Flashlight Permission
        [JSInvokable]
        public static async Task<bool> IsFlashlightPermissionGranted() =>
            await CheckStatusAsync<Flashlight>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestFlashlightPermission() =>
            await RequestAsync<Flashlight>() == PermissionStatus.Granted;

        // Launch App Permission
        [JSInvokable]
        public static async Task<bool> IsLaunchAppPermissionGranted() =>
            await CheckStatusAsync<LaunchApp>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestLaunchAppPermission() =>
            await RequestAsync<LaunchApp>() == PermissionStatus.Granted;

        // Location When In Use Permission
        [JSInvokable]
        public static async Task<bool> IsLocationWhenInUsePermissionGranted() =>
            await CheckStatusAsync<LocationWhenInUse>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestLocationWhenInUsePermission() =>
            await RequestAsync<LocationWhenInUse>() == PermissionStatus.Granted;

        // Location Always Permission
        [JSInvokable]
        public static async Task<bool> IsLocationAlwaysPermissionGranted() =>
            await CheckStatusAsync<LocationAlways>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestLocationAlwaysPermission() =>
            await RequestAsync<LocationAlways>() == PermissionStatus.Granted;

        // Maps Permission
        [JSInvokable]
        public static async Task<bool> IsMapsPermissionGranted() =>
            await CheckStatusAsync<Maps>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestMapsPermission() =>
            await RequestAsync<Maps>() == PermissionStatus.Granted;

        // Media Permission
        [JSInvokable]
        public static async Task<bool> IsMediaPermissionGranted() =>
            await CheckStatusAsync<Media>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestMediaPermission() =>
            await RequestAsync<Media>() == PermissionStatus.Granted;

        // Microphone Permission
        [JSInvokable]
        public static async Task<bool> IsMicrophonePermissionGranted() =>
            await CheckStatusAsync<Microphone>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestMicrophonePermission() =>
            await RequestAsync<Microphone>() == PermissionStatus.Granted;

        // Nearby Wifi Devices Permission
        [JSInvokable]
        public static async Task<bool> IsNearbyWifiDevicesPermissionGranted() =>
            await CheckStatusAsync<NearbyWifiDevices>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestNearbyWifiDevicesPermission() =>
            await RequestAsync<NearbyWifiDevices>() == PermissionStatus.Granted;

        // Network State Permission
        [JSInvokable]
        public static async Task<bool> IsNetworkStatePermissionGranted() =>
            await CheckStatusAsync<NetworkState>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestNetworkStatePermission() =>
            await RequestAsync<NetworkState>() == PermissionStatus.Granted;

        // Phone Permission
        [JSInvokable]
        public static async Task<bool> IsPhonePermissionGranted() =>
            await CheckStatusAsync<Phone>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestPhonePermission() =>
            await RequestAsync<Phone>() == PermissionStatus.Granted;

        // Photos Permission
        [JSInvokable]
        public static async Task<bool> IsPhotosPermissionGranted() =>
            await CheckStatusAsync<Photos>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestPhotosPermission() =>
            await RequestAsync<Photos>() == PermissionStatus.Granted;

        // Photos Add Only Permission
        [JSInvokable]
        public static async Task<bool> IsPhotosAddOnlyPermissionGranted() =>
            await CheckStatusAsync<PhotosAddOnly>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestPhotosAddOnlyPermission() =>
            await RequestAsync<PhotosAddOnly>() == PermissionStatus.Granted;

        // Post Notifications Permission
        [JSInvokable]
        public static async Task<bool> IsPostNotificationsPermissionGranted() =>
            await CheckStatusAsync<PostNotifications>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestPostNotificationsPermission() =>
            await RequestAsync<PostNotifications>() == PermissionStatus.Granted;

        // Reminders Permission
        [JSInvokable]
        public static async Task<bool> IsRemindersPermissionGranted() =>
            await CheckStatusAsync<Reminders>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestRemindersPermission() =>
            await RequestAsync<Reminders>() == PermissionStatus.Granted;

        // Sensors Permission
        [JSInvokable]
        public static async Task<bool> IsSensorsPermissionGranted() =>
            await CheckStatusAsync<Sensors>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestSensorsPermission() =>
            await RequestAsync<Sensors>() == PermissionStatus.Granted;

        // SMS Permission
        [JSInvokable]
        public static async Task<bool> IsSmsPermissionGranted() =>
            await CheckStatusAsync<Sms>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestSmsPermission() =>
            await RequestAsync<Sms>() == PermissionStatus.Granted;

        // Speech Permission
        [JSInvokable]
        public static async Task<bool> IsSpeechPermissionGranted() =>
            await CheckStatusAsync<Speech>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestSpeechPermission() =>
            await RequestAsync<Speech>() == PermissionStatus.Granted;

        // Storage Read Permission
        [JSInvokable]
        public static async Task<bool> IsStorageReadPermissionGranted() =>
            await CheckStatusAsync<StorageRead>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestStorageReadPermission() =>
            await RequestAsync<StorageRead>() == PermissionStatus.Granted;

        // Storage Write Permission
        [JSInvokable]
        public static async Task<bool> IsStorageWritePermissionGranted() =>
            await CheckStatusAsync<StorageWrite>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestStorageWritePermission() =>
            await RequestAsync<StorageWrite>() == PermissionStatus.Granted;

        // Vibrate Permission
        [JSInvokable]
        public static async Task<bool> IsVibratePermissionGranted() =>
            await CheckStatusAsync<Vibrate>() == PermissionStatus.Granted;

        [JSInvokable]
        public static async Task<bool> RequestVibratePermission() =>
            await RequestAsync<Vibrate>() == PermissionStatus.Granted;
    }
}
