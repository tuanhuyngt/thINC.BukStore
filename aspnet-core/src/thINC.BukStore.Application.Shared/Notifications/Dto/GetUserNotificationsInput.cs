using System;
using Abp.Notifications;
using thINC.BukStore.Dto;

namespace thINC.BukStore.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}