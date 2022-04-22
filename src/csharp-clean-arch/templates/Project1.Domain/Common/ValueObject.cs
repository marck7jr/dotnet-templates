namespace Project1.Domain.Common;
public abstract class ValueObject
{
    public static bool EqualOperator(ValueObject left, ValueObject right)
    {
        if (left is null ^ right is null)
        {
            return false;
        }

        return left is null || left.Equals(right);
    }

    public static bool NotEqualOperator(ValueObject left, ValueObject right) => !EqualOperator(left, right);
    
    public ValueObject? GetCopy() => MemberwiseClone() as ValueObject;

    public abstract IEnumerable<object> GetEqualityObjects();
    
    public override bool Equals(object? obj)
    {
        if (obj is null || GetType() != obj.GetType())
        {
            return false;
        }

        var valueObject = (ValueObject)obj;

        return GetEqualityObjects()
            .SequenceEqual(valueObject.GetEqualityObjects());
    }

    public override int GetHashCode()
    {
        return GetEqualityObjects()
            .Select(x => x is not null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => HashCode.Combine(x, y));
    }
}