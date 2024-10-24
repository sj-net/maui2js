using Maui2JS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui2JS.Core.Abstractions
{
    public interface ILocalNotificationService
    {
        Task<bool> SendInstantNotification(string title, string message, int? smallIconResourceId = null);
        Task<bool> ScheduleNotification(string title, string message, DateTime notifyTime, int? smallIconResourceId = null);
    }
}
