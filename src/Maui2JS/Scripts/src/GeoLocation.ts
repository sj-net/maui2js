import { ASSEMBLY_NAME } from "./constants";

interface GeolocationResult {
    latitude: number;
    longitude: number;
    isSuccessful: boolean;
    errorMessage?: string;
}

enum GeolocationError {
    /// <summary>
    /// The provider was unable to retrieve any position data.
    /// </summary>
    /// <remarks>
    /// Android: Sent when no location provider is available that satisfies the requested geolocation accuracy.
    /// iOS: Getting location data has failed.
    /// Windows: No location data is available from any source.
    /// </remarks>
    PositionUnavailable,
    /// <summary>
    /// The app is not, or no longer, authorized to receive location data.
    /// </summary>
    /// <remarks>
    /// Android: Not used.
    /// iOS: Authorization for getting locations has changed.
    /// Windows: Location sources are turned off.
    /// </remarks>
    Unauthorized
}

enum GeolocationAccuracy {
    // Default is Medium
    /// <summary>Represents default accuracy (Medium), typically within 30-500 meters.</summary>
    Default = 0,

    // iOS:     ThreeKilometers         (3000m)
    // Android: ACCURACY_LOW, POWER_LOW (500m)
    // UWP:     3000                    (1000-5000m)
    /// <summary>Represents the lowest accuracy, using the least power to obtain and typically within 1000-5000 meters.</summary>
    Lowest = 1,

    // iOS:     Kilometer               (1000m)
    // Android: ACCURACY_LOW, POWER_MED (500m)
    // UWP:     1000                    (300-3000m)
    /// <summary>Represents low accuracy, typically within 300-3000 meters.</summary>
    Low = 2,

    // iOS:     HundredMeters           (100m)
    // Android: ACCURACY_MED, POWER_MED (100-500m)
    // UWP:     100                     (30-500m)
    /// <summary>Represents medium accuracy, typically within 30-500 meters.</summary>
    Medium = 3,

    // iOS:     NearestTenMeters        (10m)
    // Android: ACCURACY_HI, POWER_HI   (0-100m)
    // UWP:     High                    (<=10m)
    /// <summary>Represents high accuracy, typically within 10-100 meters.</summary>
    High = 4,

    // iOS:     Best                    (0m)
    // Android: ACCURACY_HI, POWER_HI   (0-100m)
    // UWP:     High                    (<=10m)
    /// <summary>Represents the best accuracy, using the most power to obtain and typically within 10 meters.</summary>
    Best = 5
}

class GeoLocation {
    /**
     * Retrieves the current location asynchronously.
     * @returns A promise that resolves to a GeolocationResult object containing the latitude, longitude, and success status of the operation. If the operation fails, an error message is included.
     */
    async getCurrentLocation(): Promise<GeolocationResult> {
        try {
            const response = await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `GetCurrentLocationAsync`);
            return response as GeolocationResult;
        } catch (error: any) {
            return {
                latitude: 0,
                longitude: 0,
                isSuccessful: false,
                errorMessage: error.message,
            };
        }
    }

    /**
     * Retrieves the last known location asynchronously.
     * @returns A promise that resolves to a GeolocationResult object containing the latitude, longitude, and success status of the operation. If the operation fails, an error message is included.
     */
    async getLastKnownLocation(): Promise<GeolocationResult> {
        try {
            const response = await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `GetLastKnownLocationAsync`);
            return response as GeolocationResult;
        } catch (error: any) {
            return {
                latitude: 0,
                longitude: 0,
                isSuccessful: false,
                errorMessage: error.message,
            };
        }
    }

    /**
     * Checks if the app has permission to access the location when in use.
     * @returns A promise that resolves to a boolean indicating whether the permission is granted or not. If an error occurs, false is returned.
     */
    async isLocationWhenInUsePermissionGranted(): Promise<boolean> {
        try {
            const response = await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsLocationWhenInUsePermissionGranted`);
            return response as boolean;
        } catch (error: any) {
            console.error(`Error requesting permissions: ${error.message}`);
            return false;
        }
    }

    /**
     * Checks if the app has permission to access the location always.
     * @returns A promise that resolves to a boolean indicating whether the permission is granted or not. If an error occurs, false is returned.
     */
    async isLocationAlwaysPermissionGranted(): Promise<boolean> {
        try {
            const response = await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `IsLocationAlwaysPermissionGranted`);
            return response as boolean;
        } catch (error: any) {
            console.error(`Error requesting permissions: ${error.message}`);
            return false;
        }
    }

    /**
     * Starts listening for location updates.
     * @param locationChangedCallback A callback function that will be invoked when the location changes. It receives a GeolocationResult object as a parameter.
     * @param listeningFailedCallback A callback function that will be invoked if listening for location updates fails. It receives a GeolocationError object as a parameter.
     * @param accuracy The desired accuracy level for the location updates. Defaults to GeolocationAccuracy.Best.
     * @param minTime The minimum time interval between location updates. Defaults to "00:00:05" (5 seconds).
     */
    async startListeningLocation(
        locationChangedCallback: (location: GeolocationResult) => void,
        listeningFailedCallback: (error: GeolocationError) => void,
        accuracy: GeolocationAccuracy = GeolocationAccuracy.Best,
        minTime: TimeSpanFormat = "00:00:05"
    ) {
        try {
            // Here you might want to invoke a method in C# that starts listening
            await DotNet.invokeMethodAsync(
                ASSEMBLY_NAME,
                `StartListeningLocation`,
                locationChangedCallback,
                listeningFailedCallback,
                accuracy,
                minTime
            );
        } catch (error: any) {
            console.error(`Error starting location updates: ${error.message}`);
        }
    }

    /**
     * Stops listening for location updates.
     */
    async stopListeningLocation() {
        try {
            await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `StopListeningLocation`);
        } catch (error: any) {
            console.error(`Error stopping location updates: ${error.message}`);
        }
    }
}

// Export an instance of GeoLocation
export const geoLocation = new GeoLocation();

//// Usage Example
//geoLocation.getCurrentLocation().then(result => {
//    if (result.isSuccessful) {
//        console.log(`Current Location - Latitude: ${result.latitude}, Longitude: ${result.longitude}`);
//    } else {
//        console.error(`Error: ${result.errorMessage}`);
//    }
//});

//geoLocation.getLastKnownLocation().then(result => {
//    if (result.isSuccessful) {
//        console.log(`Last Known Location - Latitude: ${result.latitude}, Longitude: ${result.longitude}`);
//    } else {
//        console.error(`Error: ${result.errorMessage}`);
//    }
//});

