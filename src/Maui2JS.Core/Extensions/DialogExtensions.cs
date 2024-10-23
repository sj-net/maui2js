using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui2JS.Core.Extensions
{
    public static class DialogExtensions
    {
        [JSInvokable]
        public static async Task ShowAlertAsync(string message, string title = "Alert")
        {
            await Application.Current.MainPage.DisplayAlert(title, message, "OK");
        }

        [JSInvokable]
        public static async Task<bool> ShowConfirmAsync(string message, string title = "Confirm")
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, "OK", "Cancel");
        }

        [JSInvokable]
        public static async Task<string> ShowPromptAsync(string message, string title = "Prompt", string defaultValue = "")
        {
            return await Application.Current?.MainPage?.DisplayPromptAsync(title, message, "OK", "Cancel", initialValue: defaultValue);
        }
    }
}
