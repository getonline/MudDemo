using Microsoft.AspNetCore.Components;
using MudDemo.Client.Models.Notification;

namespace MudDemo.Client.Components.Shared;

public partial class NotificationMenu
{
    private List<NotificationModel> _notifications = new()
    {
        new NotificationModel
        {
            NotificationType = NotificationTypes.NewMessage,
            Message = "Alexandre sent you a new message",
            DateTimeStamp = DateTime.Now - TimeSpan.FromMinutes(34)
        },
        new NotificationModel
        {
            NotificationType = NotificationTypes.CommentLiked,
            Message = "Joyce liked a message you sent.",
            DateTimeStamp = DateTime.Now - TimeSpan.FromMinutes(54)
        },
        new NotificationModel
        {
            NotificationType = NotificationTypes.NewEmail,
            Message = "Peter sent you an email.",
            DateTimeStamp = DateTime.Now - TimeSpan.FromDays(2)
        },
        new NotificationModel
        {
            NotificationType = NotificationTypes.OrderPlaced,
            Message = "Your order has been placed.",
            DateTimeStamp = DateTime.Now - TimeSpan.FromDays(10)
        }
    };

    [Parameter] public string Class { get; set; }
}