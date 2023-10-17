namespace Notification.Microservice.Domain.Entities;

public interface IEntity
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    Guid Id { get; set; }
}
