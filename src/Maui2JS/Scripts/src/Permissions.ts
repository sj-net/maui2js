import { ASSEMBLY_NAME } from "./constants";

class Permissions {
    /*
    * Check if the battery permission is granted.
    */
    async isBatteryPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsBatteryPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking battery permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the battery permission.
    */
    async requestBatteryPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestBatteryPermission`);
        } catch (error: any) {
            console.error(`Error requesting battery permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the Bluetooth permission is granted.
    */
    async isBluetoothPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsBluetoothPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking Bluetooth permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the Bluetooth permission.
    */
    async requestBluetoothPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestBluetoothPermission`);
        } catch (error: any) {
            console.error(`Error requesting Bluetooth permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the calendar read permission is granted.
    */
    async isCalendarReadPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsCalendarReadPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking calendar read permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the calendar read permission.
    */
    async requestCalendarReadPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestCalendarReadPermission`);
        } catch (error: any) {
            console.error(`Error requesting calendar read permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the calendar write permission is granted.
    */
    async isCalendarWritePermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsCalendarWritePermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking calendar write permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the calendar write permission.
    */
    async requestCalendarWritePermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestCalendarWritePermission`);
        } catch (error: any) {
            console.error(`Error requesting calendar write permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the camera permission is granted.
    */
    async isCameraPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsCameraPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking camera permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the camera permission.
    */
    async requestCameraPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestCameraPermission`);
        } catch (error: any) {
            console.error(`Error requesting camera permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the contacts read permission is granted.
    */
    async isContactsReadPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsContactsReadPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking contacts read permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the contacts read permission.
    */
    async requestContactsReadPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestContactsReadPermission`);
        } catch (error: any) {
            console.error(`Error requesting contacts read permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the contacts write permission is granted.
    */
    async isContactsWritePermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsContactsWritePermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking contacts write permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the contacts write permission.
    */
    async requestContactsWritePermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestContactsWritePermission`);
        } catch (error: any) {
            console.error(`Error requesting contacts write permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the flashlight permission is granted.
    */
    async isFlashlightPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsFlashlightPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking flashlight permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the flashlight permission.
    */
    async requestFlashlightPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestFlashlightPermission`);
        } catch (error: any) {
            console.error(`Error requesting flashlight permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the launch app permission is granted.
    */
    async isLaunchAppPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsLaunchAppPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking launch app permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the launch app permission.
    */
    async requestLaunchAppPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestLaunchAppPermission`);
        } catch (error: any) {
            console.error(`Error requesting launch app permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the location when in use permission is granted.
    */
    async isLocationWhenInUsePermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsLocationWhenInUsePermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking location when in use permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the location when in use permission.
    */
    async requestLocationWhenInUsePermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestLocationWhenInUsePermission`);
        } catch (error: any) {
            console.error(`Error requesting location when in use permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the location always permission is granted.
    */
    async isLocationAlwaysPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsLocationAlwaysPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking location always permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the location always permission.
    */
    async requestLocationAlwaysPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestLocationAlwaysPermission`);
        } catch (error: any) {
            console.error(`Error requesting location always permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the maps permission is granted.
    */
    async isMapsPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsMapsPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking maps permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the maps permission.
    */
    async requestMapsPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestMapsPermission`);
        } catch (error: any) {
            console.error(`Error requesting maps permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the media permission is granted.
    */
    async isMediaPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsMediaPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking media permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the media permission.
    */
    async requestMediaPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestMediaPermission`);
        } catch (error: any) {
            console.error(`Error requesting media permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the microphone permission is granted.
    */
    async isMicrophonePermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsMicrophonePermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking microphone permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the microphone permission.
    */
    async requestMicrophonePermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestMicrophonePermission`);
        } catch (error: any) {
            console.error(`Error requesting microphone permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the nearby WiFi devices permission is granted.
    */
    async isNearbyWifiDevicesPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsNearbyWifiDevicesPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking nearby WiFi devices permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the nearby WiFi devices permission.
    */
    async requestNearbyWifiDevicesPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestNearbyWifiDevicesPermission`);
        } catch (error: any) {
            console.error(`Error requesting nearby WiFi devices permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the network state permission is granted.
    */
    async isNetworkStatePermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsNetworkStatePermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking network state permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the network state permission.
    */
    async requestNetworkStatePermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestNetworkStatePermission`);
        } catch (error: any) {
            console.error(`Error requesting network state permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the phone permission is granted.
    */
    async isPhonePermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsPhonePermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking phone permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the phone permission.
    */
    async requestPhonePermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestPhonePermission`);
        } catch (error: any) {
            console.error(`Error requesting phone permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the photos permission is granted.
    */
    async isPhotosPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsPhotosPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking photos permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the photos permission.
    */
    async requestPhotosPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestPhotosPermission`);
        } catch (error: any) {
            console.error(`Error requesting photos permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the photos add-only permission is granted.
    */
    async isPhotosAddOnlyPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsPhotosAddOnlyPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking photos add-only permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the photos add-only permission.
    */
    async requestPhotosAddOnlyPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestPhotosAddOnlyPermission`);
        } catch (error: any) {
            console.error(`Error requesting photos add-only permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the post notifications permission is granted.
    */
    async isPostNotificationsPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsPostNotificationsPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking post notifications permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the post notifications permission.
    */
    async requestPostNotificationsPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestPostNotificationsPermission`);
        } catch (error: any) {
            console.error(`Error requesting post notifications permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the reminders permission is granted.
    */
    async isRemindersPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsRemindersPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking reminders permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the reminders permission.
    */
    async requestRemindersPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestRemindersPermission`);
        } catch (error: any) {
            console.error(`Error requesting reminders permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the sensors permission is granted.
    */
    async isSensorsPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsSensorsPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking sensors permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the sensors permission.
    */
    async requestSensorsPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestSensorsPermission`);
        } catch (error: any) {
            console.error(`Error requesting sensors permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the SMS permission is granted.
    */
    async isSmsPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsSmsPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking SMS permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the SMS permission.
    */
    async requestSmsPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestSmsPermission`);
        } catch (error: any) {
            console.error(`Error requesting SMS permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the speech permission is granted.
    */
    async isSpeechPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsSpeechPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking speech permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the speech permission.
    */
    async requestSpeechPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestSpeechPermission`);
        } catch (error: any) {
            console.error(`Error requesting speech permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the storage read permission is granted.
    */
    async isStorageReadPermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsStorageReadPermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking storage read permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the storage read permission.
    */
    async requestStorageReadPermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestStorageReadPermission`);
        } catch (error: any) {
            console.error(`Error requesting storage read permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the storage write permission is granted.
    */
    async isStorageWritePermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsStorageWritePermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking storage write permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the storage write permission.
    */
    async requestStorageWritePermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestStorageWritePermission`);
        } catch (error: any) {
            console.error(`Error requesting storage write permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Check if the vibrate permission is granted.
    */
    async isVibratePermissionGranted(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsVibratePermissionGranted`);
        } catch (error: any) {
            console.error(`Error checking vibrate permission: ${error.message}`);
            return false;
        }
    }

    /*
    * Request the vibrate permission.
    */
    async requestVibratePermission(): Promise<boolean> {
        try {
            return await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `RequestVibratePermission`);
        } catch (error: any) {
            console.error(`Error requesting vibrate permission: ${error.message}`);
            return false;
        }
    }
}

export const permissions = new Permissions();
