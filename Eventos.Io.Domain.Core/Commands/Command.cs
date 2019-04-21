using Eventos.Io.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.Io.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; private set; }

        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
