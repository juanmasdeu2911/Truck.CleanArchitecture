using Truck.Domain.ValueObjects;

namespace Truck.Domain.Entities
{
    public class Driver : Person
    {
        public virtual string DriverLicense { get; set; }

        public virtual Address Location { get; set; }
    }
}
