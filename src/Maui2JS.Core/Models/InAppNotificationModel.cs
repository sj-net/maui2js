using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui2JS.Core.Models
{
    public class InAppNotificationModel
    {
        public string Message { get; set; }
        public string Duration { get; set; }
        public string BackgroundColorHex { get; set; }
        public string TextColorHex { get; set; }
    }
}
