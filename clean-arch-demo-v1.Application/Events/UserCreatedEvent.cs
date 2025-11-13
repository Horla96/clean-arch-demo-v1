using MediatR;


namespace clean_arch_demo_v1.Application.Events;

public record UserCreatedEvent(Guid UserId) : INotification;
