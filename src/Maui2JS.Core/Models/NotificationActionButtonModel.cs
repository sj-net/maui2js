using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui2JS.Core.Models
{
    public class NotificationActionButtonModel
    {
        public string Text { get; set; }
        public Action<InAppNotificationModel> Action { get; set; }
    }
}
