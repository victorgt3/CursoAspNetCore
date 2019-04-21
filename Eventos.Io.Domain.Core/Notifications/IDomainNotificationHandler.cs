﻿using Eventos.Io.Domain.Core.Events;
using System.Collections.Generic;

namespace Eventos.Io.Domain.Core.Notifications
{
    public interface IDomainNotificationHandler<T> : IHandler<T> where T : Message
    {

        bool HasNotifications();
        List<T> GetNotifivations();
    }
}
