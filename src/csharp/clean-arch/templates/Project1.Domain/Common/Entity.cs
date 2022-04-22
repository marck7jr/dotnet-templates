namespace Project1.Domain.Common;
public abstract class Entity : IEntity
{
    private List<IDomainEvent>? _domainEvents;
    private int? _hashCode;

    public virtual Guid? Id { get; set; }
    public virtual DateTime? CreatedOn { get; set; }
    public IReadOnlyList<IDomainEvent>? DomainEvents => _domainEvents?.AsReadOnly();
    public bool IsTransient => !Id.HasValue;
    public virtual DateTime? UpdatedOn { get; set; }

    protected void AddDomainEvent(IDomainEvent domainEvent)
    {
        ArgumentNullException.ThrowIfNull(domainEvent);

        _domainEvents ??= new List<IDomainEvent>();
        _domainEvents.Add(domainEvent);
    }

    protected void ClearDomainEvents() => _domainEvents?.Clear();

    protected void RemoveDomainEvent(IDomainEvent domainEvent)
    {
        ArgumentNullException.ThrowIfNull(domainEvent);

        _domainEvents?.Remove(domainEvent);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null || obj is not Entity)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (GetType() != obj.GetType())
        {
            return false;
        }

        var entity = (Entity)obj;

        if (IsTransient || entity.IsTransient)
        {
            return false;
        }
        else
        {
            return Id == entity.Id;
        }
    }

    public override int GetHashCode()
    {
        if (!IsTransient)
        {
            if (!_hashCode.HasValue)
            {
                _hashCode = Id.GetHashCode() ^ 31;
            }

            return _hashCode.Value;
        }

        return base.GetHashCode();
    }

    public static bool operator ==(Entity left, Entity right)
    {
        if (left is null)
        {
            return  right is null;
        }

        return left.Equals(right);
    }

    public static bool operator !=(Entity left, Entity right) => !(left == right);
}