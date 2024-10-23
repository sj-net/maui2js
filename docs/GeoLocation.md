# GeoLocation

## Uses [Maui Geolocation](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pop-ups?view=net-maui-8.0)

## Description

`GeoLocation` is a TypeScript class that provides methods for retrieving and managing geolocation data in a web application. It supports functionalities such as getting the current location, last known location, permission checks for location access, and real-time location updates.



This will expose the `geoLocation` instance under the global `maui2js` object.

## Usage

### Accessing the geoLocation Object

After including the script, you can access the `geoLocation` instance as follows:

```javascript
const { geoLocation } = maui2js;
```

### Methods

#### 1. Getting Current Location

To retrieve the current geographical location, use the `getCurrentLocation` method:

```javascript
geoLocation.getCurrentLocation().then(currentLocation => {
    console.log(currentLocation);
}).catch(error => {
    console.error('Error getting current location:', error);
});
```

#### 2. Getting Last Known Location

To retrieve the last known geographical location, use the `getLastKnownLocation` method:

```javascript
geoLocation.getLastKnownLocation().then(lastKnownLocation => {
    console.log(lastKnownLocation);
}).catch(error => {
    console.error('Error getting last known location:', error);
});
```

#### 3. Checking Location Permissions

To check if the app has permission to access the location when in use:

```javascript
geoLocation.isLocationWhenInUsePermissionGranted().then(isGranted => {
    console.log('Location when in use permission granted:', isGranted);
}).catch(error => {
    console.error('Error checking permission:', error);
});
```

To check if the app has permission to access the location always:

```javascript
geoLocation.isLocationAlwaysPermissionGranted().then(isGranted => {
    console.log('Location always permission granted:', isGranted);
}).catch(error => {
    console.error('Error checking permission:', error);
});
```

#### 4. Listening for Location Updates

To start listening for location updates, provide callback functions for location changes and failures:

```javascript
    // the parameters between JS & Blazor must be JSON serializable. 
    // Hence we pass a function name as callback and that will be invoked using JSRunTime 
    // Define the callback functions directly in the JavaScript context
    function locationChangedCallback(location) {
        console.log(location);
        const output = `Latitude: ${location.latitude}, Longitude: ${location.longitude}`;
        document.getElementById('listeningLocation').innerText = output;
    };

    function listeningFailedCallback(error) {
        console.log(error);
        document.getElementById('listeningLocation').innerText = `Error: ${GeolocationError[error]}`;
    }

    // Starts listening for location updates and updates HTML when location changes
    function startListeningLocation() {
        document.getElementById('listeningStatus').innerText = "Listening for location updates...";

        maui2js.geoLocation.startListeningLocation(
            "locationChangedCallback",
            "listeningFailedCallback",
            2, // default is 5
            "00:00:03" // default is "00:00:05"
        );
    }
```

#### 5. Stopping Location Updates

To stop listening for location updates, use:

```javascript
geoLocation.stopListeningLocation().then(() => {
    console.log('Stopped listening for location updates.');
}).catch(error => {
    console.error('Error stopping location updates:', error);
});
```

## Enums

### GeolocationError

The `GeolocationError` enum represents possible errors when retrieving location data:

- `PositionUnavailable`: Indicates that the provider was unable to retrieve any position data.
- `Unauthorized`: Indicates that the app is not authorized to receive location data.

### GeolocationAccuracy

The `GeolocationAccuracy` enum defines the level of accuracy for location data:

- 0 -`Default`: Medium accuracy (30-500 meters).
- 1 - `Lowest`: Lowest accuracy (1000-5000 meters).
- 2 - `Low`: Low accuracy (300-3000 meters).
- 3 - `Medium`: Medium accuracy (30-500 meters).
- 4 - `High`: High accuracy (0-100 meters).
- 5 - `Best`: Best accuracy (0-10 meters).
