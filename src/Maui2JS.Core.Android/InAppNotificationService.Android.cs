using Android.App;
using Android.Content;
using Android.OS;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using Maui2JS.Core.Abstractions;
using Maui2JS.Core.Extensions;
using System;

namespace Maui2JS.Core.Android
{

    public class LocalNotificationService : ILocalNotificationService
    {
        private const string ChannelId = "default";
        private const string ChannelName = "Default";
        private int notificationId = 1000;

        public const string TitleKey = "title";
        public const string MessageKey = "message";
        bool channelInitialized = false;
        int messageId = 0;
        int pendingIntentId = 0;
        public static LocalNotificationService Instance { get; private set; }

        public LocalNotificationService()
        {
            CreateNotificationChannel();
        }

        private void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                var channel = new NotificationChannel(ChannelId, ChannelName, NotificationImportance.Default);
                var notificationManager = (NotificationManager)Platform.AppContext.GetSystemService(Context.NotificationService);
                notificationManager.CreateNotificationChannel(channel);
            }
        }

        // Method to send an instant notification with smallIcon as a parameter
        public async Task<bool> SendInstantNotification(string title, string message, int? smallIconResourceId = null)
        {
            await Permissions.RequestAsync<Permissions.PostNotifications>();
            if (await Permissions.CheckStatusAsync<Permissions.PostNotifications>() != PermissionStatus.Granted)
            {
                return false;
            }
            var intent = new Intent(Platform.CurrentActivity.Intent);
            var pendingIntent = PendingIntent.GetActivity(Platform.AppContext, 0, intent, PendingIntentFlags.Immutable);

            var builder = new NotificationCompat.Builder(Platform.AppContext, ChannelId)
                .SetSmallIcon(smallIconResourceId.HasValue ? smallIconResourceId.Value : Resource.Drawable.mtrl_checkbox_button_icon)
                .SetContentTitle(title)
                .SetContentText(message)
                .SetAutoCancel(true)
                .SetContentIntent(pendingIntent);

            var notificationManager = NotificationManagerCompat.From(Platform.AppContext);
            notificationManager.Notify(notificationId++, builder.Build());

            return true;
        }

        // Method to schedule a notification at a specific time
        public async Task<bool> ScheduleNotification(string title, string message, DateTime notifyTime, int? smallIconResourceId = null)
        {
            await Permissions.RequestAsync<Permissions.PostNotifications>();
            if (await Permissions.CheckStatusAsync<Permissions.PostNotifications>() != PermissionStatus.Granted)
            {
                return false;
            }
            var intent = new Intent(Platform.AppContext.ApplicationContext, typeof(AlarmReceiver));
            intent.PutExtra("title", title);
            intent.PutExtra("message", message);
            intent.PutExtra("smallIconResourceId", smallIconResourceId.HasValue ? smallIconResourceId.Value : Resource.Drawable.mtrl_checkbox_button_icon);

            var pendingIntent = PendingIntent.GetBroadcast(Platform.AppContext, notificationId++, intent, PendingIntentFlags.Immutable);

            var alarmManager = (AlarmManager)Platform.AppContext.GetSystemService(Context.AlarmService);
            long triggerAtMillis = (long)(notifyTime.ToUniversalTime() - DateTime.UtcNow).TotalMilliseconds + SystemClock.ElapsedRealtime();
            alarmManager.Set(AlarmType.ElapsedRealtimeWakeup, triggerAtMillis, pendingIntent);
            return true;
        }
    }

    [BroadcastReceiver(Enabled = true, Exported = true)]
    public class AlarmReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            // Extract notification data from the intent
            string title = intent.GetStringExtra("title");
            string message = intent.GetStringExtra("message");

            // Show notification when alarm is triggered
            LocalNotificationExtensions.SendInstantNotificationAsync(title, message);
        }
    }

    [BroadcastReceiver(Enabled = true, Exported = true)]
    [IntentFilter(new[] { Intent.ActionBootCompleted })]
    public class BootReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (intent.Action == Intent.ActionBootCompleted)
            {
                // Reschedule any reminders here
                // e.g., ScheduleReminder(context, title, message, reminderTime);
            }
        }
    }
}
