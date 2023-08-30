namespace Shop.Microservice.Domain.Common;

public interface IEntityWithId<T>
{
    T Id { get; set; }
}

public interface IEntityWithId : IEntityWithId<Guid>
{
}