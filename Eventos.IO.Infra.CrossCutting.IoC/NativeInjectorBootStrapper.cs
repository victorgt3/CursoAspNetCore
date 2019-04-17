using AutoMapper;
using Eventos.Io.Domain.Core.Bus;
using Eventos.Io.Domain.Core.Events;
using Eventos.Io.Domain.Core.Notifications;
using Eventos.Io.Domain.Eventos.Commands;
using Eventos.Io.Domain.Eventos.Events;
using Eventos.Io.Domain.Eventos.Repository;
using Eventos.Io.Domain.Interfaces;
using Eventos.Io.Infra.data.Context;
using Eventos.IO.Application.Interfaces;
using Eventos.IO.Application.Services;
using Eventos.IO.Infra.CrossCutting.Bus;
using Eventos.IO.Infra.Data.Repository;
using Eventos.IO.Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;


namespace Eventos.IO.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IEventoAppService, EventoAppService>();

            // Domain- Commands
            services.AddScoped<IHandler<RegistrarEventoCommand>, EventoCommandHandler>();
            services.AddScoped<IHandler<AtualizarEventoCommand>, EventoCommandHandler>();
            services.AddScoped<IHandler<ExcluirEventoCommand>, EventoCommandHandler>();

            // Domain - Eventos
            services.AddScoped<IDomainNotificationHandler<DomainNotification>,DomainNotificationHandler>();
            services.AddScoped<IHandler<EventoRegistradoEvent>, EventoEventHandler>();
            services.AddScoped<IHandler<EventoAtualizadoEvent>, EventoEventHandler>();
            services.AddScoped<IHandler<EventoExcluidoEvent>, EventoEventHandler>();

            // Infra - Data
            services.AddScoped<IEventoRepository, EventoRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<EventosContext>();

            // Infra - Bus
            services.AddScoped<IBus, InMemoryBus>();
        }
    }
}
