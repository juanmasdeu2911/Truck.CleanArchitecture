    namespace Truck.Domain.Entities
{
    public abstract class Entity<TType>
    {
        TType Id { get; set; }
    }
}
