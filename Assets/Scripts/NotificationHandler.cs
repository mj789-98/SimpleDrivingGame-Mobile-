using System.Collections;
using System.Collections.Generic;
#if Unity_ANDROID
using Unity.Notifications.Android;
#endif
using UnityEngine;


public class NotificationHandler : MonoBehaviour
{
    #if Unity_ANDROID
    private const string ChannelId = "notification_channel";
  public void ScheduleNotification(System.DateTime dateTime)
  {
    AndroidNotificationChannel notificationChannel = new AndroidNotificationChannel
    {
        Id = ChannelId,
        Name = "Notification Channel",
        Description = "Some random description",
        Importance = Importance.Default
   
    };

    AndroidNotificationCenter.RegisterNotificationChannel(notificationChannel);

    AndroidNotification notification = new AndroidNotification
    {
        Title = "Energy Recharged",
        Text = "Your energy has recharged, come back to play again",
        SmallIcon = "default",
        LargeIcon = "default",
        FireTime = dateTime


    };

    AndroidNotificationCenter.SendNotification(notification, ChannelId);
  }

#endif
}
