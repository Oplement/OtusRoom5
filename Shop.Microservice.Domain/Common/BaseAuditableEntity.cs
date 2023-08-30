namespace Shop.Microservice.Domain.Common;

public class BaseAuditableEntity : IAuditableEntity
{
    public Guid Id { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public Guid UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}