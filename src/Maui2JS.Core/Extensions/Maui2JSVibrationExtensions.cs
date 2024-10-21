using Microsoft.JSInterop;
using Microsoft.Maui.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui2JS.Extensions
{
    public static class Maui2JSVibrationExtensions
    {
        [JSInvokable]
        public static async Task StartVibration(string durationTime)
        {
            if (!await PermissionExtensions.IsVibratePermissionGranted())
            {
                await PermissionExtensions.RequestVibratePermission();
            }


            if (double.TryParse(durationTime, out double durationinMilliSeconds))
            {
                Vibration.Vibrate(durationinMilliSeconds);
            }
            else if (TimeSpan.TryParse(durationTime, out TimeSpan duration))
            {
                Vibration.Vibrate(duration);
            }
            else
            {
                throw new ArgumentException($"Invalid duration time ({durationTime})");
            }
        }

        [JSInvokable]
        public static Task StopVibration()
        {
            Vibration.Cancel();
            return Task.CompletedTask;
        }
    }
}
