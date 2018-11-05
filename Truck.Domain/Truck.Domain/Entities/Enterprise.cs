using System;
using Truck.Domain.ValueObjects;

namespace Truck.Domain.Entities
{
    public abstract class Enterprise : Entity<Guid>
    {
        public virtual string Name { get; set; }
        
        public virtual Address Location { get; set; }

        public virtual string Website { get; set; }

        public virtual string Email { get; set; }

        public virtual string Phone { get; set; }

        public virtual string RegistryNumber { get; set; }
    }
}
