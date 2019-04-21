using Eventos.Io.Domain.Core.Commands;
using Eventos.Io.Domain.Core.Events;


namespace Eventos.Io.Domain.Core.Bus
{
    public interface IBus
    {
        void SendCommand<T>(T theCommand) where T : Command;
        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}
