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
    public static class LocationExtensions
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
        public static async Task<bool> StartListeningLocation(string locationUpdatedCallBack, string locationListeningFailedCallBack, GeolocationAccuracy accuracy = GeolocationAccuracy.Best, string minimumTime = null)
        {
            // StartListeningForegroundAsync cannot be called second time without stopping.
            // Check if listener is already active
            if (_locationListener == null)
            {
                var minTime = TimeSpan.FromSeconds(5);

                if (TimeSpan.TryParse(minimumTime, out var timeSpan))
                {
                    minTime = timeSpan;
                }

                _locationListener = new LocationListener(locationUpdatedCallBack, locationListeningFailedCallBack);

                // Start listening for location updates
                var result = await Geolocation.Default.StartListeningForegroundAsync(new GeolocationListeningRequest
                {
                    DesiredAccuracy = accuracy,
                    MinimumTime = minTime
                });

                return true;
            }
            else
            {
                return false;
            }
        }

        [JSInvokable]
        public static bool StopListeningLocation()
        {
            if (_locationListener != null)
            {
                // Stop listening for location updates
                Geolocation.Default.StopListeningForeground();
                _locationListener.Dispose();
                _locationListener = null; // Clear listener
                return true;
            }

            return false;
        }

        private class LocationListener : IDisposable
        {
            private readonly string _locationChangedCallBack;
            private readonly string _listeningFailedCallBack;
            private bool disposedValue = false; // To detect redundant calls

            public LocationListener(string locationChangedCallBack, string listeningFailedCallBack)
            {
                _locationChangedCallBack = locationChangedCallBack;
                _listeningFailedCallBack = listeningFailedCallBack;
                Geolocation.Default.LocationChanged += OnLocationChanged;
                Geolocation.Default.ListeningFailed += ListeningFailed;
            }

            private void ListeningFailed(object sender, GeolocationListeningFailedEventArgs e)
            {
                if (!string.IsNullOrWhiteSpace(_listeningFailedCallBack))
                {
                    Core.Preferences.JSRuntTime.InvokeVoidAsync(_listeningFailedCallBack, e.Error);
                }
            }

            private void OnLocationChanged(object sender, GeolocationLocationChangedEventArgs e)
            {
                if (!string.IsNullOrWhiteSpace(_locationChangedCallBack))
                {
                    Core.Preferences.JSRuntTime.InvokeVoidAsync(_locationChangedCallBack, e.Location);
                }
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