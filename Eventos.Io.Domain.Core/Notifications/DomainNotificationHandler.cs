using System;
using System.Collections.Generic;
using System.Linq;


namespace Eventos.Io.Domain.Core.Notifications
{
    public class DomainNotificationHandler : IDomainNotificationHandler<DomainNotification>
    {
        private List<DomainNotification> _notifitions;
        public DomainNotificationHandler()
        {
            _notifitions = new List<DomainNotification>();
        }
        public List<DomainNotification> GetNotifivations()
        {
            return _notifitions;
        }

        public void Handle(DomainNotification message)
        {
            _notifitions.Add(message);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Erro: {message.Key} - {message.Valeu}");
        }

        public bool HasNotifications()
        {
            return _notifitions.Any();
        }

        public void Dispose()
        {
            _notifitions = new List<DomainNotification>();
        }
    }
}
