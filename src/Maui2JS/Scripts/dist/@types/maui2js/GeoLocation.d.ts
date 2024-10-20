interface GeolocationResult {
    latitude: number;
    longitude: number;
    isSuccessful: boolean;
    errorMessage?: string;
}
declare enum GeolocationError {
    PositionUnavailable = 0,
    Unauthorized = 1
}
declare enum GeolocationAccuracy {
    Default = 0,
    Lowest = 1,
    Low = 2,
    Medium = 3,
    High = 4,
    Best = 5
}
declare class GeoLocation {
    /**
     * Retrieves the current location asynchronously.
     * @returns A promise that resolves to a GeolocationResult object containing the latitude, longitude, and success status of the operation. If the operation fails, an error message is included.
     */
    getCurrentLocation(): Promise<GeolocationResult>;
    /**
     * Retrieves the last known location asynchronously.
     * @returns A promise that resolves to a GeolocationResult object containing the latitude, longitude, and success status of the operation. If the operation fails, an error message is included.
     */
    getLastKnownLocation(): Promise<GeolocationResult>;
    /**
     * Checks if the app has permission to access the location when in use.
     * @returns A promise that resolves to a boolean indicating whether the permission is granted or not. If an error occurs, false is returned.
     */
    isLocationWhenInUsePermissionGranted(): Promise<boolean>;
    /**
     * Checks if the app has permission to access the location always.
     * @returns A promise that resolves to a boolean indicating whether the permission is granted or not. If an error occurs, false is returned.
     */
    isLocationAlwaysPermissionGranted(): Promise<boolean>;
    /**
     * Starts listening for location updates.
     * @param locationChangedCallback A callback function that will be invoked when the location changes. It receives a GeolocationResult object as a parameter.
     * @param listeningFailedCallback A callback function that will be invoked if listening for location updates fails. It receives a GeolocationError object as a parameter.
     * @param accuracy The desired accuracy level for the location updates. Defaults to GeolocationAccuracy.Best.
     * @param minTime The minimum time interval between location updates. Defaults to "00:00:05" (5 seconds).
     */
    startListeningLocation(locationChangedCallback: (location: GeolocationResult) => void, listeningFailedCallback: (error: GeolocationError) => void, accuracy?: GeolocationAccuracy, minTime?: TimeSpanFormat): Promise<void>;
    /**
     * Stops listening for location updates.
     */
    stopListeningLocation(): Promise<void>;
}
export declare const geoLocation: GeoLocation;
export {};
