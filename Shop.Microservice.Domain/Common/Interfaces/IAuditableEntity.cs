namespace Shop.Microservice.Domain.Common;

public interface IAuditableEntity<T> : IEntityWithId<T>
{
    T? CreatedBy { get; set; }
    DateTime? CreatedDate { get; set; }
    T? UpdatedBy { get; set; }
    DateTime? UpdatedDate { get; set; }
}

public interface IAuditableEntity : IAuditableEntity<Guid>
{
}