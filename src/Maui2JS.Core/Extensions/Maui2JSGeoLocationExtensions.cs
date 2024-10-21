using Microsoft.JSInterop;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui2JS.Extensions
{
    public static class Maui2JSGeoLocationExtensions
    {
        private static LocationListener _locationListener;

        [JSInvokable]
        public static async Task<GeolocationResult> GetCurrentLocationAsync()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Medium));
                }

                if (location != null)
                {
                    return new GeolocationResult
                    {
                        Latitude = location.Latitude,
                        Longitude = location.Longitude,
                        IsSuccessful = true
                    };
                }

                return new GeolocationResult { IsSuccessful = false };
            }
            catch (Exception ex)
            {
                return new GeolocationResult { IsSuccessful = false, ErrorMessage = ex.Message };
            }
        }

        [JSInvokable]
        public static async Task<GeolocationResult> GetLastKnownLocationAsync()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    return new GeolocationResult
                    {
                        Latitude = location.Latitude,
                        Longitude = location.Longitude,
                        IsSuccessful = true
                    };
                }

                return new GeolocationResult { IsSuccessful = false };
            }
            catch (Exception ex)
            {
                return new GeolocationResult { IsSuccessful = false, ErrorMessage = ex.Message };
            }
        }

        [JSInvokable]
        public static async Task StartListeningLocation(Action<Location> locationUpdated, Action<GeolocationError> locationListeningFailed, GeolocationAccuracy accuracy = GeolocationAccuracy.Best, string minimumTime = null)
        {
            var minTime = TimeSpan.FromSeconds(5);

            if (TimeSpan.TryParse(minimumTime, out var timeSpan))
            {
                minTime = timeSpan;
            }

            // Check if listener is already active
            if (_locationListener == null)
            {
                _locationListener = new LocationListener(locationUpdated, locationListeningFailed);
            }


            // Start listening for location updates
            await Geolocation.Default.StartListeningForegroundAsync(new GeolocationListeningRequest
            {
                DesiredAccuracy = accuracy,
                MinimumTime = minTime
            });
        }

        [JSInvokable]
        public static void StopListeningLocation()
        {
            if (_locationListener != null)
            {
                // Stop listening for location updates
                Geolocation.Default.StopListeningForeground();
                _locationListener.Dispose();
                _locationListener = null; // Clear listener
            }
        }

        private class LocationListener : IDisposable
        {
            private readonly Action<Location> _locationChanged;
            private readonly Action<GeolocationError> _listeningFailed;
            private bool disposedValue = false; // To detect redundant calls

            public LocationListener(Action<Location> locationChanged, Action<GeolocationError> listeningFailed)
            {
                _locationChanged = locationChanged;
                _listeningFailed = listeningFailed;
                Geolocation.Default.LocationChanged += OnLocationChanged;
                Geolocation.Default.ListeningFailed += ListeningFailed;
            }

            private void ListeningFailed(object sender, GeolocationListeningFailedEventArgs e)
            {
                _listeningFailed(e.Error);
            }

            private void OnLocationChanged(object sender, GeolocationLocationChangedEventArgs e)
            {
                _locationChanged(e.Location);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!disposedValue)
                {
                    if (disposing)
                    {
                        // free managed resources
                        Geolocation.Default.LocationChanged -= OnLocationChanged;
                        Geolocation.Default.ListeningFailed -= ListeningFailed;
                    }

                    // free unmanaged resources
                    disposedValue = true;
                }
            }
        }
    }

    public class GeolocationResult
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
    }
}