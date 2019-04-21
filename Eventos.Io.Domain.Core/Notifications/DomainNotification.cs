using Eventos.Io.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.Io.Domain.Core.Notifications
{
    public class DomainNotification : Event
    {
        public Guid DomainNoticationId { get; private set; }
        public string Key { get; private set; }
        public string Valeu { get; private set; }
        public int Version { get; private set; }

        public DomainNotification(string key, string value)
        {
            DomainNoticationId = Guid.NewGuid();
            Key = key;
            Valeu = value;
            Version = 1;

        }
    }
}
