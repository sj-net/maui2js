using Maui2JS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui2JS.Core
{
    public interface IInAppNotificationService
    {
        Task<Guid> Show(InAppNotificationModel data, NotificationActionButtonModel accept, NotificationActionButtonModel maybe, NotificationActionButtonModel reject);

        Task Hide(Guid guid);
    }
}
