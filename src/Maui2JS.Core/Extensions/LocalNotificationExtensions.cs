using Maui2JS.Core.Abstractions;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui2JS.Core.Extensions
{
    public static class LocalNotificationExtensions
    {
        private static ILocalNotificationService localNotificationService;
        static LocalNotificationExtensions()
        {
            localNotificationService = Ioc.Default.GetService<ILocalNotificationService>();
        }

        [JSInvokable]
        public static async Task<bool> SendInstantNotificationAsync(string title, string message, int? smallIconResourceId = null)
        {
            return await localNotificationService.SendInstantNotification(title, message, smallIconResourceId);
        }

        [JSInvokable]
        public static async Task<bool> ScheduleNotificationAsync(string title, string message, DateTime notifyTime, int? smallIconResourceId = null)
        {
            return await localNotificationService.ScheduleNotification(title, message, notifyTime, smallIconResourceId);
        }
    }
}
