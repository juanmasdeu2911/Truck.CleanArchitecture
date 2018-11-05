using System;

namespace Truck.Domain.Entities
{
    public class Vehicle : Entity<Guid>
    {
        public virtual string PlateId { get; set; }

        public virtual string Country { get; set; }
    }
}
